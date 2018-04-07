using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class MediatorExample
    {
        public abstract class AbstractChatroom
        {
            public abstract void Register(Participant participant);
            public abstract void Send(string from, string to, string message);
            public abstract void SendAll(string from, string message);
        }

        public class Chatroom : AbstractChatroom
        {
            private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

            public override void Register(Participant participant)
            {
                if (!_participants.ContainsValue(participant))
                {
                    _participants[participant.Name] = participant;
                }

                participant.Chatroom = this;
            }

            public override void Send(string from, string to, string message)
            {
                Participant participant = _participants[to];

                if (participant != null)
                {
                    participant.Receive(from, message);
                }
            }

            public override void SendAll(string from, string message)
            {

                foreach (KeyValuePair<string, Participant> entry in _participants)
                {
                    this.Send(from, entry.Key, message);
                }
            }
        }

        public class Participant
        {
            private Chatroom _chatroom;
            private string _name;

            public Participant(string name)
            {
                this._name = name;
            }

            public string Name
            {
                get { return _name; }
            }

            public Chatroom Chatroom
            {
                set { _chatroom = value; }
                get { return _chatroom; }
            }

            public void Send(string to, string message)
            {
                _chatroom.Send(_name, to, message);
            }

            public void SendAll(string message)
            {
                _chatroom.SendAll(_name, message);
            }

            public virtual void Receive(string from, string message)
            {
                Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
            }
        }

        public class Men : Participant

        {
            public Men(string name)
              : base(name)
            {
            }

            public override void Receive(string from, string message)
            {
                Console.Write("Мужчине: ");
                base.Receive(from, message);
            }
        }

        public class Women : Participant
        {
            public Women(string name)
                : base(name)
            {               
            }

            public override void Receive(string from, string message)
            {
                Console.Write("Женщине: ");
                base.Receive(from, message);
            }
        }
    }
}
