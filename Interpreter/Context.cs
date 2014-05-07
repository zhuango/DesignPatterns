using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Context
    {
        public Boolean Lookup(String statement)
        {
            return true;
        }

        public void Assign(VariableExp exp, Boolean boolValue)
        {
        }
    }
}
