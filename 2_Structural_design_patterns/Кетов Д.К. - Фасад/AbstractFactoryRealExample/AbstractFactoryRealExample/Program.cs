using ReadWritersLibrary;
using System;
using System.IO;

namespace AbstractFactoryRealExample
{
    class Program
    {
        static ReadWritersLibrary.IReadWriter readWriter = new FileReadWriter("input.txt", "output.txt");
        
        // static IReadWriter readWriter = new ConsoleReadWriter();
        
            static void Main(string[] args)
        {
            
            string str = readWriter.ReadLine();
            readWriter.WriteLine("First ReadWriter's hello");
            readWriter.WriteLine(str +" wrote by second ReadWriter");
            var secondReadWriter = new FileReadWriter("input.txt", "output.txt");
            secondReadWriter.WriteLine("second ReadWriter's hello");
            readWriter.Clear();
            secondReadWriter.Clear();        
            
        }
    }
}
