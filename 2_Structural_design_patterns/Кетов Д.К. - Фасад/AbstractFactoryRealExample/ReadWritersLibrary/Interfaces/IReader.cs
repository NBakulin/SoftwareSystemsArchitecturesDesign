using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWritersLibrary
{
    internal interface IReader
    {
        string ReadLine();
        void Clear();
    }
    
}
