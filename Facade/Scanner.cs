using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Facade
{
    public class Scanner
    {
        private FileStream mCodeFile;
        public Scanner(FileStream codeFile)
        {
            this.mCodeFile = codeFile;
        }

        virtual public Token Scan()
        {
            return null;
        }
    }
}
