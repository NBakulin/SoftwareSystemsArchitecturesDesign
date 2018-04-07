using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy2
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            reader.ReadEbook();
            //reader.ReadBook();
            Console.ReadLine();
        }
    }

    class Reader
    {
        Lazy<Library> library = new Lazy<Library>();
        public void ReadBook()
        {
            library.Value.GetBook();
            Console.WriteLine("Читаем бумажную книгу");
        }

        public void ReadEbook()
        {
            Console.WriteLine("Читаем книгу на компьютере");
        }
    }

    class Library
    {
        public void GetBook()
        {
            Console.WriteLine("Выдаем книгу читателю");
        }
    }
}
