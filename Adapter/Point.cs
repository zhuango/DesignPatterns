using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Point
    {
        private Coord coordX;
        private Coord coordY;
        public Point(Coord coord1, Coord coord2)
        {
            this.coordX = coord1;
            this.coordY = coord2;
        }
    }
}
