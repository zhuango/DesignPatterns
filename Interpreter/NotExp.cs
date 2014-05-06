using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class NotExp : IBooleanExp
    {
        private IBooleanExp exp;
        public NotExp(IBooleanExp exp)
        {
            this.exp = exp;
        }

        public IBooleanExp Replace(string statement, IBooleanExp exp)
        {
            return new NotExp(this.exp.Replace(statement, exp));
        }

        public IBooleanExp Copy()
        {
            return new NotExp(this.exp.Copy());
        }

        public bool Evaluate(Context context)
        {
            return !this.exp.Evaluate(context);
        }
    }
}
