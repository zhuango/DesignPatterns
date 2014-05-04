using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class MazeBuilder
    {
        public virtual void BuildMaze() { }
        public virtual void BuildRoom(int roomNumber){}
        public virtual void BuildDoor(int roomFrom, int roomTo) { }

        public virtual Maze GetMaze() { return null; }

        protected MazeBuilder() { }

    }
}
