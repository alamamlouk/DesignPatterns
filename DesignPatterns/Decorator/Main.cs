using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    internal class Main
    {
        public void MainProgram()
        {
            IMealOption mealOption = new HrisaDecorator(new EggsDecorator(new MealOption()));
            mealOption.AddMealOption("Souce");
        }
    }
}
