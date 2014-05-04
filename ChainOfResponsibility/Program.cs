using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application(Topic.APPLICATION_TOPIC);
            Dialog dialog = new Dialog(app, Topic.PRINT_TOPIC);

            Button button = new Button(dialog, Topic.PAPER_ORIENTATION_TOPIC);
            button.HandleHelp();

            button.SetHandler(new Dialog(app, Topic.Unknow), Topic.Unknow);
            button.HandleHelp();
        }
    }
}
