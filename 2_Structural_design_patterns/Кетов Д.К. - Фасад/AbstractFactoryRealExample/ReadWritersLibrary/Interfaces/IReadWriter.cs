using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWritersLibrary
{
    public  interface IReadWriter
    {
        

         string ReadLine();
        void Clear();
        void WriteLine(string output);
        void Write(string output);

        void Flush();
    }
}
