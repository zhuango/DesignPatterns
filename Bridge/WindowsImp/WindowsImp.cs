using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface WindowsImp
    {
        void ImpTop();
        void ImpBottom();
        void ImpSetExtent(Point point);
        void ImpSetOrigin(Point point);
        void DeviceRect(Coord top, Coord bottom, Coord left, Coord right);
        void DeviceText(String message, Coord top, Coord bottom);
        void DeviceBitmap(String message, Coord top, Coord bottom);
    }
}
