using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class PMWindowsImp : WindowsImp
    {
        public void ImpTop()
        {
            throw new NotImplementedException();
        }

        public void ImpBottom()
        {
            throw new NotImplementedException();
        }

        public void ImpSetExtent(Point point)
        {
            throw new NotImplementedException();
        }

        public void ImpSetOrigin(Point point)
        {
            throw new NotImplementedException();
        }

        public void DeviceRect(Coord top, Coord bottom, Coord left, Coord right)
        {
            throw new NotImplementedException();
        }

        public void DeviceText(string message, Coord top, Coord bottom)
        {
            throw new NotImplementedException();
        }

        public void DeviceBitmap(string message, Coord top, Coord bottom)
        {
            Console.WriteLine("PMWindows DeviceBitMap.");
        }
    }
}
