using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternBuilder.Cars;

namespace PatternBuilder.components
{
    public class Engine
    {
        private double volume;
        private double mileage;
        private static bool started;

        public Engine(double volume, double mileage)
        {
            this.volume = volume;
            this.mileage = mileage;
        }

        public void on()
        {
            started = true;
        }

        public void off()
        {
            started = false;
        }

        public static bool isStarted()
        {
            return started;
        }

        public void go(double mileage)
        {
            if (started)
            {
                this.mileage += mileage;
            }
            else
            {
                Console.WriteLine("Cannot go(), you must start engine first!");
            }
        }

        public double getVolume()
        {
            return volume;
        }

        public double getMileage()
        {
            return mileage;
        }
    }

    public class GPSNavigator
    {
        private String route;

        public GPSNavigator()
        {
            this.route = "221b, Baker Street, London  to Scotland Yard, 8-10 Broadway, London";
        }

        public GPSNavigator(String manualRoute)
        {
            this.route = manualRoute;
        }

        public String getRoute()
        {
            return route;
        }
    }

    public enum Transmission
    {
        SINGLE_SPEED, MANUAL, AUTOMATIC, SEMI_AUTOMATIC
    }

    public class TripComputer
    {

        public void condition()
        {
            if (Engine.isStarted())
            {
                Console.WriteLine("Car is started");
            }
            else
            {
                Console.WriteLine("Car isn't started");
            }
        }

        public void fuelLevel()
        {
            Console.WriteLine("Level of fuel - " + Car.getFuel());
        }
    }
}
