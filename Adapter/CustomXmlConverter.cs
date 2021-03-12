using System;
using System.Linq;
using System.Xml.Linq;

namespace DesignPatterns.Adapter
{
    public class CustomXmlConverter
    {
        public XDocument GetXml()
        {
            var xDocument = new XDocument();
            var manufacturers = new XElement("Manufacturers");
            var manufacturerAttrs = ManufacturerDataProvider.GetData()
                .Select(m => new XElement("Manufacturer",
                    new XAttribute("City", m.City),
                    new XAttribute("Name", m.Name),
                    new XAttribute("Year", m.Year)));

            manufacturers.Add(manufacturerAttrs);
            xDocument.Add(manufacturers);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}