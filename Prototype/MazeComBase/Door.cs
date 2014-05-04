using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Door : IMapSite
    {
        private Room mRoom1;
        private Room mRoom2;
        private Boolean mIsOpen;

        public Door(Room room1 = null, Room room2 = null)
        {
            mRoom1 = room1;
            mRoom2 = room2;
        }

        public Door(Door door)
        {
            this.mRoom1 = door.mRoom1;
            this.mRoom2 = door.mRoom2;
            this.mIsOpen = door.mIsOpen;
        }
        public virtual void Enter()
        {
            this.mIsOpen = true;
            Console.WriteLine("Enter the door.");
        }
        public Room OtherSideFrom(Room room)
        {
            if (room == mRoom1)
            {
                return mRoom2;
            }

            if (room == mRoom2)
            {
                return mRoom2;
            }

            return null;
        }

        public virtual Door Clone()
        {
            return new Door(this);
        }
        public virtual void Initialize(Room room1, Room room2)
        {
            this.mRoom1 = room1;
            this.mRoom2 = room2;
        }
    }
}
