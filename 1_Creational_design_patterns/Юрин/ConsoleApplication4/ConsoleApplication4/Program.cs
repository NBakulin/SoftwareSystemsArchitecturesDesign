using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Typography t1 = new BookTypography("Книжная типография");
            Product book1 = t1.Create();

            t1 = new NewspaperTypography("Газетная типография");
            Product newspaper1 = t1.Create();

            Console.ReadLine();
        }
    }
    // абстрактный класс типографии
    abstract class Typography
    {
        public string Name { get; set; }

        public Typography(string n)
        {
            Name = n;
        }

        // фабричный метод
        abstract public Product Create();
    }

    // Печатает книгу
    class BookTypography : Typography
    {
        public BookTypography(string n) : base(n)
        { }

        public override Product Create()
        {
            return new Book();
        }
    }

    // Печатает газету
    class NewspaperTypography : Typography
    {
        public NewspaperTypography(string n) : base(n)
        { }

        public override Product Create()
        {
            return new Newspaper();
        }
    }

    abstract class Product
    { }

    class Book : Product
    {
        public Book()
        {
            Console.WriteLine("Начало процесса печати книги...");
            Console.WriteLine("1. Верстаем книгу...");
            Console.WriteLine("2. Создаём дизайн обложки...");
            Console.WriteLine("3. Печатаем страницы...");
            Console.WriteLine("4. Создаём переплёт...");
            Console.WriteLine("5. Книга готова!");
            Console.WriteLine();
        }
    }
    class Newspaper : Product
    {
        public Newspaper()
        {
            Console.WriteLine("Начало процесса печати газеты...");
            Console.WriteLine("1. Верстаем развороты газеты...");
            Console.WriteLine("2. Нанесение основных цветов на бумагу...");
            Console.WriteLine("3. Проводим просушку напечатанных страниц...");
            Console.WriteLine("4. Скрепляем развороты...");
            Console.WriteLine("5. Газета готова!");
        }
    }
}
