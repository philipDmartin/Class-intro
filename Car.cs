using System;

namespace classIntro
{
    public class Car
    {
        //Fields
        //Fields dont have a get set and are usually privet
        private int _milesDriven = 0;

        //properties
        //properties have a get set and are usually puplic
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool NeedMaintenence { get; set; } = false;
        public bool IsClean { get; set; } = false;
        public string Description
        {
            get
            {
                return $"{Year} {Make} {Model}";
            }
        }
        public void Drive(int miles)
        {
            _milesDriven += miles;

            if (_milesDriven > 10000)
            {
                NeedMaintenence = true;
            }
        }
        public void Service()
        {
            NeedMaintenence = false;
        }

        // Method overloading
        //Shares a mothod name, but has different arguments
        public void Service(bool addCleaningService)
        {
            NeedMaintenence = false;

            if (addCleaningService)
            {
                IsClean = true;
            }
        }

        //This is a constuctor. it doesnt have a return type
        //and the name of the method is the same as the name of the class
        public Car(int milesDriven)
        {
            _milesDriven = milesDriven;
        }

        public Car(int milesDriven, string make, string model, int year)
        {
            _milesDriven = milesDriven;
            Make = make;
            Model = model;
            Year = year;
        }
    }
}