using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Program
    {
        public void Darw()
        {
            Shape circle = new Circle(new Red());
            Shape rectangle = new Rectangle(new Green());
            circle.Draw();
            rectangle.Draw();
        }
    }
}
