using DesignPatterns.Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Program
    {
        CarBuilder builder = new CarBuilder();
        Director director = new Director();
        public void BuilderProgram()
        {
            director.BuildSuperCar(builder);
            Console.WriteLine(builder.GetCar().ToString());
            director.BuildFamilyCar(builder);
            Console.WriteLine(builder.GetCar().ToString());
        }
    
    
    }
}
