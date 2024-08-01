using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Shape
    {
        protected IColor color;
        public Shape(IColor color)
        {
            this.color = color;
        }
        public virtual void Draw()
        {
            Console.WriteLine("The shape is drawn");
        }

    }
}
