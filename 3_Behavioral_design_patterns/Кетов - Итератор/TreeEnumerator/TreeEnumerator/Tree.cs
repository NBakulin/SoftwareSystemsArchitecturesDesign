using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeEnumerator
{
    class Tree <T> : IEnumerable where T : IComparable
    {
        private T meaning;
        public T Meaning
        {
            get
            {
                return meaning;
            }
            set
            {
                meaning = value;
            }
        }
        private Tree<T> left;
        public Tree<T> Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        private Tree<T> right;
        public Tree<T> Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }
        public Tree(T _meaning)
        {
            meaning = _meaning;
            left = null;
            right = null;
        }

        public void  Add(T _meaning)
        {
            if (_meaning.CompareTo(meaning) < 0)
                if (left == null)
                    left = new Tree<T>(_meaning);
                else
                    left.Add(_meaning);
            else
                if (right == null)
                    right = new Tree<T>(_meaning);
                else
                    right.Add(_meaning);
        }

        public IEnumerator GetEnumerator()
        {
            return new TreeEnumerator<T>(this);
        }

        public Tree()
        {

        }
    }
}
