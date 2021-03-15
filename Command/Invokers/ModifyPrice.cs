using System.Collections.Generic;

namespace DesignPatterns.Command.Invokers
{
    public class ModifyPrice
    {
        private readonly IList<ProductCommand> _commands;
        private ProductCommand _command;

        public ModifyPrice()
        {
            _commands = new List<ProductCommand>();
        }

        public void SetCommand(ProductCommand command) => _command = command;

        public void Invoke()
        {
            _commands.Add(_command);
            _command.ExecuteAction();
        }
    }
}