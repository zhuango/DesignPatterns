using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileStream input = new FileStream("../../Program.cs", FileMode.Open);
            BytecodeStream output = new BytecodeStream();

            CompilerFacade compiler = new CompilerFacade();
            //Do all complier Job.
            compiler.Compile(input, output);
        }
    }
}
