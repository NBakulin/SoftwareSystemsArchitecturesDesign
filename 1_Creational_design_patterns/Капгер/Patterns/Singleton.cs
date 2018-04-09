using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public sealed class Singleton
    {
        public static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance
        {
            get { return instance.Value; }
        }

        private Singleton() { }

        public void Do()
        {
            //do
        }

        public DateTime Now()
        {
            return DateTime.Now;
        }

    }
}
