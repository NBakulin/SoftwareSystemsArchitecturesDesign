using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем слушателей.
            List<IListener> listeners = new List<IListener>
            {
                new Listener_1("Первый слушатель"), new Listener_1("Второй слушатель"), new Listener_2("Третий слушатель")
            };

            //Создаем менеджера и подписываеи трех слушателей
            EventManager manager1 = new EventManager();
            manager1.Subscribe(listeners[0]);
            manager1.Subscribe(listeners[1]);
            manager1.Subscribe(listeners[2]);


            //Создаем еще одного менеджера и подписываем двух слушателей
            EventManager manager2 = new EventManager();
            manager2.Subscribe(listeners[0]);
            manager2.Subscribe(listeners[1]);

            //Создаем еще одного менеджера и подписываем одного слушателя
            EventManager manager3 = new EventManager();
            manager3.Subscribe(listeners[2]);

            //Выпускаем сообщение - его получат 3 слушателя.
            manager1.Notify("Привет от менеджера 1");
            Console.WriteLine();

            //Выпускаем сообщение - его получат 2 слушателя
            manager2.Notify("Привет от менеджера 2");
            Console.WriteLine();

            //Выпускаем сообщение - его получит 1 слушатель
            manager3.Notify("Привет от менеджера 3");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
