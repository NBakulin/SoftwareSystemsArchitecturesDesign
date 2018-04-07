using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample
{
    class ConsoleReadWriter:IReadWriter
    {
        private ConsoleReader reader = new ConsoleReader();
        protected override IReader Reader
      {
           get
            {
                return reader;
            }
        }
      
        private ConsoleWriter writer = new ConsoleWriter();
        protected override IWriter Writer
        {
            get
            {
                return writer;
            }
        }
        public override void Clear()
        {

        }
        
    }
}
