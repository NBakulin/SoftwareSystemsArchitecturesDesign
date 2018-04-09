using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class RoundPeg
    {
        int _radius;
        
        public RoundPeg(int radius)
        {
            _radius = radius;
        }

        public int GetRadius()
        {
            return _radius;
        }
    }

    public class RoundHole
    {
        int _radius;

        public RoundHole(int radius)
        {
            _radius = radius;
        }
        public bool fits(RoundPeg peg)
        {
            return this._radius >= peg.GetRadius();
        }
    }
}
