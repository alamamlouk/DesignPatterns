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
        CarDirector director = new CarDirector();
        public void BuildCar()
        {
            director.BuildSuperCar(builder);
            Console.WriteLine(builder.GetCar().ToString());
            director.BuildFamilyCar(builder);
            Console.WriteLine(builder.GetCar().ToString());
        }
    
    
    }
}
