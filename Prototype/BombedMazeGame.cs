using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BombedMazeGame : MazeGame
    {
        public BombedMazeGame() { }

        public override Wall MakeWall()
        {
            return new WallWithBomb();
        }

        public override Room MakeRoom(int n)
        {
            return new RoomWithABomb(n);
        }
    }
}
