using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class OpenCommand : Command
    {
        private Application application;
        private String response;

        public OpenCommand(Application app)
        {
            this.application = app;
        }

        protected String AskUser()
        {
            return "Zhuang Liu";
        }
        public override void Execute()
        {
            String name = AskUser();
            if (name != null)
            {
                Document document = new Document(name);
                application.Add(document);
                document.Open();
            }
        }
    }
}
