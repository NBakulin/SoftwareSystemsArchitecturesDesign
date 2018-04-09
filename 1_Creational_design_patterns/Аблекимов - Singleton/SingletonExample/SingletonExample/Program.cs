using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var al = new List<Singleton>();
            for (int i = 0; i < 10; i++)
            {
                Singleton singleton = Singleton.GetInstance;
                singleton.Counter++;
                al.Add(singleton);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(al[i].Counter);
            }
            Console.ReadLine();
        }
    }
}
