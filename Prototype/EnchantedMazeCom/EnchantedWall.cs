using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EnchantedMazeCom
{
    public class EnchantedWall : Wall
    {
        public EnchantedWall()
            : base()
        {
        }
        public override void Enter()
        {
            Console.WriteLine("Enter a enchanted wall.");
        }
    }
}
