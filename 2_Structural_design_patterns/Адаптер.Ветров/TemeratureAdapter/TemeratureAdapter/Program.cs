using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemeratureAdapter
{
    class Celsi
    {
        protected double temperature;
        public virtual double GetTemperature()
        {
            if (temperature >= -90 && temperature <= 60)
                return temperature;
            else
                return 0;
        }
        public virtual void SetTemperature(double t)
        {
            if (t >= -90 && t <= 60)
                temperature = t;
            else temperature = 0;
        }
        public Celsi()
        {
            temperature = 0;
        }
        public Celsi(double t)
        {
            temperature = t;
        }
    }
    class Fahrenheit
    {
        double fah;
        public double GetFahrenheit()
        {
            if (fah >= -130 && fah <= 140)
                return fah;
            else return 32;
        }
        public void SetFahrenheit(double f)
        {
            if (f >= -130 && f <= 140)
                fah = f;
            else fah = 32;
        }
        public Fahrenheit()
        {
            fah = 32;
        }
        public Fahrenheit(double f)
        {
            fah = f;
        }
    }
    class Kalvin
    {
        double kal;
        public double GetKalvin()
        {
            if (kal >= 183.15 && kal <= 333.15)
                return kal;
            else return 273.15F;
        }
        public void SetKalvin(double k)
        {
            if (k >= 183.15F && k <= 333.15F)
                kal = k;
            else kal = 273.15F;
        }
        public Kalvin()
        {
            kal = 273.15F;
        }
        public Kalvin(double k)
        {
            kal = k;
        }
    }
    class Adapter : Celsi
    {
        private Kalvin kalvin = new Kalvin();
        private Fahrenheit fahrenheit = new Fahrenheit();
        public Adapter(Kalvin k)
        {
            kalvin = k;
            fahrenheit = null;
        }
        public Adapter(Fahrenheit f)
        {
            fahrenheit = f;
            kalvin = null;
        }
        public override double GetTemperature()
        {
            if (kalvin != null)
            {
                return kalvin.GetKalvin() - 273.15F;
            }
            if (fahrenheit != null)
            {
                return (fahrenheit.GetFahrenheit() - 32) * 5 / 9;
            }
            return 0;
        }
        public override void SetTemperature(double t)
        {
            if (kalvin != null)
            {
                kalvin.SetKalvin(t);
            }
            else
                if (fahrenheit != null)
            {
                fahrenheit.SetFahrenheit(t);
            }
            else
                temperature = 0;
        }
    }
    
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("\nПогода в течении апреля:\n");
            for(int i = 1; i <= 30; i++)
            {
                Celsi todayTemp = new Celsi();
                switch(i % 3)
                {
                    case 0:
                        todayTemp = new Celsi();
                        todayTemp.SetTemperature(rnd.Next(-3, 15) + rnd.NextDouble());
                        break;
                    case 1:
                        todayTemp = new Adapter(new Kalvin());
                        todayTemp.SetTemperature(rnd.Next(268, 289) + rnd.NextDouble());
                        break;
                    case 2:
                        todayTemp = new Adapter(new Fahrenheit());
                        todayTemp.SetTemperature(rnd.Next(23, 59) + rnd.NextDouble());
                        break;
                }
                Console.WriteLine(i + "го апреля температура: " + Math.Round(todayTemp.GetTemperature(),1)+"\n");

            }
            Console.Read();
        }
    }
}
