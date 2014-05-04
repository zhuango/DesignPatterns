using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Button : Widget
    {
        public Button(Widget widget, Topic t = Topic.Unknow)
            : base(widget, t)
        {
        }

        public override void HandleHelp()
        {
            if (this.HasHelp())
            {
                Console.WriteLine("Button show help infomation.");
            }
            else
            {
                base.HandleHelp();
            }
        }
    }
}
