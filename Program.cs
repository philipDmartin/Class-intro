using System;
using System.Collections.Generic;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFordBronco = new Car(4000, "Ford", "Bronco", 1982);

            Car mySubaru = new Car(1000)
            {
                Make = "Subaru",
                Model = "Forrester",
                Year = 1999
            };

            myFordBronco.Drive(9999);

            Console.WriteLine($"Bronco needs service:{myFordBronco.NeedMaintenence}");

            myFordBronco.Drive(60);

            Console.WriteLine($"Bronco needs service:{myFordBronco.NeedMaintenence}");

            myFordBronco.Service(true);
        }
    }
}