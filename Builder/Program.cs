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
            MazeBuilder builder = new StandardMazeBuilder();
            MazeGame game = new MazeGame();
            Maze maze = game.CreateMaseByBuilder(builder);

            CountingMazeBuilder CountingBuilder = new CountingMazeBuilder();
            game.CreateMaseByBuilder(CountingBuilder);
            int roomCount;
            int doorCount;
            CountingBuilder.GetCounts(out roomCount, out doorCount);
            Console.WriteLine("RoomCount: {0}\nDoorCount: {1}", roomCount, doorCount);
        }
    }
}
