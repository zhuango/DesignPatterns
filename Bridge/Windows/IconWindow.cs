using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class IconWindow : WindowsBase
    {
        private String mBitMapName;
        public IconWindow(View view)
        :base(view)
        {
            this.mBitMapName = "";
        }
        public override void DrawContents()
        {
            WindowsImp windowsImp = GetWindowsImp();
            if (windowsImp != null)
            {
                windowsImp.DeviceBitmap(this.mBitMapName, new Coord(0), new Coord(0));
            }

        }
    }
}
