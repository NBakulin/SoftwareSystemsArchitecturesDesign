using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWritersLibrary
{
   internal class FileReader:IReader
    {
        protected StreamReader sr;
        static public Dictionary<string, FileReader> FileReaders = new Dictionary<string, FileReader>();
        public String ReadLine()
        {
            return sr.ReadLine();
        }
        public FileReader(string filePath)
        {
            sr = new StreamReader(filePath);
            currentFilePath = String.Copy(filePath);
            FileReaders.Add(filePath, this);
        }
        bool isCleared = false;
        private string currentFilePath;
       public void Clear()
        {
            if (isCleared)
                return;
            sr.Close();
            FileReaders.Remove(currentFilePath);
            isCleared = true;
        }
        static public FileReader Create(string filePath)
        {
            if (FileReaders.ContainsKey(filePath))
                return FileReaders[filePath];
            else
                if (FileWriter.FileWriters.ContainsKey(filePath))
                throw new Exception("Impoosible to read from and write to the same file");
            else
                return new FileReader(filePath);
        }
    }
}
