using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class AndExp : IBooleanExp
    {
        private IBooleanExp exp1;
        private IBooleanExp exp2;

        public AndExp(IBooleanExp exp1, IBooleanExp exp2)
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }
        public bool Evaluate(Context context)
        {
            return exp1.Evaluate(context) && exp1.Evaluate(context);        
        }

        public IBooleanExp Replace(string statement, IBooleanExp exp)
        {
            return new AndExp(this.exp1.Replace(statement, exp), this.exp2.Replace(statement, exp));
        }

        public IBooleanExp Copy()
        {
            return new AndExp(this.exp1.Copy(), this.exp2.Copy());
        }
    }
}
