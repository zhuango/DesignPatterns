using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(IVisualComponent compt)
            : base(compt)
        {
        }

        public override void Draw()
        {
            base.Draw();
            this.DrawBorder();
        }

        public void DrawBorder()
        {
            Console.WriteLine("Draw Border.");
        }
    }
}
