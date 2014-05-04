using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class GlyphContext
    {
        public GlyphContext() { }
        public void Next(int step = 1) { }
        public void Insert(int quantity = 1) { }
        public Font GetFont() { return null; }
        public void SetFont(Font font, int span = 1) { }

        private int _index;
        private BTree _font;
    }
}
