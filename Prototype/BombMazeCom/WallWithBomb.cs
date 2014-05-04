using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class WallWithBomb : Wall
    {
        private Boolean mIsBomb;

        public WallWithBomb() { }
        public WallWithBomb(WallWithBomb bombWall)
        {
            this.mIsBomb = bombWall.mIsBomb;
        }
        public override void Enter()
        {
            this.mIsBomb = true;
            Console.WriteLine("Wall bomb.");
        }   
    }
}
