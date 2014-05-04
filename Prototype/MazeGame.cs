using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.Builder;

namespace DesignPatterns
{
    public class MazeGame
    {
        #region Factory Methods
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }
        public virtual Room MakeRoom(int n)
        {
            return new Room(n);
        }
        public virtual Wall MakeWall()
        {
            return new Wall();
        }
        public virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
        #endregion

        public Maze CreateMazeByFactoyrMethod()
        {
            Maze aMaze = MakeMaze();

            Room r1 = MakeRoom(1);
            Room r2 = MakeRoom(2);

            Door theDoor = MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.East, MakeWall());
            r1.SetSide(Direction.North, MakeWall());
            r1.SetSide(Direction.South, MakeWall());
            r1.SetSide(Direction.West, MakeWall());

            r2.SetSide(Direction.East, MakeWall());
            r2.SetSide(Direction.North, MakeWall());
            r2.SetSide(Direction.South, MakeWall());
            r2.SetSide(Direction.West, MakeWall());

            return aMaze;
        }

        public Maze CreateMazeByAbstractFactory(MazeFactory mazeFactory)
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

        public Maze CreateMazeByBuilder(MazeBuilder mazeBuilder)
        {
            mazeBuilder.BuildMaze();
            mazeBuilder.BuildRoom(1);
            mazeBuilder.BuildRoom(2);
            mazeBuilder.BuildRoom(3);

            mazeBuilder.BuildDoor(1, 2);

            return mazeBuilder.GetMaze();
        }

    }
}
