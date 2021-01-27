using System;
using System.Text;

namespace DesignPatterns
{
    public class ProductStockReport
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }

        public override string ToString() => new StringBuilder()
            .AppendLine(Header)
            .AppendLine(Body)
            .AppendLine(Footer).ToString();
    }
}