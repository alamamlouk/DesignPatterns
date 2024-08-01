using DesignPatterns.Builder.Entity;
using DesignPatterns.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builder
{
    internal class CarBuilder : ICarBuilder
    {
        private Car car = new Car();
        public Car GetCar()
        {
            Car car = this.car;
            Reset();
            return car;
        }
        public void Reset()=> car = new Car();

        public void SetColor(string color)=> car.color = color;

        public void SetDoors(string DoorType)=> car.doors = DoorType;

        public void SetEngine(string EngineName)=> car.engine = EngineName;

        public void SetModel(string model)=> car.model = model;

        public void SetNumberOfDoors(int numberOfDoors)=> car.numberOfDoors = numberOfDoors;

        public void SetNumberOfSeats(int numberOfSeats)=> car.numberOfSeats = numberOfSeats;

        public void SetWheel(string WheelType)=> car.wheel = WheelType;
    }
}
