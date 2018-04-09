using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample
{
    class FileWriter: IWriter
    {
        protected StreamWriter sw;

        public void WriteLine(string output)
        {
            Console.WriteLine("TRYINGTOWRITE");
            sw.WriteLine(output);

        }

        
        public FileWriter (string filePath)
        {
            Console.WriteLine("FILEWRITERCREATED");
            sw = new StreamWriter(filePath);
        }

        public void Clear()
        {
            sw.Close();
        }
      
    }
}
