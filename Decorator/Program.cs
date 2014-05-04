using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisualComponent textView = new TextView();
            IVisualComponent borderCompt = new BorderDecorator(textView);
            IVisualComponent scrollCompt = new ScrollDecorator(borderCompt);

            scrollCompt.Draw();
        }
    }
}
