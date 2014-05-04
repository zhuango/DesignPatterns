using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class TextView
    {
        public TextView() { }
        public void GetOrigin(Coord x, Coord y) { }
        public void GetExtent(Coord width, Coord height) { }
        public virtual Boolean IsEmpty() 
        {
            return true;
        }
    }
}
