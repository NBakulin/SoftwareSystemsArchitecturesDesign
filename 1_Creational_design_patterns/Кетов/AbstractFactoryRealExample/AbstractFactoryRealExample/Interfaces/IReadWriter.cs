using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample
{
    abstract class IReadWriter
    {

        abstract protected IReader Reader
        {
            get;
        }
        public string ReadLine()
        {
            return Reader.ReadLine();
        }
        abstract public void Clear();
        abstract protected IWriter Writer
        {
            get;
        }
        public void WriteLine(string output)
        {
            Writer.WriteLine(output);
        }
    }
}
