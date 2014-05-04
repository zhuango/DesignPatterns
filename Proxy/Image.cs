using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Image
    {
        public Image()
        {
            Console.WriteLine("Image is newed.");
        }
        public static Image LoadImage(String fileName)
        {
            return new Image();
        }

        public void Draw()
        {
            Console.WriteLine("Draw a image.");
        }
    }
}
