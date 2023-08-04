// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Xml.Serialization;
using XmlParser;

Parser parser = new Parser();
string filePath = "C:\\Users\\Hisham-PC\\Downloads\\Xml.xml";

// Read the XML content from the file
string xmlContent = File.ReadAllText(filePath);
var result = parser.ParseXml(xmlContent);
Console.ReadLine();


public class Parser
{

    public InsurancePlans ParseXml(string xml)
    {
        InsurancePlans insurancePlans = new InsurancePlans();

        XmlSerializer serializer = new XmlSerializer(typeof(Profile));
        Profile profile = null;
        using (StringReader reader = new StringReader(xml))
        {
            profile = (Profile)serializer.Deserialize(reader);

        }
        insurancePlans.profile = profile;
        insurancePlans.ElectronicPayorId = profile.Elr.Header.Payerid;

        foreach (var item in profile.Elr.Ln)
        {
            if (item?.Msg?.Text == "BITEWING XRAY")
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.BWFreq = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Timeperiod == "Visit")
                    insurancePlans.BWPercentage = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
            }
            else if (item?.Msg?.Text == "SEALANTS")
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.SealantFreq = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Qtyqual?.Contains("Age") == true)
                    insurancePlans.SealantAge = $"Age {item?.Qty}";
            }
            else if (item?.Msg?.Text == "CLEANING")
            {
                insurancePlans.Freq4910 = $"{item?.Qty} per {item?.Timeperiod}";
                insurancePlans.ProphyFreq = $"{item?.Qty} per {item?.Timeperiod}";
                insurancePlans.PerioMaint4910 = item.Tos.Code;
            }
            else if (item?.Msg?.Text == "ORAL EXAM")
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.Freq0140 = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Timeperiod == "Visit")
                    insurancePlans.Perc0140 = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
            }
            else if (item?.Msg?.Text == "FULL MOUTH")
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.FMXFreq = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Timeperiod == "Visit")
                    insurancePlans.FMXPercentage = item?.Percent!=null ? Convert.ToInt32(item?.Percent) : 0;
            }
            else if (item?.Msg?.Text == "FULL MOUTH")
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.FMDFreq = $"{item?.Qty} per {item?.Timeperiod}";

                insurancePlans.FMD = item.Tos.Code;
            }
            else if (item?.Msg?.Text == "PALLIATIVE TREATMENT")
            {
                if (item?.Timeperiod == "Calendar Year")
                    insurancePlans.PAFreq = $"{item?.Amt} per {item?.Timeperiod}";

                else if (item?.Timeperiod == "Visit")
                    insurancePlans.PAPercentage = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
            }
            else if (item?.Msg?.Text == "PANOREX")
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.PANOFreq = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Timeperiod == "Visit")
                    insurancePlans.PANOPercentage = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
            }

            else if (item?.Msg?.Text == "FLUORIDE")
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.FlourideFreq = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Qtyqual?.Contains("Age") == true)
                    insurancePlans.FlourideAgeCovered = $"Age {item?.Qty}";
            }
            else if (item?.Msg?.Text == "ROOT CANAL")
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.Freq4346 = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Timeperiod == "Visit")
                    insurancePlans.Percentage4346 = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
            }
        }

        //insurancePlans.BWFreq=profile.Elr.Ln.Contains()
        return insurancePlans;
    }
}
