using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework_Task2.models
{
    public class Driver
    {

        public Driver(string name, int level)
        {
            Name = name;
            Level = level;
        }

        // properties
        public string Name { get; set; }
        public int Level { get; set; }
    }
}
