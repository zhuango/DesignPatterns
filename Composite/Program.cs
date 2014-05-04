using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphic line = new Line();
            Graphic rectangle = new Rectangle();
            Graphic text = new Text();
            Graphic picture1 = new Picture();
            picture1.Add(new Line());
            picture1.Add(new Text());
            picture1.Add(new Rectangle());

            Graphic pictureWhole = new Picture();
            pictureWhole.Add(line);
            pictureWhole.Add(rectangle);
            pictureWhole.Add(text);
            pictureWhole.Add(picture1);

            pictureWhole.Draw();
        }
    }
}
