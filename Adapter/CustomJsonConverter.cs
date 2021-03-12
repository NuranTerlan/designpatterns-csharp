using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace DesignPatterns.Adapter
{
    public class CustomJsonConverter
    {
        private readonly IEnumerable<Manufacturer> _manufacturers;

        public CustomJsonConverter(IEnumerable<Manufacturer> manufacturers)
        {
            _manufacturers = manufacturers;
        }

        public string ConvertToJson()
        {
            var manufacturers = JsonSerializer.Serialize(_manufacturers, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Console.WriteLine("\nManufacturers List as JSON =>");
            Console.WriteLine(manufacturers);

            return manufacturers;
        }
    }
}