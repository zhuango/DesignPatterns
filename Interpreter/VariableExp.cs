using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class VariableExp : IBooleanExp
    {
        private String mName;
        public VariableExp(String name)
        {
            this.mName = name;
        }
        public bool Evaluate(Context context)
        {
            return context.Lookup(this.mName);
        }

        public IBooleanExp Replace(string statement, IBooleanExp exp)
        {
            if (this.mName.Equals(statement))
            {
                return exp.Copy();
            }
            else
            {
                return new VariableExp(this.mName);
            }
        }

        public IBooleanExp Copy()
        {
            return new VariableExp(this.mName);
        }
    }
}
