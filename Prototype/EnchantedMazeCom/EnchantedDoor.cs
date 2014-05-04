using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EnchantedMazeCom
{
    public class EnchantedDoor : Door
    {
        public EnchantedDoor(Room room1, Room room2)
            :base(room1, room2)
        {

        }

        public override void Enter()
        {
            Console.WriteLine("Enter a enchanted door.");
        }
    }
}
