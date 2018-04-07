using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileFactory
{
    abstract class Phone
    {
        protected static int screenDiag, batteryCap;
        protected static ConsoleColor colour;

        public int ScreenDiag
        {
            get { return screenDiag; }
            set { screenDiag = value; }
        }
        public ConsoleColor Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public int BatteryCap
        {
            get { return batteryCap; }
            set { batteryCap = value; }
        }

        public Phone(int sd, ConsoleColor cl, int bc)
        {
            screenDiag = sd;
            colour = cl;
            batteryCap = bc;
        }

        public abstract string Discription();
    }
}
