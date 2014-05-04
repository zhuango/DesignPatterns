using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Manipulator
    {
        private IShape shape;
        public Manipulator(IShape shape)
        {
            this.shape = shape;
        }
    }
}
