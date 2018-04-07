using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy1
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
        Library library = new Library();
        public void ReadBook()
        {
            library.GetBook();
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
