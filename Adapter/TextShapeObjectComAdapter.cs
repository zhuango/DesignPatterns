using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class TextShapeObjectComAdapter : IShape
    {
        private TextView mTextView;

        public TextShapeObjectComAdapter(TextView textView)
        {
            this.mTextView = textView;
        }
        public void BoundingBox(Point bootomLeft, Point topRight)
        {
            Coord bottom = new Coord();
            Coord left = new Coord();
            Coord width = new Coord();
            Coord height = new Coord();

            //Call from mTextView.
            mTextView.GetOrigin(bottom, left);
            mTextView.GetExtent(width, height);

            bootomLeft = new Point(bottom, left);
            topRight = new Point(bottom + height, left + width);
        }

        public TextManipulator CreateManipulator()
        {
            return new TextManipulator(this);
        }

        public virtual Boolean IsEmpty()
        {
            return mTextView.IsEmpty();
        }
    }
}
