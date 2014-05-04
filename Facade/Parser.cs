using System;
namespace Facade
{
    public class Parser
    {
        public Parser()
        { }
        public virtual void Parse(Scanner scanner, ProgramNodeBuilder nodeBuilder)
        {
            Console.WriteLine("Scan.");
            Console.WriteLine("Build Program node");
        }
    }
}
