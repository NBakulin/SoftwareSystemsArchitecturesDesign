using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    interface IProduct
    {
        ulong Cost
        {
            get; 
        }
        ulong Price
        {
            get;
        }
        string Name
        {
            get; 
        }
        void Print();
    }
}
