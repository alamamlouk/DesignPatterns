using DesignPatterns.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Director
    {
        public void BuildSuperCar(ICarBuilder carBuilder)
        {
            carBuilder.SetModel("Super Car");
            carBuilder.SetEngine("V8");
            carBuilder.SetWheel("20 inch");
            carBuilder.SetDoors("Butterfly");
            carBuilder.SetNumberOfDoors(2);    
            carBuilder.SetColor("Red");
            carBuilder.SetNumberOfSeats(2);
        }
        public void BuildFamilyCar(ICarBuilder carBuilder)
        {
            carBuilder.SetModel("Family Car");
            carBuilder.SetEngine("V4");
            carBuilder.SetWheel("16 inch");
            carBuilder.SetDoors("Normal");
            carBuilder.SetNumberOfDoors(4);
            carBuilder.SetColor("Blue");
            carBuilder.SetNumberOfSeats(5);
        }
    }
}
