using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Существуют различные легковые машины, которые используют разные источники энергии: 
 * электричество, бензин, газ и так далее. 
 * Есть гибридные автомобили. 
 * В целом они похожи и отличаются преимущественно видом источника энергии. 
 * Не говоря уже о том, что мы можем изменить применяемый источник энергии, модифицировав автомобиль.
 * */
namespace Паттерн_Стратегия
{
    class Program
    {
        static void Main(string[] args)
        {
            //Клиент вызывает в Контексте определённую Стратегию
            Car auto = new Car(4, "Volvo", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();

            Console.ReadLine();
        }
    }
    interface IMovable//общий интерфейс стратегий
    {
        void Move();
    }

    class PetrolMove : IMovable//Стратегия 1
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }

    class ElectricMove : IMovable//Стратегия 2
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }
    class Car// Кнтекст
    {
        protected int passengers; // кол-во пассажиров
        protected string model; // модель автомобиля

        public Car(int num, string model, IMovable mov)
        {
            this.passengers = num;
            this.model = model;
            Movable = mov;
        }
        //поле для хранения ссылки на текущий объект-стратегию
        public IMovable Movable { private get; set; }
        public void Move()
        {
            Movable.Move();//метод для изменения стратегии
        }
    }
}
