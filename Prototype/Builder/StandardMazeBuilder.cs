using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Direction CommonWall(Room roomFrom, Room roomTo)
        {
            return Direction.East;
        }

        private Maze mMaze;

        public StandardMazeBuilder()
        {
        }

        public override void BuildMaze()
        {
            mMaze = new Maze();
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            Room r1 = mMaze.RoomNo(roomFrom);
            Room r2 = mMaze.RoomNo(roomTo);

            Door door = new Door(r1, r2);

            r1.SetSide(CommonWall(r1, r2), door);
            r2.SetSide(CommonWall(r2, r1), door);
        }

        public override void BuildRoom(int roomNumber)
        {
            if (mMaze.RoomNo(roomNumber) == null)
            {
                Room room = new Room(roomNumber);
                mMaze.AddRoom(room);

                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.West, new Wall());
                room.SetSide(Direction.East, new Wall());
            }
        }

        public override Maze GetMaze()
        {
            return mMaze;
        }
    }
}
