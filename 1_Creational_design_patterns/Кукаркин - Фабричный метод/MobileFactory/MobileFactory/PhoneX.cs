using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileFactory
{
    class PhoneX : Phone
    {
        protected int cameraRes;

        public int CameraRes
        {
            get { return cameraRes; }
            set { cameraRes = value; }
        }

        public PhoneX(int screenDiag, ConsoleColor colour, int batteryCap, int cr) : base (screenDiag, colour, batteryCap)
        {
            cameraRes = cr;
        }

        public override string Discription()
        {
            return "Create phone: Screen - " + screenDiag.ToString() + ", Colour - " + colour.ToString() + ", Battery - " + batteryCap.ToString() + ", Camera - " + cameraRes.ToString() + "mp";
        }
    }
}
