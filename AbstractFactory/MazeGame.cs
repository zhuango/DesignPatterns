﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MazeGame
    {
        public Maze CreateMase(MazeFactory mazeFactory)
        {
            Maze aMaze = mazeFactory.MakeMaze();
            Room r1 = mazeFactory.MakeRoom(1);
            Room r2 = mazeFactory.MakeRoom(2);
            Door theDoor = mazeFactory.MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, mazeFactory.MakeWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, mazeFactory.MakeWall());
            r1.SetSide(Direction.West, mazeFactory.MakeWall());
            r2.SetSide(Direction.North, mazeFactory.MakeWall());
            r2.SetSide(Direction.East, mazeFactory.MakeWall());
            r2.SetSide(Direction.South, mazeFactory.MakeWall());
            r2.SetSide(Direction.West, theDoor);
            return aMaze;
        }
    }
}
