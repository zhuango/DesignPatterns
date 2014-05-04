using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = FileLogger.GetInstance();
            logger.Debug("Debug");
            logger.Error("Error");
            logger.Info("Info");
            logger.Warning("Warning");
        }
    }
}
