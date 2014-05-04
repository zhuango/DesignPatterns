using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    public abstract class Graphic
    {
        protected List<Graphic> graphics = null;
        public abstract void Draw();
        public virtual void Add(Graphic graphic) 
        {
            graphics.Add(graphic);
        }
        public virtual void Remove(Graphic graphic)
        {
            graphics.Remove(graphic);
        }
        public virtual Graphic GetChild(int childNumber) 
        {
            return graphics[childNumber];
        }
    }
}
