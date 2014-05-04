using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class WindowsImpAbstractFactory
    {
        public static WindowsImp MakeWindowsImp(Type className)
        {
            if (className.FullName == "Bridge.PMWindowsImp")
            {
                return new PMWindowsImp();
            }
            if (className.FullName == "Bridge.XWindowsImp")
            {
                return new XWindowsImp();
            }

            return null;
        }
    }
}
