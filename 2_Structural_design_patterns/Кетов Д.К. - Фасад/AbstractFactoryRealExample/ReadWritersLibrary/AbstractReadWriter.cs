using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWritersLibrary
{
     abstract class AbstractReadWriter : IReadWriter
    {
        abstract protected IReader Reader { get; }
        abstract protected IWriter Writer { get; } 
        
        public void Clear()
        {
            Reader.Clear();
            Writer.Clear();
        }

        public void Flush()
        {
            Writer.Flush();
        }

        public string ReadLine()
        {
            return Reader.ReadLine();
        }

        public void Write(string output)
        {
            Writer.Write(output);
        }

        public void WriteLine(string output)
        {
            Writer.WriteLine(output);
        }
    }
}
