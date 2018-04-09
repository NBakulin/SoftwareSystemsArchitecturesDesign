using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternBuilder.Cars;
using PatternBuilder.components;

namespace PatternBuilder
{
    public interface Builder
    {
        void setType(CarType type);
        void setSeats(int seats);
        void setEngine(Engine engine);
        void setTransmission(Transmission transmission);
        void setTripComputer(TripComputer tripComputer);
        void setGPSNavigator(GPSNavigator gpsNavigator);
    }

    public class CarBuilder : Builder
    {
        private CarType type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gpsNavigator;
        
        public void setType(CarType type)
        {
            this.type = type;
        }
        
        public void setSeats(int seats)
        {
            this.seats = seats;
        }
        
        public void setEngine(Engine engine)
        {
            this.engine = engine;
        }
        
        public void setTransmission(Transmission transmission)
        {
            this.transmission = transmission;
        }
        
        public void setTripComputer(TripComputer tripComputer)
        {
            this.tripComputer = tripComputer;
        }
        
        public void setGPSNavigator(GPSNavigator gpsNavigator)
        {
            this.gpsNavigator = gpsNavigator;
        }

        public Car getResult()
        {
            return new Car(type, seats, engine, transmission, tripComputer, gpsNavigator);
        }
    }

    public class CarManualBuilder : Builder
    {
        private CarType type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gpsNavigator;
        
        public void setType(CarType type)
        {
            this.type = type;
        }
        
        public void setSeats(int seats)
        {
            this.seats = seats;
        }
        
        public void setEngine(Engine engine)
        {
            this.engine = engine;
        }
        
        public void setTransmission(Transmission transmission)
        {
            this.transmission = transmission;
        }
        
        public void setTripComputer(TripComputer tripComputer)
        {
            this.tripComputer = tripComputer;
        }
        
        public void setGPSNavigator(GPSNavigator gpsNavigator)
        {
            this.gpsNavigator = gpsNavigator;
        }

        public Manual getResult()
        {
            return new Manual(type, seats, engine, transmission, tripComputer, gpsNavigator);
        }
    }
}
