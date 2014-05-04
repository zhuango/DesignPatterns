using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Maze
    {
        private List<Room> mRooms;
        public Maze() 
        {
            mRooms = new List<Room>();
        }
        public void AddRoom(Room room)
        {
            mRooms.Add(room);
        }

        public Room RoomNo(int roomNumber)
        {
            foreach (Room room in mRooms)
            {
                if (room.RoomNumber == roomNumber)
                {
                    return room;
                }
            }
            return null;
        }
    }
}
