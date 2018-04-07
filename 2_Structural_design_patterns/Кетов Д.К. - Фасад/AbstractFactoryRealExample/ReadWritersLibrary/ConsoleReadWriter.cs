using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWritersLibrary
{
    public class ConsoleReadWriter:IReadWriter
    {
        private ConsoleReader reader = new ConsoleReader();
       
      
        private ConsoleWriter writer = new ConsoleWriter();

        public void Clear()
        {
            
        }

        public void Flush()
        {
            writer.Flush();
        }

        public string ReadLine()
        {
            return reader.ReadLine();
        }
        public void Write(string input)
        {
            writer.Write(input);
        }


        public void WriteLine(string output)
        {
            writer.WriteLine(output);
        }
    }
}
