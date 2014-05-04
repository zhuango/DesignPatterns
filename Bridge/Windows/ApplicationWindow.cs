using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ApplicationWindow : WindowsBase
    {
        public ApplicationWindow(View view)
            : base(view)
        {
        }
        public override void DrawContents()
        {
            GetView().DrawOn(this);
        }
    }
}
