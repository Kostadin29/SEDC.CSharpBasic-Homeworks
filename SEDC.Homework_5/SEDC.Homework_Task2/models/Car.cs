using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework_Task2.models
{
    public class Car
    {
        // Constructor
        public Car(string model, int speed )
        {
            Model = model;
            Speed = speed;
        }

        // properties
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        // Method CalculateSpeed()
        public int CalculateSpeed(Driver driver)
        {
            return driver.Level * Speed;
        }

       


    }
}
