using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SPAdapter:RoundPeg
    {
        SquarePeg peg;
        public SPAdapter(int radius,SquarePeg sp):base(radius)
        {
            peg = sp;
        }

        public int GetRadius()
        {
            return (int)Math.Sqrt(Math.Pow((peg.GetWidth() / 2), 2) * 2);
        }
    }
}
