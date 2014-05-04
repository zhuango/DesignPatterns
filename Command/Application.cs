using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Application
    {
        private List<Document> documents;
        public Application()
        {
            documents = new List<Document>();
        }

        public void Add(Document document)
        {
            documents.Add(document);
        }
    }
}
