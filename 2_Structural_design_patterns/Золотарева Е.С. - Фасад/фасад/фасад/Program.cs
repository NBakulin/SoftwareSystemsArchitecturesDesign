using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace фасад
{
    class SubsystemA
    {
        public void A1()
        { }
    }
    class SubsystemB
    {
        public void B1()
        { }
    }
    class SubsystemC
    {
        public void C1()
        { }
    }

    class Facade
    {
        SubsystemA subsystemA;
        SubsystemB subsystemB;
        SubsystemC subsystemC;

        public  Facade(SubsystemA sa, SubsystemB sb, SubsystemC sc)
        {
            subsystemA = sa;
            subsystemB = sb;
            subsystemC = sc;
        }
        public void Operation1()
        {
            subsystemA.A1();
            subsystemB.B1();
            subsystemC.C1();
        }
        public void Operation2()
        {
            subsystemB.B1();
            subsystemC.C1();
        }
    }

    class Client
    {
        public void Main()
        {
            Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
            facade.Operation1();
            facade.Operation2();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);

            Console.Read();
        }
    }

    // текстовый редактор
    class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Написание кода");
        }
        public void Save()
        {
            Console.WriteLine("Сохранение кода");
        }
    }
    class Compiller
    {
        public void Compile()
        {
            Console.WriteLine("Компиляция приложения");
        }
    }
    class CLR
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение приложения");
        }
        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения");
        }
    }

    class VisualStudioFacade
    {
        TextEditor textEditor;
        Compiller compiller;
        CLR clr;
        public VisualStudioFacade(TextEditor te, Compiller compil, CLR clr)
        {
            this.textEditor = te;
            this.compiller = compil;
            this.clr = clr;
        }
        public void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            compiller.Compile();
            clr.Execute();
        }
        public void Stop()
        {
            clr.Finish();
        }
    }

    class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
