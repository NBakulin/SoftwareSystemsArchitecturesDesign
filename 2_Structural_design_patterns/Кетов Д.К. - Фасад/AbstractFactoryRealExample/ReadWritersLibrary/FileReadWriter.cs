using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWritersLibrary
{
    public class FileReadWriter : IReadWriter
    {
        private IReader reader;
        
        private FileWriter writer;
        
        public FileReadWriter(string readFilePath, string writeFilePath)
        {
            reader = FileReader.Create(readFilePath);
            writer = FileWriter.Create(writeFilePath);
        }
        public void Write(string input)
        {
            writer.Write(input);
        }

        public void Clear()
        {
            reader.Clear();
            writer.Clear();
        }

        public void Flush()
        {
            writer.Clear();
        }

        public string ReadLine()
        {
            return reader.ReadLine();
        }

        public void WriteLine(string output)
        {
            writer.WriteLine(output);
        }
    }
}
