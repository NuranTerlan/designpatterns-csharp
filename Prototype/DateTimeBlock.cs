using System;

namespace DesignPatterns.Prototype
{
    public class DateTimeBlock : IBlock
    {
        public DateTime DateTime { get; set; }
        public string Format { get; set; }

        public string Render => DateTime.ToString(Format);

        public IBlock Clone() => new DateTimeBlock
        {
            DateTime = DateTime,
            Format = Format
        };

        public override string ToString()
        {
            return $"Right-aligned datetime - {Render} ({Format})";
        }
    }
}