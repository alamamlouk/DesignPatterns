using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class MealOption : IMealOption
    {
        public void AddMealOption(string MealOption)
        {
            Console.WriteLine($"Lablebi now have {MealOption}");
        }
    }
}
