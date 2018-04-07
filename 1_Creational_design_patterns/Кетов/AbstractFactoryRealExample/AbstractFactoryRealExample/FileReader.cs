using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample
{
    class FileReader:IReader
    {
        protected StreamReader sr;
        public String ReadLine()
        {
            return sr.ReadLine();
        }
        public FileReader(string filePath)
        {
            sr = new StreamReader(filePath);
        }
       public void Clear()
        {
            sr.Close();
        }
    }
}
