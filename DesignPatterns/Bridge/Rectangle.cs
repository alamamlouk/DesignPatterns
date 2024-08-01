using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    internal class Rectangle: Shape
    {
        public Rectangle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine("The shape is a rectangle");
            color.ColorTheShape();
        }
    }
}
