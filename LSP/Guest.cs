using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Guest : IFileRead
    {
        public void ReadFile() { Console.WriteLine(" Guest Read File"); }
    }
}
