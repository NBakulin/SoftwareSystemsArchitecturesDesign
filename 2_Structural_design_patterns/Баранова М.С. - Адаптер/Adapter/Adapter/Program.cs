using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundHole hole = new RoundHole(5);
            SquarePeg sp = new SquarePeg(2);
            SPAdapter spAdapter = new SPAdapter(sp.GetWidth(),sp);
            Console.WriteLine(hole.fits(spAdapter));
        }
    }
}
