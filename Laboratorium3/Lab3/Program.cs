using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod car1 = new Samochod("Fiat", 100);
            Samochod car2 = new Samochod("Opel", 180);

            Console.WriteLine("Samochod 1: " + car1.GetName() + ", predkosc " + car1.GetSpeed());
            Console.WriteLine("Samochod 2: " + car2.GetName() + ", predkosc " + car2.GetSpeed());
            Console.WriteLine("Nowy samochod +: " + (car1 + car2).GetName() + ", predkosc " + (car1 + car2).GetSpeed());
            Console.WriteLine("Nowy samochod -: " + (car1 - car2).GetName() + ", predkosc " + (car1 - car2).GetSpeed());
            Console.WriteLine("Nowy samochod *: " + (car1 * car2).GetName() + ", predkosc " + (car1 * car2).GetSpeed());
            Console.WriteLine("Nowy samochod /: " + (car1 / car2).GetName() + ", predkosc " + (car1 / car2).GetSpeed());
        }
    }
}
