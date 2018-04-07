using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileFactory
{
    class CreatorPhoneS : Creator
    {
        public override Phone Create()
        {
            int scr, bat, c;
            bool parseResult = false;
            Console.WriteLine("Creating new PhoneS:");
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

            if (c == 0)
            {
                PhoneS phone = new PhoneS(scr, ConsoleColor.Black, bat);
                Console.WriteLine(phone.Discription());
                return phone;
            }
            else
            {
                PhoneS phone = new PhoneS(scr, ConsoleColor.White, bat);
                Console.WriteLine(phone.Discription());
                return phone;
            }
        }
    }
}
