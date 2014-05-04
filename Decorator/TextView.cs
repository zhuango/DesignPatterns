using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TextView : IVisualComponent
    {
        public void Draw()
        {
            Console.WriteLine("Draw a text view.");
        }
    }
}
