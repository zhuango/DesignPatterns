using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class HelpHandler
    {
        private HelpHandler successor;
        private Topic topic;
        public HelpHandler(HelpHandler helpHandler = null, Topic topic = Topic.Unknow)
        {
            this.successor = helpHandler;
            this.topic = topic;
        }

        public virtual Boolean HasHelp()
        {
            return topic != Topic.Unknow;
        }
        public virtual void SetHandler(HelpHandler helpHandler, Topic topic)
        {
            this.successor = helpHandler;
            this.topic = topic;
        }
        public virtual void HandleHelp()
        {
            if (this.successor != null)
            {
                this.successor.HandleHelp();
            }
        }
    }
}
