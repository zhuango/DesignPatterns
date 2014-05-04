using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Picture : Graphic
    {
        public Picture()
        {
            this.graphics = new List<Graphic>();
        }
        public override void Draw()
        {
            foreach (Graphic gra in this.graphics)
            {
                gra.Draw();
            }
        }
        public override void Add(Graphic graphic)
        {
            base.Add(graphic);
        }
        public override void Remove(Graphic graphic)
        {
            base.Remove(graphic);
        }
        public override Graphic GetChild(int childNumber)
        {
            return base.GetChild(childNumber);
        }
    }
}
