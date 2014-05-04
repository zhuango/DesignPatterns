using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Room : IMapSite
    {
        private int mRoomNumber;
        private IMapSite mEastSide;
        private IMapSite mWestSide;
        private IMapSite mSorthSide;
        private IMapSite mNorthSide;
        public int RoomNumber
        {
            get
            {
                return mRoomNumber;
            }
        }
        public Room(int rootNum)
        {
            this.mRoomNumber = rootNum;
        }

        public void SetSide(Direction dir, IMapSite mapSite)
        {
            if (dir == Direction.East)
            {
                mEastSide = mapSite;
            }
            else if(dir == Direction.West)
            {
                mWestSide = mapSite;
            }
            else if (dir == Direction.South)
            {
                mSorthSide = mapSite;
            }
            else if(dir == Direction.North)
            {
                mNorthSide = mapSite;
            }
        }
        public virtual void Enter()
        {
            Console.WriteLine("Enter a room {0}.", mRoomNumber);
        }
    }
}
