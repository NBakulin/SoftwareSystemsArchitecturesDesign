using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternBuilder.components;

namespace PatternBuilder.Cars
{
    public class Car
    {
        private CarType type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gpsNavigator;
        private static double fuel = 0;

        public Car(CarType type, int seats, Engine engine, Transmission transmission,
                   TripComputer tripComputer, GPSNavigator gpsNavigator)
        {
            this.type = type;
            this.seats = seats;
            this.engine = engine;
            this.transmission = transmission;
            this.tripComputer = tripComputer;
            this.gpsNavigator = gpsNavigator;
        }

        public void setFuel(double _fuel)
        {
            fuel = _fuel;
        }

        public CarType getType()
        {
            return type;
        }

        public int getSeats()
        {
            return seats;
        }

        public Engine getEngine()
        {
            return engine;
        }

        public Transmission getTransmission()
        {
            return transmission;
        }

        public TripComputer getTripComputer()
        {
            return tripComputer;
        }

        public GPSNavigator getGpsNavigator()
        {
            return gpsNavigator;
        }

        public static double getFuel()
        {
            return fuel;
        }
    }

    public class Manual
    {
        private CarType type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gpsNavigator;

    public Manual(CarType type, int seats, Engine engine, Transmission transmission,
               TripComputer tripComputer, GPSNavigator gpsNavigator)
        {
            this.type = type;
            this.seats = seats;
            this.engine = engine;
            this.transmission = transmission;
            this.tripComputer = tripComputer;
            this.gpsNavigator = gpsNavigator;
        }

        public String print()
        {
            StringBuilder info = new StringBuilder();
            info.Append("CarType of car: " + type + "\n");
            info.Append("Count of seats: " + seats + "\n");
            info.Append("Engine: volume - " + engine.getVolume() + "; mileage - " + engine.getMileage() + "\n");
            info.Append("Transmission: " + transmission + "\n");
            info.Append("Trip Computer: Trip Computer" + "\n");
            info.Append("GPS Navigator: GPS Navigator" + "\n");
            return info.ToString();
        }
    }

    public enum CarType
    {
        CITY_CAR, SPORTS_CAR, SUV
    }
}
