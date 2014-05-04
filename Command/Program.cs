using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("doc1");
            Document document2 = new Document("doc2");
            Application app = new Application();
            app.Add(document);
            app.Add(document2);

            Command com = new OpenCommand(app);
            com.Execute();

            Command com2 = new PasteCommand(document2);
            com2.Execute();

            MacroCommand coms = new MacroCommand();
            coms.Add(com);
            coms.Add(com2);
            coms.Execute();
        }
    }
}
