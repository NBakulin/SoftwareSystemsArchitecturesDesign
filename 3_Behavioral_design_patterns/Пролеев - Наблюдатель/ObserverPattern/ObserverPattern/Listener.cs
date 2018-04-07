using System;

namespace ObserverPattern
{
    public interface IListener
    {
        void Update(string message);
        string Name { get; }
    }


    public class Listener_1 : IListener
    {
        private string name;
        public Listener_1(string _name)
        {
            name = _name;
        }
        public string Name => name;

        public void Update(string message)
        {
            Console.WriteLine($"{Name} получил сообщение: {message}");
        }

        
    }

    public class Listener_2 : IListener
    {
        private string name;
        public Listener_2(string _name)
        {
            name = _name;
        }
        public string Name => name;
        public void Update(string message)
        {
            Console.WriteLine($"{Name} получил сообщение: {message}");
        }
    }
}