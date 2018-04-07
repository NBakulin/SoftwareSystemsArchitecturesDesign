using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object Padlock = new object();
        public int Counter;

        private Singleton()
        {
            Counter = 0;
        }

        public static Singleton GetInstance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ?? (_instance = new Singleton());
                }
            }
        }
    }
}
