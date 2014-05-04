using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Line : Graphic
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a line.");
        }
    }
}
