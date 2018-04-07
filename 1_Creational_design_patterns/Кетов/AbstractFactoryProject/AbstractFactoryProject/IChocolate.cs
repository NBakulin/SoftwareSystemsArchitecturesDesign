using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    interface IChocolate: IProduct
    {
        double Size
        {
            get;
        }
        string Type
        {
            get;
        }
    }
}
