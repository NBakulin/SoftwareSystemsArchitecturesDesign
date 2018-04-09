using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileFactory
{
    class CreatorPhoneX : Creator
    {
        public override Phone Create()
        {
            int scr, bat, c, cam;
            bool parseResult = false;
            Console.WriteLine("Creating new PhoneX:");
            Console.WriteLine("Screen resolution?:");
            do
            {
                parseResult = Int32.TryParse(Console.ReadLine(), out scr);
                if (!parseResult)
                {
                    Console.WriteLine("Only digit!");
                }
            }
            while (!parseResult);
            parseResult = false;
            Console.WriteLine("Body colour (0 - black, 1 - white)?:");
            do
            {
                parseResult = Int32.TryParse(Console.ReadLine(), out c);
                if (!parseResult)
                {
                    Console.WriteLine("Only digit!");
                }
                else
                {
                    if ((c < 0) || (c > 1))
                    { Console.WriteLine("Only 0 or 1!"); parseResult = false; }
                }
            }
            while (!parseResult);
            parseResult = false;
            Console.WriteLine("Battery capacity?:");
            do
            {
                parseResult = Int32.TryParse(Console.ReadLine(), out bat);
                if (!parseResult)
                {
                    Console.WriteLine("Only digit!");
                }
            }
            while (!parseResult);
            parseResult = false;
            Console.WriteLine("Camera resolution?:");
            do
            {
                parseResult = Int32.TryParse(Console.ReadLine(), out cam);
                if (!parseResult)
                {
                    Console.WriteLine("Only digit!");
                }
            }
            while (!parseResult);
            if (c == 0)
            {
                PhoneX phone = new PhoneX(scr, ConsoleColor.Black, bat, cam);
                Console.WriteLine(phone.Discription());
                return phone;
            }
            else
            {
                PhoneX phone = new PhoneX(scr, ConsoleColor.White, bat, cam);
                Console.WriteLine(phone.Discription());
                return phone;
            }
        }
    }
}
