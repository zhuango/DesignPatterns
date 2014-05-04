using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class MacroCommand : Command
    {
        private List<Command> commands;

        public MacroCommand()
        {
            commands = new List<Command>();
        }
        public void Add(Command command)
        {
            this.commands.Add(command);
        }
        public void Remove(Command command)
        {
            this.commands.Remove(command);
        }
        public override void Execute()
        {
            foreach (Command command in this.commands)
            {
                command.Execute();
            }
        }
    }
}
