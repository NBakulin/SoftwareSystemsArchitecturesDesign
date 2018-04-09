using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> root = new Tree<int>(5);
            root.Add(8);
            root.Add(4);
            root.Add(22);
            root.Add(10);
            root.Add(12);
            root.Add(18);
            TreeEnumerator<int> enumerator = new TreeEnumerator<int>(root);
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Meaning);
            }
            enumerator.Reset();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Meaning - 1);
            }
            foreach(Tree<int> a in root)
            {
                Console.WriteLine(a.Meaning);
            }
        }
    }
}
