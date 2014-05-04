using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IShape
    {
        void BoundingBox(Point bootomLeft, Point topRight);
        TextManipulator CreateManipulator();
    }
}
