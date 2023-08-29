using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class AdminFileUser : IFileRead, IFileWrite
    {
        public void ReadFile() { Console.WriteLine("Admin Read File"); }
        public void WriteFile() { Console.WriteLine("Admin Write File"); }
    }
}
