using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWritersLibrary
{
   internal class ConsoleWriter:IWriter
    {
        public void Clear()
        {

        }
        public void Flush()
        {
           
        }
        public void Write(string output)
        {
            Console.Write(output);
        }
        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }
    }
}
