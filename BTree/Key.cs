using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTree
{
    public class Key
    {
        private ulong value;

        public Key()
        {
            value = 0;
        }
        public Key(ulong value)
        {
            this.value = value;
        }

        public ulong Value
        {
            set
            {
                this.value = value;
            }
        }
        public static Boolean operator >(Key a, Key b)
        {
            return a.value > b.value;
        }

        public static Boolean operator >=(Key a, Key b)
        {
            return a.value >= b.value;
        }

        public static Boolean operator <=(Key a, Key b)
        {
            return a.value <= b.value;
        }

        public static Boolean operator <(Key a, Key b)
        {
            return a.value < b.value;
        }

        public static Boolean operator ==(Key a, Key b)
        {
            return a.value == b.value;
        }
        public static Boolean operator !=(Key a, Key b)
        {
            return a.value != b.value;
        }

        public override bool Equals(object obj)
        {
            return this.value == (obj as Key).value;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
