using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Constant : IBooleanExp
    {
        private Boolean booleanValue;

        public Constant(Boolean value)
        {
            this.booleanValue = value;
        }

        public bool Evaluate(Context context)
        {
            return this.booleanValue;
        }

        public IBooleanExp Replace(string statement, IBooleanExp exp)
        {
            return new Constant(this.booleanValue);
        }

        public IBooleanExp Copy()
        {
            return new Constant(this.booleanValue);
        }
    }
}
