using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class AccessDataFile
    {
        public string Path { get; set; }

        public virtual void ReadFile() { Console.WriteLine("Read File"); }
        public virtual void WriteFile() { Console.WriteLine("Write File"); }
    }
}
