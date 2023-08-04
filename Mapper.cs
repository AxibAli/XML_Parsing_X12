using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace XmlParser
{
    public class InsurancePlans
    {
        public Guid Id { get; set; }
        public string LastModifiedBy { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string CarrierNetwork { get; set; }
        [Required]
        public string GroupNumber { get; set; }
        public string PlanName { get; set; }
        public string IsInNetwork { get; set; }
        public string EmployerName { get; set; }
        public DateTime DateLastModified { get; set; }
        public string ElectronicPayorId { get; set; }
        public string TelephoneNumber { get; set; }
        public string Address { get; set; }
        public int? PreventativeCoinsurance { get; set; } = 0;
        public int? BasicCoinsurance { get; set; } = 0;
        public int? MajorCoinsurance { get; set; } = 0;
        public int? DenturePerc { get; set; } = 0;
        public int? ProsthodonticPerc { get; set; } = 0;
        public string WaitingPeriods { get; set; }
        public string PolicyCalendarOrFiscal { get; set; }
        public string HasMissingToothClause { get; set; }
        public string HasMissingToothInfo { get; set; }
        public string CrownsPaidOnDate { get; set; }
        #region Preventative
        public string Is0140Preventative { get; set; }
        public string Is0140Covered { get; set; }
        public int? Perc0140 { get; set; }
        public string Freq0140 { get; set; }
        public string TreatmentCanBeDoneSameDayAs0140 { get; set; }
        public string ExamFreqLimitations { get; set; }
        public string SharesFreqWith120150180 { get; set; }
        public int? FMXPercentage { get; set; } = 0;
        public string FMXFreq { get; set; }
        public int? PAPercentage { get; set; } = 0;
        public string PAFreq { get; set; }
        public int? BWPercentage { get; set; } = 0;
        public string BWFreq { get; set; }
        public int? PANOPercentage { get; set; } = 0;
        public string PANOFreq { get; set; }
        public string DeductableAppliesTowardsXRay { get; set; }
        public string Sealants { get; set; }
        public string ProphyFreq { get; set; }
        public string FMD { get; set; }
        public string FMDFreq { get; set; }
        public string Does4355TakePlaceOfProphy { get; set; }
        public string CanBeDoneOnSameDay0180 { get; set; }
        public string FlourideAgeCovered { get; set; }
        public string FlourideFreq { get; set; }
        public string SealantAge { get; set; }
        public string SealantFreq { get; set; }
        public string SRP43414342 { get; set; }
        public string Freq4341 { get; set; }
        public string Can4QuadsSameDay { get; set; }
        public string PerioMaint4910 { get; set; }
        public string Freq4910 { get; set; }
        public string DoShareFreq4910And1110 { get; set; }
        public int? Percentage4346 { get; set; } = 0;
        public string Freq4346 { get; set; }
        public string NightGuard9944 { get; set; }
        public string Freq7880 { get; set; }
        public string Freq9944 { get; set; }
        public string OcclusalOrthoticDevice7880 { get; set; }
        #endregion
        #region Restorative
        public string CompositeDowngradesToAmalgam { get; set; }
        public string ProstheticFreq { get; set; }
        public string CrownBridgeFreq { get; set; }
        public string CompositeFillingFreq { get; set; }
        public string SedFill2940 { get; set; }
        public string BuildUp2950 { get; set; }
        public string PostCore2954 { get; set; }
        public string PulpCapDirect3110 { get; set; }
        public string PulpCapIndirect3120 { get; set; }
        public string RCTStartCode3221 { get; set; }
        public int? RCT1_3310 { get; set; } = 0;
        public int? RCT2_3320 { get; set; } = 0;
        public int? RCT3_3330 { get; set; } = 0;
        public string PorcCrown2740 { get; set; }
        public string TeethNumberApplyToCrownDowngrade { get; set; }
        public string RecemCrown2920 { get; set; }
        public string ThreeQuarterCrn2783 { get; set; }
        public string ThreeQuarterCrnDowngradesTo { get; set; }
        public string Onlay2644 { get; set; }
        public string Onlay2644DowngradesTo { get; set; }
        public string CrownUnderPartial2971 { get; set; }
        public string BridgesAreCovered { get; set; }
        public string BridgeDowngradesToPartial { get; set; }
        public string What67406245DowngradesTo { get; set; }
        #endregion
        #region Implants/Surgery
        public int? NitrousCode9230 { get; set; }
        public int? CTWithLimitedField0364 { get; set; } = 0;
        public string Freq0364 { get; set; }
        public int? CTWithBothJaws0367 { get; set; } = 0;
        public string Freq0367 { get; set; }
        public string Implants6010 { get; set; }
        public string ImplantUncovering6011 { get; set; }
        public string ImplantCrn6058 { get; set; }
        public string ImplantCrnDowngrades { get; set; }
        public string CustAbutment6057 { get; set; }
        public string Extractions { get; set; }
        public int? Perc7140 { get; set; }
        public int? Perc7210 { get; set; } = 0;
        public int? Perc7220 { get; set; } = 0;
        public int? Perc7230 { get; set; } = 0;
        public int? Perc7240 { get; set; } = 0;
        public string BoneGraft7953 { get; set; }
        public string GraftCanBeDoneDayOfExt { get; set; }
        public string ApPosFlap4245 { get; set; }
        #endregion

        public Profile profile { get; set; }
    }



  

    [XmlRoot(ElementName = "header")]
    public class Header
    {

        [XmlAttribute(AttributeName = "instanceid")]
        public string Instanceid { get; set; }

        [XmlAttribute(AttributeName = "elrid")]
        public string Elrid { get; set; }

        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }

        [XmlAttribute(AttributeName = "sbrdep")]
        public string Sbrdep { get; set; }

        [XmlAttribute(AttributeName = "payerid")]
        public string Payerid { get; set; }

        [XmlAttribute(AttributeName = "custid")]
        public string Custid { get; set; }

        [XmlAttribute(AttributeName = "parsedate")]
        public string Parsedate { get; set; }

        [XmlAttribute(AttributeName = "parentcustid")]
        public string Parentcustid { get; set; }

        [XmlAttribute(AttributeName = "contractid")]
        public int Contractid { get; set; }

        [XmlAttribute(AttributeName = "dtcreated")]
        public string Dtcreated { get; set; }

        [XmlAttribute(AttributeName = "transid")]
        public string Transid { get; set; }

        [XmlAttribute(AttributeName = "transpurpose")]
        public int Transpurpose { get; set; }

        [XmlAttribute(AttributeName = "isa")]
        public string Isa { get; set; }

        [XmlAttribute(AttributeName = "gs")]
        public string Gs { get; set; }

        [XmlAttribute(AttributeName = "icn")]
        public int Icn { get; set; }

        [XmlAttribute(AttributeName = "gcn")]
        public int Gcn { get; set; }

        [XmlAttribute(AttributeName = "tid")]
        public int Tid { get; set; }
    }

    [XmlRoot(ElementName = "trace")]
    public class Trace
    {

        [XmlAttribute(AttributeName = "seq")]
        public int Seq { get; set; }

        [XmlAttribute(AttributeName = "num")]
        public string Num { get; set; }

        [XmlAttribute(AttributeName = "origin")]
        public string Origin { get; set; }
    }

    [XmlRoot(ElementName = "src")]
    public class Src
    {

        [XmlElement(ElementName = "trace")]
        public Trace Trace { get; set; }

        [XmlAttribute(AttributeName = "entityid")]
        public string Entityid { get; set; }

        [XmlAttribute(AttributeName = "entitytype")]
        public int Entitytype { get; set; }

        [XmlAttribute(AttributeName = "lname")]
        public string Lname { get; set; }

        [XmlAttribute(AttributeName = "primaryidqual")]
        public string Primaryidqual { get; set; }

        [XmlAttribute(AttributeName = "payerid")]
        public string Payerid { get; set; }
    }

    [XmlRoot(ElementName = "rcv")]
    public class Rcv
    {

        [XmlElement(ElementName = "trace")]
        public Trace Trace { get; set; }

        [XmlAttribute(AttributeName = "entityid")]
        public string Entityid { get; set; }

        [XmlAttribute(AttributeName = "entitytype")]
        public int Entitytype { get; set; }

        [XmlAttribute(AttributeName = "provtype")]
        public string Provtype { get; set; }

        [XmlAttribute(AttributeName = "npi")]
        public string Npi { get; set; }

        [XmlAttribute(AttributeName = "primaryidqual")]
        public string Primaryidqual { get; set; }

        [XmlAttribute(AttributeName = "taxonomy")]
        public string Taxonomy { get; set; }
    }

    [XmlRoot(ElementName = "secid")]
    public class Secid
    {

        [XmlAttribute(AttributeName = "num")]
        public string Num { get; set; }

        [XmlAttribute(AttributeName = "qual")]
        public string Qual { get; set; }

        [XmlAttribute(AttributeName = "plansponsor")]
        public string Plansponsor { get; set; }
    }

    [XmlRoot(ElementName = "date")]
    public class Date
    {

        [XmlAttribute(AttributeName = "qual")]
        public string Qual { get; set; }

        [XmlAttribute(AttributeName = "from")]
        public string From { get; set; }
    }

    [XmlRoot(ElementName = "sbr")]
    public class Sbr
    {

        [XmlElement(ElementName = "secid")]
        public Secid Secid { get; set; }

        [XmlElement(ElementName = "date")]
        public List<Date> Date { get; set; }

        [XmlAttribute(AttributeName = "fname")]
        public string Fname { get; set; }

        [XmlAttribute(AttributeName = "mname")]
        public string Mname { get; set; }

        [XmlAttribute(AttributeName = "lname")]
        public string Lname { get; set; }

        [XmlAttribute(AttributeName = "add1")]
        public string Add1 { get; set; }

        [XmlAttribute(AttributeName = "city")]
        public string City { get; set; }

        [XmlAttribute(AttributeName = "state")]
        public string State { get; set; }

        [XmlAttribute(AttributeName = "zip")]
        public string Zip { get; set; }

        [XmlAttribute(AttributeName = "birthdate")]
        public string Birthdate { get; set; }

        [XmlAttribute(AttributeName = "sex")]
        public string Sex { get; set; }

        [XmlAttribute(AttributeName = "membernum")]
        public string Membernum { get; set; }

        [XmlAttribute(AttributeName = "plansponsor")]
        public string Plansponsor { get; set; }

        [XmlAttribute(AttributeName = "primaryidqual")]
        public string Primaryidqual { get; set; }

        [XmlAttribute(AttributeName = "entitytype")]
        public int Entitytype { get; set; }
    }

    [XmlRoot(ElementName = "tos")]
    public class Tos
    {

        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
    }

    [XmlRoot(ElementName = "coverage")]
    public class Coverage
    {

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "level")]
        public string Level { get; set; }
    }

    [XmlRoot(ElementName = "msg")]
    public class Msg
    {

        [XmlAttribute(AttributeName = "text")]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ln")]
    public class Ln
    {

        [XmlElement(ElementName = "msg")]
        public Msg Msg { get; set; }

        [XmlAttribute(AttributeName = "seq")]
        public int Seq { get; set; }

        [XmlAttribute(AttributeName = "percent")]
        public decimal Percent { get; set; }

        [XmlAttribute(AttributeName = "innetwork")]
        public string Innetwork { get; set; }

        [XmlAttribute(AttributeName = "timeperiod")]
        public string Timeperiod { get; set; }

        [XmlElement(ElementName = "tos")]
        public Tos Tos { get; set; }

        [XmlElement(ElementName = "coverage")]
        public Coverage Coverage { get; set; }

        [XmlAttribute(AttributeName = "qty")]
        public int Qty { get; set; }

        [XmlAttribute(AttributeName = "qtyqual")]
        public string Qtyqual { get; set; }

        [XmlAttribute(AttributeName = "amt")]
        public int Amt { get; set; }
    }

    [XmlRoot(ElementName = "event")]
    public class Event
    {

        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }

        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
    }

    [XmlRoot(ElementName = "elr")]
    public class Elr
    {

        [XmlElement(ElementName = "header")]
        public Header Header { get; set; }

        [XmlElement(ElementName = "src")]
        public Src Src { get; set; }

        [XmlElement(ElementName = "rcv")]
        public Rcv Rcv { get; set; }

        [XmlElement(ElementName = "sbr")]
        public Sbr Sbr { get; set; }

        [XmlElement(ElementName = "ln")]
        public List<Ln> Ln { get; set; }

        [XmlElement(ElementName = "event")]
        public Event Event { get; set; }
    }

    [XmlRoot(ElementName = "profile")]
    public class Profile
    {

        [XmlElement(ElementName = "elr")]
        public Elr Elr { get; set; }
    }


}
