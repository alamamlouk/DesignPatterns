using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Green : IColor
    {
        public void ColorTheShape()
        {
            Console.WriteLine("The shape is colored green");
        }
    }
}
