using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public interface IBooleanExp
    {
        Boolean Evaluate(Context context);
        IBooleanExp Replace(String statement, IBooleanExp exp);
        IBooleanExp Copy();
    }
}
