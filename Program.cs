// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics;
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

            if (item?.Msg.FirstOrDefault(msg => msg.Text == "BITEWING XRAY") != null)
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.BWFreq = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Timeperiod == "Visit")
                    insurancePlans.BWPercentage = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "SEALANTS") != null)
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.SealantFreq = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Qtyqual?.Contains("Age") == true)
                    insurancePlans.SealantAge = $"Age {item?.Qty}";
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "CLEANING") != null)
            {
                insurancePlans.Freq4910 = $"{item?.Qty} per {item?.Timeperiod}";
                insurancePlans.ProphyFreq = $"{item?.Qty} per {item?.Timeperiod}";
                insurancePlans.PerioMaint4910 = item.Tos.Code;
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "ORAL EXAM") != null)
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.Freq0140 = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Timeperiod == "Visit")
                    insurancePlans.Perc0140 = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "FULL MOUTH") != null)
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.FMXFreq = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Timeperiod == "Visit")
                    insurancePlans.FMXPercentage = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "FULL MOUTH") != null)
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.FMDFreq = $"{item?.Qty} per {item?.Timeperiod}";

                insurancePlans.FMD = item.Tos.Code;
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "PALLIATIVE TREATMENT") != null)
            {
                if (item?.Timeperiod == "Calendar Year")
                    insurancePlans.PAFreq = $"{item?.Amt} per {item?.Timeperiod}";

                else if (item?.Timeperiod == "Visit")
                    insurancePlans.PAPercentage = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "PANOREX") != null)
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.PANOFreq = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Timeperiod == "Visit")
                    insurancePlans.PANOPercentage = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
            }

            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "FLUORIDE") != null)
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                    insurancePlans.FlourideFreq = $"{item?.Qty} per {item?.Timeperiod}";

                else if (item?.Qtyqual?.Contains("Age") == true)
                    insurancePlans.FlourideAgeCovered = $"Age {item?.Qty}";
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "PERIODONTAL SCALING") != null)
            {
                if (item?.Qtyqual == "Number of Services or Procedures")
                {
                    insurancePlans.Freq4346 = $"{item?.Qty} per {item?.Timeperiod}";
                    insurancePlans.Freq4341 = $"{item?.Qty} per {item?.Timeperiod}";
                }

                else if (item?.Timeperiod == "Visit")
                {
                    insurancePlans.Percentage4346 = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
                    insurancePlans.SRP43414342 = item?.Percent != null ? item?.Percent.ToString() : "";
                }
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "ONLAY") != null)
            {
                insurancePlans.Onlay2644 = item.Tos.Code;
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "EXTRACTIONS ROUTINE") != null)
            {
                if (item?.Timeperiod == "Visit")
                {
                    insurancePlans.Perc7140 = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
                    insurancePlans.Perc7210 = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
                }
                insurancePlans.Extractions = item.Tos.Code;
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "CROWN RECEMENTATION") != null)
            {
                insurancePlans.RecemCrown2920 = item?.Msg.FirstOrDefault(msg => msg.Text == "CROWN RECEMENTATION").Text;
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "OCCLUSAL ADJUSTMENT") != null)
            {
                insurancePlans.OcclusalOrthoticDevice7880 = item?.Msg.FirstOrDefault(msg => msg.Text == "OCCLUSAL ADJUSTMENT").Text;
            }
            else if (item?.Msg.FirstOrDefault(msg => msg.Text == "ROOT CANAL") != null)
            {
                if (item?.Timeperiod == "Visit")
                {
                    insurancePlans.RCT1_3310 = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
                    insurancePlans.RCT2_3320 = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
                    insurancePlans.RCT3_3330 = item?.Percent != null ? Convert.ToInt32(item?.Percent) : 0;
                }
            }

        }

        //insurancePlans.BWFreq=profile.Elr.Ln.Contains()
        return insurancePlans;
    }
}
