using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //Adapter
    public class TextShapeClassInheritAdapter : TextView, IShape
    {
        public TextShapeClassInheritAdapter() { }
        //public void 

        public void BoundingBox(Point bootomLeft, Point topRight)
        {
            Coord bottom = new Coord();
            Coord left = new Coord();
            Coord width = new Coord();
            Coord height = new Coord();

            //inherit from TextView.
            GetOrigin(bottom, left);
            GetExtent(width, height);

            bootomLeft = new Point(bottom, left);
            topRight = new Point(bottom + height, left + width);
        }

        //inherit from iShape.
        public override bool IsEmpty()
        {
            return base.IsEmpty();
        }

        //new function.
        public TextManipulator CreateManipulator()
        {
            return new TextManipulator(this);
        }
    }
}
