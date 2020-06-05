using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

public class GenerateXml
{

    static void addToMain(string id, string name, string city, string country)
    {
        if (!File.Exists("research.xml"))
        {
            XmlWriter xmlWriter = XmlWriter.Create("research.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Table");
            xmlWriter.WriteAttributeString("id", "name", "city", "country");
            xmlWriter.WriteStartElement("ProjectInfo");
            xmlWriter.WriteStartElement("ID");
            xmlWriter.WriteString(id);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Name");
            xmlWriter.WriteString(name);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("city");
            xmlWriter.WriteString(city);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("ProjextNum");
            xmlWriter.WriteString(country);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
        else
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement xmlElement = xmlDocument.CreateElement("ProjectInfo");
            XmlElement node = xmlDocument.CreateElement("ID");
            node.InnerText = id;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("Name");
            node.InnerText = name;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("city");
            node.InnerText = city;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("country");
            node.InnerText = country;
            xmlElement.AppendChild(node);
            xmlDocument.Load("research.xml");
            XmlElement root = xmlDocument.DocumentElement;
            root.AppendChild(xmlElement);
            xmlDocument.Save("research.xml");
        }
    }
    static void addToObject1(string id, string name, string city, string country)
    {
        if (!File.Exists("researchObject1.xml"))
        {
            XmlWriter xmlWriter = XmlWriter.Create("researchObject1.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Table");
            xmlWriter.WriteAttributeString("id", "name", "city", "country");
            xmlWriter.WriteStartElement("ProjectInfo");
            xmlWriter.WriteStartElement("ID");
            xmlWriter.WriteString(id);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Name");
            xmlWriter.WriteString(name);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("city");
            xmlWriter.WriteString(city);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("country");
            xmlWriter.WriteString(country);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
        else
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement xmlElement = xmlDocument.CreateElement("ProjectInfo");
            XmlElement node = xmlDocument.CreateElement("ID");
            node.InnerText = id;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("Name");
            node.InnerText = name;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("city");
            node.InnerText = city;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("Country");
            node.InnerText = country;
            xmlElement.AppendChild(node);
            xmlDocument.Load("researchObject1.xml");
            XmlElement root = xmlDocument.DocumentElement;
            root.AppendChild(xmlElement);
            xmlDocument.Save("researchObject1.xml");
        }
    }
    static void addToObject2(string id, string name, string city, string country)
    {
        if (!File.Exists("researchObject2.xml"))
        {
            XmlWriter xmlWriter = XmlWriter.Create("researchObject2.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Table");
            xmlWriter.WriteAttributeString("id", "name", "city", "country");
            xmlWriter.WriteStartElement("ProjectInfo");
            xmlWriter.WriteStartElement("ID");
            xmlWriter.WriteString(id);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Name");
            xmlWriter.WriteString(name);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Sex");
            xmlWriter.WriteString(city);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("ProjextNum");
            xmlWriter.WriteString(country);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
        else
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement xmlElement = xmlDocument.CreateElement("ProjectInfo");
            XmlElement node = xmlDocument.CreateElement("ID");
            node.InnerText = id;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("Name");
            node.InnerText = name;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("city");
            node.InnerText = city;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("country");
            node.InnerText = country;
            xmlElement.AppendChild(node);
            xmlDocument.Load("researchObject2.xml");
            XmlElement root = xmlDocument.DocumentElement;
            root.AppendChild(xmlElement);
            xmlDocument.Save("researchObject2.xml");
        }
    }
    static void addToObject3(string id, string name, string city, string country)
    {
        if (!File.Exists("researchObject3.xml"))
        {
            XmlWriter xmlWriter = XmlWriter.Create("researchObject3.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Table");
            xmlWriter.WriteAttributeString("id", "name", "city", "country");
            xmlWriter.WriteStartElement("ProjectInfo");
            xmlWriter.WriteStartElement("ID");
            xmlWriter.WriteString(id);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Name");
            xmlWriter.WriteString(name);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("city");
            xmlWriter.WriteString(city);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("country");
            xmlWriter.WriteString(country);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
        else
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement xmlElement = xmlDocument.CreateElement("ProjectInfo");
            XmlElement node = xmlDocument.CreateElement("ID");
            node.InnerText = id;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("Name");
            node.InnerText = name;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("city");
            node.InnerText = city;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("country");
            node.InnerText = country;
            xmlElement.AppendChild(node);
            xmlDocument.Load("researchObject3.xml");
            XmlElement root = xmlDocument.DocumentElement;
            root.AppendChild(xmlElement);
            xmlDocument.Save("researchObject3.xml");
        }
    }
    static void addToObject4(string id, string name, string city, string country)
    {
        if (!File.Exists("researchObject4.xml"))
        {
            XmlWriter xmlWriter = XmlWriter.Create("researchObject4.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Table");
            xmlWriter.WriteAttributeString("id", "name", "city", "country");
            xmlWriter.WriteStartElement("ProjectInfo");
            xmlWriter.WriteStartElement("ID");
            xmlWriter.WriteString(id);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Name");
            xmlWriter.WriteString(name);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("city");
            xmlWriter.WriteString(city);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("country");
            xmlWriter.WriteString(country);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
        else
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement xmlElement = xmlDocument.CreateElement("ProjectInfo");
            XmlElement node = xmlDocument.CreateElement("ID");
            node.InnerText = id;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("Name");
            node.InnerText = name;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("city");
            node.InnerText = city;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("country");
            node.InnerText = country;
            xmlElement.AppendChild(node);
            xmlDocument.Load("researchObject4.xml");
            XmlElement root = xmlDocument.DocumentElement;
            root.AppendChild(xmlElement);
            xmlDocument.Save("researchObject4.xml");
        }
    }
    static void addToindexFile(string id , string name)
    {
        if (!File.Exists("researchObjectindex.xml"))
        {
            XmlWriter xmlWriter = XmlWriter.Create("researchObjectindex.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Table");
            xmlWriter.WriteAttributeString("id", "name");
            xmlWriter.WriteStartElement("ProjectInfo");
            xmlWriter.WriteStartElement("ID");
            xmlWriter.WriteString(id);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Name");
            xmlWriter.WriteString(name);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
        else
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement xmlElement = xmlDocument.CreateElement("ProjectInfo");
            XmlElement node = xmlDocument.CreateElement("ID");
            node.InnerText = id;
            xmlElement.AppendChild(node);
            node = xmlDocument.CreateElement("Name");
            node.InnerText = name;
            xmlElement.AppendChild(node);
            xmlDocument.Load("researchObjectindex.xml");
            XmlElement root = xmlDocument.DocumentElement;
            root.AppendChild(xmlElement);
            xmlDocument.Save("researchObjectindex.xml");
        }
    }
    static void Process()
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load("research.xml");
        XmlNode root = xmlDocument.DocumentElement;
        root.RemoveAll();
        xmlDocument.Save("research.xml");
        XmlDocument xmlDocument1 = new XmlDocument();
        xmlDocument1.Load("researchObject1.xml");
        XmlNode root1 = xmlDocument1.DocumentElement;
        root1.RemoveAll();
        xmlDocument1.Save("researchObject1.xml");
        XmlDocument xmlDocument2 = new XmlDocument();
        xmlDocument2.Load("researchObject2.xml");
        XmlNode root2 = xmlDocument2.DocumentElement;
        root2.RemoveAll();
        xmlDocument2.Save("researchObject2.xml");
        XmlDocument xmlDocument3 = new XmlDocument();
        xmlDocument3.Load("researchObject3.xml");
        XmlNode root3 = xmlDocument3.DocumentElement;
        root3.RemoveAll();
        xmlDocument3.Save("researchObject3.xml");
        XmlDocument xmlDocument4 = new XmlDocument();
        xmlDocument4.Load("researchObject4.xml");
        XmlNode root4 = xmlDocument4.DocumentElement;
        root4.RemoveAll();
        xmlDocument4.Save("researchObject4.xml");
        addToMain("1", "Hank", "London", "england");
        addToMain("2", "Walt", "Manchester", "england");
        addToMain("3", "junior", "Oxford", "england");
        addToMain("4", "Skyler", "Cairo", "egypt");
        addToMain("5", "micke", "Alex", "egypt");
        addToMain("6", "Guustavo", "Assuit", "egypt");
        addToMain("7", "jesse", "barcelona", "spain");
        addToMain("8", "saul goodman", "seville", "spain");
        addToMain("9", "Heaul", "Valencia", "spain");
        addToMain("10", "john", "paris", "france");
        addToMain("11", "devied", "lyon", "france");
        addToMain("12" , "alex fregsson" , "Rennes" , "france");
        XmlDocument doc = new XmlDocument();
        doc.Load("research.xml");
        XmlNodeList list = doc.GetElementsByTagName("ProjectInfo");
        for (int i = 0; i < list.Count / 4; i++)
        {
            XmlNodeList childrens = list[i].ChildNodes;
            string id = childrens[0].Name;
            string id_Value = childrens[0].InnerText;
            string Name = childrens[1].Name;
            string Name_Value = childrens[1].InnerText;
            string sex = childrens[2].Name;
            string sex_Value = childrens[2].InnerText;
            string ProjectNum = childrens[3].Name;
            string ProjectNum_Value = childrens[3].InnerText;
            addToObject1(id_Value, Name_Value, sex_Value, ProjectNum_Value);
        }
        for (int i = list.Count / 4; i < list.Count / 2; i++)
        {
            XmlNodeList childrens = list[i].ChildNodes;

            string id = childrens[0].Name;
            string id_Value = childrens[0].InnerText;

            string Name = childrens[1].Name;
            string Name_Value = childrens[1].InnerText;

            string sex = childrens[2].Name;
            string sex_Value = childrens[2].InnerText;

            string ProjectNum = childrens[3].Name;
            string ProjectNum_Value = childrens[3].InnerText;
            addToObject2(id_Value, Name_Value, sex_Value, ProjectNum_Value);

        }
        for (int i = list.Count / 2; i < list.Count * 3 / 4; i++)
        {
            XmlNodeList childrens = list[i].ChildNodes;

            string id = childrens[0].Name;
            string id_Value = childrens[0].InnerText;

            string Name = childrens[1].Name;
            string Name_Value = childrens[1].InnerText;

            string sex = childrens[2].Name;
            string sex_Value = childrens[2].InnerText;

            string ProjectNum = childrens[3].Name;
            string ProjectNum_Value = childrens[3].InnerText;
            addToObject3(id_Value, Name_Value, sex_Value, ProjectNum_Value);

        }
        for (int i = list.Count * 3 / 4; i < list.Count; i++)
        {
            XmlNodeList childrens = list[i].ChildNodes;

            string id = childrens[0].Name;
            string id_Value = childrens[0].InnerText;

            string Name = childrens[1].Name;
            string Name_Value = childrens[1].InnerText;

            string sex = childrens[2].Name;
            string sex_Value = childrens[2].InnerText;

            string ProjectNum = childrens[3].Name;
            string ProjectNum_Value = childrens[3].InnerText;
            addToObject4(id_Value, Name_Value, sex_Value, ProjectNum_Value);

        }
    }
    static void indexingforInt()
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load("researchObjectindex.xml");
        XmlNode root = xmlDocument.DocumentElement;
        root.RemoveAll();
        xmlDocument.Save("researchObjectindex.xml");
        XmlDocument doc = new XmlDocument();
        doc.Load("research.xml");
        XmlNodeList list = doc.GetElementsByTagName("ProjectInfo");
        string s = (list.Count/4).ToString();
        addToindexFile("0", "researchObject1");
        addToindexFile(s, "researchObject2");
        s = (list.Count / 2).ToString();
        addToindexFile(s, "researchObject3");
        s = (list.Count *3/ 4).ToString();
        addToindexFile(s, "researchObject4");
    }
    static void searchForCity(string nCity)
    {
        int c = 0;
        XmlDocument doc = new XmlDocument();
        doc.Load("research.xml");
        XmlNodeList list = doc.GetElementsByTagName("ProjectInfo");
        for(int i = 0; i < list.Count; i++)
        {
            XmlNodeList childrens = list[i].ChildNodes;
            string city = childrens[2].Name;
            string city_Value = childrens[2].InnerText;
            c++;
            if(city_Value == nCity)
            {
                string country = childrens[3].Name;
                string country_Value = childrens[3].InnerText;
                Console.Out.WriteLine(city_Value + "  " + country_Value);
                Console.Out.WriteLine("Number OF iterations" + "\t" + c);
                break;
            }
        }
    }
    static void searchOnXML(String s , int n , int c)
    {
        int counter = c;
        string str = n.ToString();
        XmlDocument doc = new XmlDocument();
        doc.Load(s);
        //Console.Out.WriteLine("test");
        XmlNodeList list = doc.GetElementsByTagName("ProjectInfo");
        for(int i =0; i < list.Count; i++)
        {

            XmlNodeList childrens = list[i].ChildNodes;

            string id = childrens[0].Name;
            string id_Value = childrens[0].InnerText;
            string Name = childrens[1].Name;
            string Name_Value = childrens[1].InnerText;
            string city = childrens[2].Name;
            string city_Value = childrens[2].InnerText;
            string country = childrens[3].Name;
            string country_Value = childrens[3].InnerText;
            counter++;
            if (id_Value == str)
            {
                Console.Out.WriteLine(Name_Value + "  "+ city_Value + "  "+ country_Value);
                Console.Out.WriteLine("Number OF iterations" +"\t"+ counter);
                break;
            }
        }
    }
    static void SearchforID(int n)
    {
        int counter = 0;
        indexingforInt();
        string s = n.ToString();
        XmlDocument doc = new XmlDocument();
        doc.Load("researchObjectindex.xml");
        XmlNodeList list = doc.GetElementsByTagName("ProjectInfo");
        int getIndex = n / 3;
        if (getIndex == 4)
        {
            getIndex--;
        }
        XmlNodeList childrens = list[getIndex].ChildNodes;
        string id = childrens[0].Name;
        string id_Value = childrens[0].InnerText;
        string Name = childrens[1].Name;
        string Name_Value = childrens[1].InnerText;
        counter++;
        searchOnXML(Name_Value + ".xml", n, counter);
    }
    private static void Main()
    {
        /**/
        Process();
        SearchforID(12);
        searchForCity("Oxford");
    }
}