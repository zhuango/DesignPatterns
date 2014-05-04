using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Dialog : Widget
    {
        public Dialog(HelpHandler helpHandler, Topic t = Topic.Unknow)
            : base(null)
        {
            this.SetHandler(helpHandler, t);
        }

        public override void HandleHelp()
        {
            if (this.HasHelp())
            {
                Console.WriteLine("Dialog");
            }
            else
            {
                base.HandleHelp();
            }
        }
    }
}
