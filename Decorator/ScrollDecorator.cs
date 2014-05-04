using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(IVisualComponent compt)
            : base(compt)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DrawScroll();
        }

        public void DrawScroll()
        {
            Console.WriteLine("Draw a scroll.");
        }
    }
}
