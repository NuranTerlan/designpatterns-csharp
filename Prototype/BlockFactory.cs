using System;

namespace DesignPatterns.Prototype
{
    public class BlockFactory
    {
        public static IBlock Create(string content)
        {
            if (DateTime.TryParse(content, out var date))
            {
                return new DateTimeBlock
                {
                    Format = "dd/MM/yyyy",
                    DateTime = date
                };
            }
            else if (int.TryParse(content, out var number))
            {
                return new NumberBlock {Number = number};
            }

            return new TextBlock {Content = content};
        }
    }
}