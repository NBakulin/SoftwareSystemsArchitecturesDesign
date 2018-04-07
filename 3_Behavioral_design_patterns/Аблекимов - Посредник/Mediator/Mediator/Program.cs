using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {

            MediatorExample.Chatroom chatroom = new MediatorExample.Chatroom();


            MediatorExample.Participant Dmitrij = new MediatorExample.Men("Дмитрий");
            MediatorExample.Participant Nastya = new MediatorExample.Women("Анастасия");
            MediatorExample.Participant Pavel = new MediatorExample.Men("Павел");
            MediatorExample.Participant Anna = new MediatorExample.Women("Анна");
            MediatorExample.Participant Elizaveta = new MediatorExample.Women("Елизавета");

            chatroom.Register(Dmitrij);
            chatroom.Register(Nastya);
            chatroom.Register(Pavel);
            chatroom.Register(Anna);
            chatroom.Register(Elizaveta);


            //Dmitrij.Send("Анастасия", "Привет!");
            //Nastya.Send("Дмитрий", "И тебе привет!");
            //Pavel.Send("Анна", "Я - Павел :)");
            //Pavel.Send("Елизавета", "Я - не Павел :(");
            //Anna.Send("Павел", "Бывает");
            //Elizaveta.Send("Анна", "123тест");

            Dmitrij.SendAll("Здравствуйте, ребята!");
            Nastya.Send("Дмитрий", "Привет!");

            Console.ReadKey();
        }
    }
}
