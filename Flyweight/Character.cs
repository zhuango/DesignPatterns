using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Character : Glyph
    {
        private char ch;
        public Character(char ch)
        {
            this.ch = ch;
        }

        public override void Draw(Window window, GlyphContext context)
        {
            base.Draw(window, context);
        }

    }
}
