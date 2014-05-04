using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.Builder;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame game = new MazeGame();
            MazePrototypeFactory protoTypeFactory = new MazePrototypeFactory(new Maze(), new Wall(), new Room(1), new Door());
            Maze maze = game.CreateMazeByAbstractFactory(protoTypeFactory);
            maze.RoomNo(1).Enter();

            MazeGame game2 = new MazeGame();
            MazePrototypeFactory protoTyprFactory2 = new MazePrototypeFactory(new Maze(), new WallWithBomb(), new RoomWithABomb(1), new Door());
            Maze maze2 = game.CreateMazeByAbstractFactory(protoTyprFactory2);
            maze2.RoomNo(1).Enter();
        }
    }
}
