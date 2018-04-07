using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class EventManager
    {
        private List<IListener> listeners = new List<IListener>();
        public void Subscribe(IListener lis)
        {
            listeners.Add(lis);
        }
        public void Unsubscribe (IListener lis)
        {
            listeners.Remove(lis);
        }
        public void Notify(string message)
        {
            foreach (var lis in listeners)
            {
                lis.Update(message);
            }
        }

    }
}
