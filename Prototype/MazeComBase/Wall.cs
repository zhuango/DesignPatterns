using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Wall : IMapSite
    {
        public Wall() { }
        public virtual void Enter()
        {
            Console.WriteLine("Enter the wall");
        }

        public virtual Wall Clone()
        {
            return new Wall();
        }
    }
}
