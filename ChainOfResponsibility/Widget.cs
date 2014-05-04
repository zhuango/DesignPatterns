using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Widget : HelpHandler
    {
        protected Widget(Widget widget, Topic t = Topic.Unknow)
            :base(widget, t)
        {
            this._parent = widget;
        }
        private Widget _parent;
    }
}
