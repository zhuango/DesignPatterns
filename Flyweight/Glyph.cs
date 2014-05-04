using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Glyph
    {
        public virtual void Draw(Window window, GlyphContext context){}
        public virtual void SetFont(Font font, GlyphContext context){}
        public virtual Font GetFont(GlyphContext context) { return null; }
        public virtual void First(GlyphContext context) { }
        public virtual void Next(GlyphContext context) { }
        public virtual Boolean IsDone(GlyphContext context) { return true; }
        public virtual Glyph Current(GlyphContext context) { return null; }

        public virtual void Insert(Glyph glyph, GlyphContext context) { }
        public virtual void Remove(GlyphContext context) { }

        protected Glyph();
    }
}
