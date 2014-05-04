using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Decorator : IVisualComponent
    {
        private IVisualComponent component;
        public Decorator(IVisualComponent compt)
        {
            this.component = compt;
        }
        public virtual void Draw()
        {
            component.Draw();
        }
    }
}
