using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileFactory
{
    class PhoneS : Phone
    {
        public PhoneS(int screenDiag, ConsoleColor colour, int batteryCap) : base (screenDiag, colour, batteryCap)
        {

        }

        public override string Discription()
        {
            return "Create phone: Screen - " + screenDiag.ToString() + ", Colour - " + colour.ToString() + ", Battery - " + batteryCap.ToString();
        }
    }
}
