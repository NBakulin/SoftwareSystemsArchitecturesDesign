using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    interface IDrink: IProduct
    {
        double Size
        {
            get;
        }
        
    }
}
