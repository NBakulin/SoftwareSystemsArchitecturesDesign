using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWritersLibrary
{
    internal class FileWriter: IWriter
    {
        protected StreamWriter sw;
        private string currentFilePath;
        static public Dictionary<string, FileWriter> FileWriters = new Dictionary<string, FileWriter>();
        public void WriteLine(string output)
        {
            
            sw.WriteLine(output);
            Console.WriteLine("ITRY");

        }
        public void Flush()
        {
            sw.Flush();
        }
        public void Write(string output)
        {
            sw.Write(output);
        }

        private bool isCleared = false;
        public FileWriter ( string filePath)
        {
            sw = new StreamWriter(filePath);
            FileWriters.Add(filePath, this);
            currentFilePath = String.Copy(filePath);
        }

        public void Clear()
        {
            if (isCleared)
            {

            }
            else
            {
                
                sw.Close();
                FileWriters.Remove(currentFilePath);
                isCleared = true
                    ;
            }
        }
        static public FileWriter Create(string filePath)
        {
            if (FileWriters.ContainsKey(filePath))
                return FileWriters[filePath];
            else
                if (FileReader.FileReaders.ContainsKey(filePath))
                    throw new Exception("Impoosible to read from and write to the same file");
                else
                    return new FileWriter(filePath);
        }
    }
}
