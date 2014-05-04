using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class PasteCommand : Command
    {
        private Document mDocument;

        public PasteCommand(Document doc)
        {
            this.mDocument = doc;
        }
        public override void Execute()
        {
            this.mDocument.Paste();
        }
    }
}
