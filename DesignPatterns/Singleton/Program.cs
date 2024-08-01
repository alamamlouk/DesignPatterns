using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Program
    {
        public void SingletonProgram()
        {
            Parallel.Invoke(
                 () => TestSingleton("Foo"),
                 () => TestSingleton("Bar")
             );
        }
        public static void TestSingleton(string value)
        {
            DataBase singleton = DataBase.GetInstance(value);
            Console.WriteLine(singleton.Value);

        }
    }
}
