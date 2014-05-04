using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Application : HelpHandler
    {
        public Application(Topic topic)
            : base(null, topic)
        {
        }

        public override void HandleHelp()
        {
            Console.WriteLine("Display all info list.");
        }
    }
}
