using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public  class HrisaDecorator  : LablebiDecorator
    {
        public HrisaDecorator(IMealOption mealOption) : base(mealOption)
        {
        }

        public override void AddMealOption(string MealOption)
        {
            base.AddMealOption(MealOption);
            Console.WriteLine("Lablebi now have hrisa");
        }
    }

}
