using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample
{
    class FileReadWriter : IReadWriter
    {
        protected IReader reader;
        protected override IReader Reader
        {
            get
            {
                return reader;
            }
        }
        public override void Clear()
        {
            reader.Clear();
                writer.Clear();
        }
        protected FileWriter writer;
        protected override IWriter Writer
        {
            get
            {
                return writer;
            }
        }
        public FileReadWriter(string readFilePath, string writeFilePath)
        {
            reader = new FileReader(readFilePath);
            writer = new FileWriter(writeFilePath);
        }
       
    }
}
