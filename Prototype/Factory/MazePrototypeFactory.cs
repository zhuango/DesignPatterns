using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MazePrototypeFactory : MazeFactory
    {
        private Maze mPrototypeMaze;
        private Wall mPrototypeWall;
        private Room mPrototypeRoom;
        private Door mPrototypeDoor;

        public MazePrototypeFactory(Maze maze, Wall wall, Room room, Door door)
        {
            this.mPrototypeMaze = maze;
            this.mPrototypeWall = wall;
            this.mPrototypeRoom = room;
            this.mPrototypeDoor = door;
        }

		public override Maze MakeMaze()
		{
			return new Maze ();
		}

        public override Wall MakeWall()
		{
            return mPrototypeWall.Clone();
		}

        public override Room MakeRoom(int roomNumber)
		{
            return this.mPrototypeRoom.Clone();
		}

        public override Door MakeDoor(Room room1, Room room2)
		{
            Door door = this.mPrototypeDoor.Clone();
            door.Initialize(room1, room2);
            return door;
		}
    }
}
