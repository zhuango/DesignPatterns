using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class OrExp : IBooleanExp
    {
        public bool Evaluate(Context context)
        {
            throw new NotImplementedException();
        }

        public IBooleanExp Replace(string statement, IBooleanExp exp)
        {
            throw new NotImplementedException();
        }

        public IBooleanExp Copy()
        {
            throw new NotImplementedException();
        }
    }
}
