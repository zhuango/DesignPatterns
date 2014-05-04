using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class SimpleCommand<Receiver> : Command
    {
        private Receiver mReceiver;
        private Action mAction;
        public SimpleCommand(Receiver receiver, Action action)
        {
            this.mReceiver = receiver;
            this.mAction = action;
        }
        public override void Execute()
        {
        }
    }
}
