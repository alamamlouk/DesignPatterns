using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Entity
{
    public class Car
    {
        public string engine;
        public string wheel;
        public string doors;
        public int numberOfDoors;
        public string color;
        public string model;
        public int numberOfSeats;
        public override string ToString()
        {
            return "Engine: " + engine + "\n Wheel: " + wheel + "\n Doors: " + doors + "\n Number of Doors: " + numberOfDoors + "\n Color: " + color + "\n Model: " + model + "\n Number of Seats: " + numberOfSeats;
        }
    }
}
