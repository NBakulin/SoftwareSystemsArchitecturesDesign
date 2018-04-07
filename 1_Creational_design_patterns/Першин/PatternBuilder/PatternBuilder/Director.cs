using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternBuilder.Cars;
using PatternBuilder.components;

namespace PatternBuilder
{
    public class Director
    {

        public void constructSportsCar(Builder builder)
        {
            builder.setType(CarType.SPORTS_CAR);
            builder.setSeats(2);
            builder.setEngine(new Engine(3.0, 0));
            builder.setTransmission(Transmission.SEMI_AUTOMATIC);
            builder.setTripComputer(new TripComputer());
            builder.setGPSNavigator(new GPSNavigator());
        }

        public void constructCityCar(Builder builder)
        {
            builder.setType(CarType.CITY_CAR);
            builder.setSeats(2);
            builder.setEngine(new Engine(1.2, 0));
            builder.setTransmission(Transmission.AUTOMATIC);
            builder.setTripComputer(new TripComputer());
            builder.setGPSNavigator(new GPSNavigator());
        }

        public void constructSUV(Builder builder)
        {
            builder.setType(CarType.SUV);
            builder.setSeats(4);
            builder.setEngine(new Engine(2.5, 0));
            builder.setTransmission(Transmission.MANUAL);
            builder.setGPSNavigator(new GPSNavigator());
        }
    }
}
