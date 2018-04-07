using System;
using System.Collections;
 
namespace Program
{
    class MainApp
    {
        static void Main()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            for (int j = 0; j < 20; j++)
            {
                a[j] = "Item " + j.ToString();
            }

            ConcreteIterator i = new ConcreteIterator(a);
            Console.WriteLine("Iterating over collection with 1st iterator:");

            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            ConcreteIterator2 k = new ConcreteIterator2(a);
            Console.WriteLine("Iterating over collection with 2nd iterator:");

            object item2 = k.End();
            k.setCurrent();
            while (k.IsStart())
            {
                Console.WriteLine(item2);
                item2 = k.Prev();
            }

            Console.ReadKey();
        }
    }

    #region Aggregate
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
        public abstract int Count { get; protected set; }
        public abstract object this[int index] { get; set; }
    }
    #endregion Aggregate  

    #region ConcreteAggregate
    class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public override int Count
        {
            get { return _items.Count; }
            protected set { }
        }

        // Indexer
        public override object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
    #endregion ConcreteAggregate

    #region Iterator
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
    #endregion Iterator

    #region ConcreteIterator
    class ConcreteIterator : Iterator
    {
        private readonly Aggregate _aggregate;
        private int _current;

        public ConcreteIterator(Aggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;

            _current++;

            if (_current < _aggregate.Count)
            {
                ret = _aggregate[_current];
            }

            return ret;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
    #endregion ConcreteIterator

    #region ConcreteIterator2
    class ConcreteIterator2 : Iterator
    {
        private readonly Aggregate _aggregate;
        private int _current;

        public ConcreteIterator2(Aggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public object End()
        {
            return _aggregate[_aggregate.Count-1];
        }

        public override object Next()
        {
            object ret = null;

            _current++;

            if (_current < _aggregate.Count)
            {
                ret = _aggregate[_current];
            }

            return ret;
        }

        public object Prev()
        {
            object ret = null;

            _current--;

            if (_current >= 0)
            {
                ret = _aggregate[_current];
            }

            return ret;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

        public bool IsStart()
        {
               return _current >= 0;
        }

        public void setCurrent()
        {
            this._current= _aggregate.Count - 1;
        }
    }
    #endregion ConcreteIterator2
}

