using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            IBooleanExp expression;
            Context context = new Context();

            VariableExp x = new VariableExp("X");
            VariableExp y = new VariableExp("Y");

            expression = new OrExp(new AndExp(new Constant(true), x), new AndExp(y, new NotExp(x)));

            context.Assign(x, false);
            context.Assign(y, true);

            Boolean result = expression.Evaluate(context);
            VariableExp z = new VariableExp("Z");
            NotExp notZ = new NotExp(z);

            IBooleanExp replacement = expression.Replace("y", notZ);

            context.Assign(z, true);

            result = replacement.Evaluate(context);
        }
    }
}
