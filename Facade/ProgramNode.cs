using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ProgramNode
    {
        protected List<ProgramNode> nodes;
        public ProgramNode()
        {
            nodes = new List<ProgramNode>();
        }
        public virtual void GetSourcePosition(ref int line, ref int index)
        {
            line = 0;
            index = 0;
        }

        public virtual void Add(ProgramNode node)
        {
            nodes.Add(node);
        }
        public virtual void Remove(ProgramNode node)
        {
            node.Remove(node);
        }
        public virtual void Traverse(CodeGenerator codeGenerator)
        {
            codeGenerator.Visit(this);
            foreach (ProgramNode node in nodes)
            {
                node.Traverse(codeGenerator);
            }
        }
    }
}
