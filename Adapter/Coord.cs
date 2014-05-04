using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Coord
    {
        private uint position;
        public static Coord operator+(Coord coord1, Coord coord2)
        {
            Coord result = new Coord();
            result.position = coord1.position + coord2.position;
            return result;
        }
    }
}
