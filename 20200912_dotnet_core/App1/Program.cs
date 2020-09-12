using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car c1 = new Car();
            c1.Speed = 100;
            Console.WriteLine(c1.Speed);
            c1.Speed += 1;
            Console.WriteLine(c1.Speed);
            Console.WriteLine(c1.Horsepower += 1);
            Console.WriteLine(c1.Horsepower += 1);
            Console.WriteLine(c1.Torgue += 3);

            c1.Speed = 10;
            Console.WriteLine(c1.Speed);
            c1.SpeedUp(30);
            Console.WriteLine(c1.Speed);

            RaceCar c2 = new RaceCar();
            c2.SpeedUp(30);
            Console.Out.WriteLine(c2.Speed);
            Console.WriteLine(c2.Torgue);
        }
    }
}
