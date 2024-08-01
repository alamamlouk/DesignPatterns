using DesignPatterns.Builder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Interfaces
{
    public interface ICarBuilder
    {
        void SetEngine(string EngineName);
        void SetWheel(string WheelType);
        void SetDoors(string DoorType);
        void SetNumberOfDoors(int numberOfDoors);
        void SetColor(string color);
        void SetModel(string model);
        void SetNumberOfSeats(int numberOfSeats);
        Car GetCar();
    }
}
