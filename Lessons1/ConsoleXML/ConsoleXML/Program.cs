using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleXML
{
    class Program
    {
        private static void CreateXml()
        {
            XmlDocument doc = new XmlDocument();

            XmlElement inv = doc.CreateElement("Inventory");

            XmlElement car = doc.CreateElement("Car");
            car.SetAttribute("CarID", "001");

            XmlElement make = doc.CreateElement("Make");
            make.InnerText = "GAZ";

            XmlElement color = doc.CreateElement("Color");
            color.InnerText = "Black";

            XmlElement petname = doc.CreateElement("PeName");
            petname.InnerText = "Volga";

            car.AppendChild(make);
            car.AppendChild(color);
            car.AppendChild(petname);

            inv.AppendChild(car);

            doc.AppendChild(inv);

            doc.Save("AutoLot.xml");
        }

        private static void CreateXmlByLINQ()
        {
            XElement doc =
                new XElement("Inventory",
                    new XElement("Car", new XAttribute("CarID", "001"),
                        new XElement("Make", "VAZ"),
                        new XElement("Color", "Yellow"),
                        new XElement("PetName", "Kalina")
                    )
                );
            doc.Save("AutoLot2.xml");
        }

        private static void CreateXmlByLINQ_2()
        {
            XElement doc =
                new XElement("Inventory",
                    new XElement("Car", new XAttribute("CarID", "001"),
                        new XElement("Make", "VAZ"),
                        new XElement("Color", "Yellow"),
                        new XElement("PetName", "Kalina")
                    ),
                    new XElement("Car", new XAttribute("CarID", "002"),
                        new XElement("Make", "VAZ"),
                        new XElement("Color", "Red"),
                        new XElement("PetName", "Kalina2")
                    )
                );
            Console.WriteLine(doc);

            doc.Descendants("PetName").Remove();

            Console.WriteLine(doc);            
        }

        private static void CreateXmlByLINQ_3()
        {
            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Current Inventory of cars."),
                new XProcessingInstruction("xml-stylesheet", "href='MyStyles.css' title='Compact' type='text/css'"),
                new XElement("Inventory",
                    new XElement("Car", new XAttribute("CarID", "001"),
                        new XElement("Make", "VAZ"),
                        new XElement("Color", "Yellow"),
                        new XElement("PetName", "Kalina")
                    ),
                    new XElement("Car", new XAttribute("CarID", "002"),
                        new XElement("Make", "VAZ"),
                        new XElement("Color", "Red"),
                        new XElement("PetName", "Kalina2")
                    )
                )
            );
            Console.WriteLine(doc);

            doc.Save("SimpleInventory.xml");
        }

        private static void CreateXmlFromArrayByLINQ()
        {
            var people = new[] {
                new { FirstName = "Mandy", Age = 22 },
                new { FirstName = "Andrew", Age = 40 },
                new { FirstName = "Dave", Age = 41 },
                new { FirstName = "Sara", Age = 31 }
            };

            XElement peopleDoc = new XElement(
                new XElement("People",
                     from c in people select new XElement("Person",
                                               new XElement("FirstName", c.FirstName),
                                               new XElement("Age", c.Age))
                )
            );

            Console.WriteLine(peopleDoc);
        }

        private static void ParseXML()
        {
            string myElement =
                @"<Car id='3'>
                    <Make>BMW</Make>
                    <Color>White</Color>
                    <PetName>BMW 3</PetName>
                  </Car>";

            XElement xml = XElement.Parse(myElement);
            Console.WriteLine(xml);

            XDocument doc = XDocument.Load("SimpleInventory.xml");
            Console.WriteLine(doc);
        }

        static void Main(string[] args)
        {
            //CreateXml();
            //CreateXmlByLINQ();
            //CreateXmlByLINQ_2();
            //CreateXmlByLINQ_3();

            //CreateXmlFromArrayByLINQ();
            ParseXML();
            Console.ReadLine();
        }
    }
}
