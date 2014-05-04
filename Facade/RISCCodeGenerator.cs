using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class RISCCodeGenerator : CodeGenerator
    {
        public RISCCodeGenerator(BytecodeStream codeStream)
            : base(codeStream)
        {
        }
    }
}
