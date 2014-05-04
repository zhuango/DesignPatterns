using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class TextManipulator : Manipulator
    {
        public TextManipulator(IShape shape)
            : base(shape)
        {

        }
    }
}
