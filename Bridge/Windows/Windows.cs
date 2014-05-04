using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class WindowsBase
    {
        private WindowsImp windowsImp;
        private View view;
        private Type windowsImpType;

        public Type WindowsImpType
        {
            set
            {
                this.windowsImpType = value;
            }
        }

        protected WindowsImp GetWindowsImp()
        {
            if (windowsImp == null)
            {
                this.windowsImp = WindowsImpAbstractFactory.MakeWindowsImp(windowsImpType);
            }
            return this.windowsImp;
        }
        protected View GetView()
        {
            return view;
        }
        public WindowsBase(View contents)
        {
            this.view = contents;
            this.windowsImp = null;
            this.windowsImpType = null;
        }
        public virtual void DrawContents() { }
        public virtual void Open() { }
        public virtual void Close() { }
        public virtual void Iconify() { }
        public virtual void Deiconify() { }
        // requests forwarded to implementation
        public virtual void SetOrigin(Point at) { }
        public virtual void SetExtent(Point extent) { }
        public virtual void Raise() { }
        public virtual void Lower() { }
        public virtual void DrawLine(Point point1, Point point2) { }
        public virtual void DrawRect(Point point1, Point point2) { }
        public virtual void DrawPolygon(Point[] points, int n) { }
        public virtual void DrawText(String message, Point point) { }
    }
}
