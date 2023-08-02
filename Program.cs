// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using XmlParser;

Console.WriteLine("Hello, World!");
string filePath = "C:\\Users\\Hisham-PC\\Downloads\\Xml.xml";

// Read the XML content from the file
string xmlContent = File.ReadAllText(filePath);

//string xmlContent = @"<profile>
//                                <!-- XML content here -->
//                             </profile>";

XmlSerializer serializer = new XmlSerializer(typeof(Profile));
using (StringReader reader = new StringReader(xmlContent))
{
    Profile profile = (Profile)serializer.Deserialize(reader);
   
}
