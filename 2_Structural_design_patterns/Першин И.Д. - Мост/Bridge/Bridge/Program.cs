using System;
using Bridge.Device;
using Bridge.Remote;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDevice(new Tv());
            TestDevice(new Radio());
        }

        public static void TestDevice(IDevice device)
        {
            Console.WriteLine("Tests with basic remote.");
            BasicRemote basicRemote = new BasicRemote(device);
            basicRemote.Power();
            device.PrintStatus();
            
            Console.WriteLine("Tests with advanced remote.");
            AdvancedRemote advancedRemote = new AdvancedRemote(device);
            advancedRemote.Power();
            advancedRemote.Mute();
            device.PrintStatus();
        }
    }
}
