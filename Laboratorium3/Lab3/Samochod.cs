using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Samochod
    {
        private string name;
        private double speed;
        private static Random random = new Random();

        public Samochod(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }

        public double GetSpeed()
        {
            return speed;
        }

        public static Samochod operator +(Samochod car1, Samochod car2)
        {
            Samochod result = new Samochod();
            result.name = car1.name + car2.name;
            result.name = result.name.ToUpper();
            result.speed = car1.speed + car2.speed;
            return result;
        }

        public static Samochod operator -(Samochod car1, Samochod car2)
        {
            Samochod result = new Samochod();
            result.name = car1.name + car2.name;
            result.name = result.name.ToLower();
            result.speed = car1.speed - car2.speed;
            return result;
        }

        public static Samochod operator *(Samochod car1, Samochod car2)
        {
            Samochod result = new Samochod();
            for (int i = 0; i < 10; i++)
            {
                result.name += Char.ConvertFromUtf32(random.Next(26) + 65);
            }
            result.speed = car1.speed * car2.speed;
            return result;
        }

        public static Samochod operator /(Samochod car1, Samochod car2)
        {
            Samochod result = new Samochod();
            for (int i = 0; i < 10; i++)
            {
                result.name += Char.ConvertFromUtf32(random.Next(26) + 65);
            }
            result.speed = car1.speed / car2.speed;
            return result;
        }


    }
}
    

