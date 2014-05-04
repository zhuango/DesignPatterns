using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Document
    {
        private String documentName;
        public Document(String documentName)
        {
            this.documentName = documentName;
        }

        public void Open()
        {
            Console.WriteLine("{0} is Opened.", documentName);
        }

        public void Paste()
        {
            Console.WriteLine("{0} is pasting.", documentName);
        }
    }
}
