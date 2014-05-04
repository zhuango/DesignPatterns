using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class WallWithBomb : Wall
    {
        public override void Enter()
        {
            Console.WriteLine("Wall bomb.");
        }
    }
}
