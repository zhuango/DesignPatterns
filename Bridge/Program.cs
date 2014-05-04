using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            WindowsBase windows = new IconWindow(view);
            windows.WindowsImpType = typeof(PMWindowsImp);
            windows.DrawContents();

            WindowsBase windowsIcon = new IconWindow(view);
            windowsIcon.WindowsImpType = typeof(XWindowsImp);
            windowsIcon.DrawContents();
        }
    }
}
