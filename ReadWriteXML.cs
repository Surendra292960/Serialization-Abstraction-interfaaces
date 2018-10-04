using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace ConsoleApp1.Exception_and_Indexers
{
    class ReadWriteXML
    {
        static void Main(string[] args)
        {
            XmlTextWriter textWriter = new XmlTextWriter("g:\\myXmFile.xml", null);
     
            textWriter.WriteStartDocument();
            textWriter.WriteComment("First Comment XmlTextWriter Sample Example");
            textWriter.WriteComment("myXmlFile.xml in root dir");
            textWriter.WriteStartElement("Student");
            textWriter.WriteStartElement("r", "RECORD", "urn:record");
            textWriter.WriteStartElement("Name", "");
            textWriter.WriteString("Surendra");
            textWriter.WriteEndElement(); 
            textWriter.WriteStartElement("Address", "");
            textWriter.WriteString("BTM");
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument(); 
            textWriter.Close();
        }
    }
}   
       