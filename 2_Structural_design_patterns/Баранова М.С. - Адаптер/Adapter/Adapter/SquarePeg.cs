using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SquarePeg
    {
        protected int _width;

        public SquarePeg(int width)
        {
            _width = width;
        }

        public int GetWidth()
        {
            return _width;
        }
    }
}
