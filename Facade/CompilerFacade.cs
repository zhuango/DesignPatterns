using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Facade
{
    public class CompilerFacade
    {
        public CompilerFacade() { }
        public virtual void Compile(FileStream sourceFile, BytecodeStream byteStream)
        {
            Scanner scanner = new Scanner(sourceFile);
            ProgramNodeBuilder builder = new ProgramNodeBuilder();
            Parser parser = new Parser();
            parser.Parse(scanner, builder);
            RISCCodeGenerator generator = new RISCCodeGenerator(byteStream);
            ProgramNode parseTree = builder.GetRootNode();
            parseTree.Traverse(generator);
        }
    }
}
