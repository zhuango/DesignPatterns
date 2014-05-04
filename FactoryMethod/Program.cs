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
            Maze maze = game.CreateMazeByFactoyrMethod();
            maze.RoomNo(1).Enter();

            BombedMazeGame bomb = new BombedMazeGame();
            Maze bombMaze = bomb.CreateMazeByFactoyrMethod();
            bombMaze.RoomNo(1).Enter();
        }
    }
}
