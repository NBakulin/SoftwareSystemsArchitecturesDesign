using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFactory.GangOfFour.Abstract.Structural
{
    class MainApp
    {

        public static void Main()
        {
            AbstractFactory USAfactory = new USAFactory("smartphone", "console", "PC");
            Client client1 = new Client(USAfactory);

            AbstractFactory Chinafactory = new ChinaFactory("smartphone", "console", "PC");
            Client client2 = new Client(Chinafactory);

            Console.ReadKey();
        }
    }

    #region AbstractFactory
    abstract class AbstractFactory
    {
        public abstract AbstractSmartphone CreateSmartphone();
        public abstract AbstractConsolka CreateConsolka();
        public abstract AbstractPC CreatePC();
    }
    #endregion AbstractFactory

    #region USAFactory
    class USAFactory : AbstractFactory
    {
        private string _smartphoneModel;
        private string _consoleModel;
        private string _PCModel;

        public USAFactory(string smartphoneModel, string consoleModel, string pcModel)
        {
            _smartphoneModel = smartphoneModel;
            _consoleModel = consoleModel;
            _PCModel = pcModel;
        }

        public override AbstractSmartphone CreateSmartphone()
        {
            return new USASmartphone(_smartphoneModel);
        }
        public override AbstractConsolka CreateConsolka()
        {
            return new USAConsolka(_consoleModel);
        }
        public override AbstractPC CreatePC()
        {
            return new USAPC(_PCModel);
        }
    }
    #endregion USAFactory

    #region ChineeseFactory
    // Китайская фабрика
    class ChinaFactory : AbstractFactory
    {
        private string _smartphoneModel;
        private string _consoleModel;
        private string _PCModel;

        public ChinaFactory(string smartphoneModel, string consoleModel, string pcModel)
        {
            _smartphoneModel = smartphoneModel;
            _consoleModel = consoleModel;
            _PCModel = pcModel;
        }

        public override AbstractSmartphone CreateSmartphone()
        {
            return new ChinaSmartphone(_smartphoneModel);
        }
        public override AbstractConsolka CreateConsolka()
        {
            return new ChinaSConsolka(_consoleModel);
        }
        public override AbstractPC CreatePC()
        {
            return new ChinaPC(_PCModel);
        }
    }
    #endregion ChineeseFactory

    #region AbstractProducts
    abstract class AbstractPC
    {
    }
 
    abstract class AbstractSmartphone
    {
    }

    abstract class AbstractConsolka
    {

    }
    #endregion AbstractProducts

    #region USAProducts
    class USASmartphone : AbstractSmartphone
    {
        private string _smartphoneModel;

        public USASmartphone(string smartphoneModel)
        {
            _smartphoneModel = "USA"+smartphoneModel;
        }
    }

    class USAPC : AbstractPC
    {
        private string _PCModel;

        public USAPC(string pcModel)
        {
            _PCModel = "USA" + pcModel;
        }

        //public override void Interact(AbstractProductA a)
        //{
        //    Console.WriteLine(this.GetType().Name +
        //      " interacts with " + a.GetType().Name);
        //}
    }

    class USAConsolka : AbstractConsolka
    {
        private string _consoleModel;

        public USAConsolka(string consoleModel)
        {
            _consoleModel = "USA" + consoleModel;
        }
    }
    #endregion USAProducts

    #region ChinaProducts
    class ChinaSmartphone : AbstractSmartphone
    {
        private string _smartphoneModel;

        public ChinaSmartphone(string smartphoneModel)
        {
            _smartphoneModel = "China" + smartphoneModel;
        }
    }

    class ChinaPC : AbstractPC
    {
        private string _PCModel;

        public ChinaPC(string pcModel)
        {
            _PCModel = "China" + pcModel;
        }
    }

    class ChinaSConsolka : AbstractConsolka
    {
        private string _consoleModel;

        public ChinaSConsolka(string consoleModel)
        {
            _consoleModel = "China" + consoleModel;
        }
    }
    #endregion ChinaProducts

    /// Класс клиента, в котором происходит взаимодействие между объектами
    class Client
    {
        private AbstractPC _abstractProductPC;
        private AbstractSmartphone _abstractProductSmartphone;
        private AbstractConsolka _abstractProductConsolka;

        // Конструктор
        public Client(AbstractFactory factory)
        {
            _abstractProductPC = factory.CreatePC();
            _abstractProductSmartphone = factory.CreateSmartphone();
            _abstractProductConsolka = factory.CreateConsolka();
        }

    }
}

