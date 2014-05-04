using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageProxy proxy = new ImageProxy("ImageName");//no image is newed.
            proxy.image.Draw();//new Image and Draw.
            proxy.image.Draw();
        }
    }
}
