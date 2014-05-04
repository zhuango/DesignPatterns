using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTree
{
    public class BTreeNode
    {
        public ulong NumberKey;
        public List<Key> KeyList;
        public Boolean IsLeaf;
        private List<BTreeNode> children;
        public List<BTreeNode> Children
        {
            get
            {
                if (IsLeaf)
                {
                    return null;
                }
                return this.children;
            }
            set
            {
                this.children = value;
            }
        }
    }
}
