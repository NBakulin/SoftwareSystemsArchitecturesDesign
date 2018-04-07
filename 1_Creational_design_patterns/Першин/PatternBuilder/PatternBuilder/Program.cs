using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternBuilder.Cars;

namespace PatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            // Директор получает объект конкретного строителя от клиента
            // (приложения). Приложение само знает какой строитель использовать,
            // чтобы получить нужный продукт.
            CarBuilder builder = new CarBuilder();
            director.constructSUV(builder);

            // Готовый продукт возвращает строитель, так как Директор чаще всего не
            // знает и не зависит от конкретных классов строителей и продуктов.
            Car car = builder.getResult();
            Console.WriteLine("Car built:\n" + car.getType());


            CarManualBuilder manualBuilder = new CarManualBuilder();

            // Директор может знать больше одного рецепта строительства.
            director.constructSUV(manualBuilder);
            Manual carManual = manualBuilder.getResult();
            Console.WriteLine("\nCar manual built:\n" + carManual.print());


            Console.Read();
        }
    }
}
