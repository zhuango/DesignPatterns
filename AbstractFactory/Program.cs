using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //change factory, change kind of maze.
            MazeFactory mazeFactory = new MazeFactory();
            MazeGame game = new MazeGame();
            Maze maze = game.CreateMase(mazeFactory);
            maze.RoomNo(1).Enter();

            EnchantedMazeFactory enchante = new EnchantedMazeFactory();
            Maze enchantedMaze = game.CreateMase(enchante);
            enchantedMaze.RoomNo(1).Enter();
        }
    }
}
