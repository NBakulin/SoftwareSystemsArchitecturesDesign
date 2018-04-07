using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeEnumerator
{
    class TreeEnumerator<T> : IEnumerator where T : IComparable
    {   public Tree<T> Current
        {
            get
            {
                return enumerator.Current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return enumerator.Current;
            }
        }

        private List<Tree<T>> trees = new List<Tree<T>>();
        private IEnumerator<Tree<T>> enumerator;
    
        public bool MoveNext()
        {
            return enumerator.MoveNext();
        }

        public void Reset()
        {
            enumerator.Reset();
        }

        private void GetFromTree(Tree<T> root)
        {
            if (root.Left != null)
                GetFromTree(root.Left);
            trees.Add(root);
            if (root.Right != null)
                GetFromTree(root.Right);
        }
        public TreeEnumerator(Tree<T> root)
        {
            GetFromTree(root);
            enumerator = trees.GetEnumerator(); 
        }
        
    }
}
