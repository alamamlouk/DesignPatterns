using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Program
    {
        public void MakeLablebi()
        {
            IMealOption mealOption = new HrisaDecorator(new EggsDecorator(new MealOption()));
            mealOption.AddMealOption("Souce");
        }
    }
}
