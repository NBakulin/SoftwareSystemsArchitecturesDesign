using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWritersLibrary
{
    internal interface IWriter
    {
        void WriteLine(string output);
        void Flush();
        void Clear();
        void Write(string output);
    }
}
