using System;
using DesignPatterns.EnchantedMazeCom;

namespace DesignPatterns
{
	public class EnchantedMazeFactory : MazeFactory
	{
		public EnchantedMazeFactory ()
		{
		}

		public override Room MakeRoom (int roomNumber)
		{
            return new EnchantedRoom(roomNumber);
		}

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new EnchantedDoor(room1, room2);
        }

        public override Wall MakeWall()
        {
            return new EnchantedWall();
        }
	}
}

