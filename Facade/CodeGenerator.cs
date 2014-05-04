using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CodeGenerator
    {
        private BytecodeStream byteStream;
        public CodeGenerator(BytecodeStream codeStream)
        {
            this.byteStream = codeStream;
        }
        public void Visit(ProgramNode node)
        {
            Console.WriteLine("Visit node");
        }
    }
}
