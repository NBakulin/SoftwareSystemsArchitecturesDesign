using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample
{
    class Program
    {
        static IReadWriter readWriter = new FileReadWriter("input.txt", "output.txt");
     

        static void Main(string[] args)
        {
            string str = readWriter.ReadLine();
            readWriter.WriteLine("Hi");
            readWriter.WriteLine(str);
            readWriter.Clear();
            

        }
    }
}
