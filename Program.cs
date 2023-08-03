﻿// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using XmlParser;

Parser parser = new Parser();
string filePath = "C:\\Users\\Hisham-PC\\Downloads\\Xml.xml";

// Read the XML content from the file
string xmlContent = File.ReadAllText(filePath);
var result=parser.ParseXml(xmlContent);
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
        return insurancePlans;
    }
}
