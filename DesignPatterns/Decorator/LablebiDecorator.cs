using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class LablebiDecorator : IMealOption
    {
        private IMealOption _mealOption;

        protected LablebiDecorator(IMealOption mealOption)
        {
            _mealOption = mealOption;
        }

        public virtual void AddMealOption(string MealOption)
        {
            _mealOption.AddMealOption(MealOption);
        }
    }
}
