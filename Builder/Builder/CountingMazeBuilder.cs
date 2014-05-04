using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class CountingMazeBuilder : MazeBuilder
    {
        private int mDoors;
        private int mRooms;

        public CountingMazeBuilder()
        {
            mDoors = mRooms = 0;
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            this.mDoors++;
        }

        public override void BuildRoom(int roomNumber)
        {
            this.mRooms++;
        }

        public void GetCounts(out int roomCount, out int doorCount)
        {
            roomCount = this.mRooms;
            doorCount = this.mDoors;
        }
    }
}
