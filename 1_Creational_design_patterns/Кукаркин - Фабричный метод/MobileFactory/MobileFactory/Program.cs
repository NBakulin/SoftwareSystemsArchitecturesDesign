using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileFactory
{
    class Program
    {
        static void Main(string[] args)
        {            
            Creator[] creators = { new CreatorPhoneS(), new CreatorPhoneX() };
            
            foreach (Creator creator in creators)
            {
                Phone product = creator.Create();                
            }

            Console.Read();
        }
    }
}
