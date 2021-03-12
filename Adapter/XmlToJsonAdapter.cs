using System.Linq;
using System.Text.Json.Serialization;
using Convert = System.Convert;

namespace DesignPatterns.Adapter
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly CustomXmlConverter _xmlConverter;

        public XmlToJsonAdapter(CustomXmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public void ConvertXmlToJson()
        {
            var manufacturers = _xmlConverter.GetXml()
                .Element("Manufacturers")
                ?.Elements("Manufacturer")
                .Select(m => new Manufacturer
                {
                    City = m.Attribute("City")?.Value,
                    Name = m.Attribute("Name")?.Value,
                    Year = Convert.ToInt32(m.Attribute("Year")?.Value)
                });

            new CustomJsonConverter(manufacturers).ConvertToJson();
        }
    }
}