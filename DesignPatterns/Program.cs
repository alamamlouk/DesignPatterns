using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Program");
            Singleton.Program singleton = new Singleton.Program();
            singleton.SingletonProgram();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Builder Program");
            Builder.Program builder = new Builder.Program();
            builder.BuilderProgram();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Prototype Program");
            Prototype.Program  prototype = new Prototype.Program();
            prototype.PrototypeProgram();
        }
    }
}
