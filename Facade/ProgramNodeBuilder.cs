using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ProgramNodeBuilder
    {
        private ProgramNode _node;
        public ProgramNodeBuilder()
        {
            _node = new ProgramNode();
        }
        public virtual ProgramNode NewVariable(String variableName)
        {
            return null;
        }
        public virtual ProgramNode NewAssignment(ProgramNode variable, ProgramNode expression)
        {
            return null;
        }
        public virtual ProgramNode NewReturnStatement(ProgramNode value)
        {
            return null;
        }
        public virtual ProgramNode NewCondition(ProgramNode condition, ProgramNode truePart, ProgramNode falsePart)
        {
            return null;
        }
        // ...
        public ProgramNode GetRootNode()
        {
            Console.WriteLine("Get Root Program node.");
            return this._node;
        }
    }
}
