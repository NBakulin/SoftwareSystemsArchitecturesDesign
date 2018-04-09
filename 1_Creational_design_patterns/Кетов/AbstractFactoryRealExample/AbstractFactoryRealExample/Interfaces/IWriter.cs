using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample
{
    interface IWriter
    {
        void WriteLine(string output);
        void Clear();
    }
}
