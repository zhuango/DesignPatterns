using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RoomWithABomb : Room
    {
        public RoomWithABomb(RoomWithABomb bomb)
            :base(bomb.RoomNumber)
        {
        }
        public RoomWithABomb(int roomNumber) :
            base(roomNumber)
        { }

        public override void Enter()
        {
            Console.WriteLine("Room {0} Bomb!!!.", this.RoomNumber);
        }

        public override Room Clone()
        {
            return new RoomWithABomb(this.RoomNumber);
        }
    }
}
