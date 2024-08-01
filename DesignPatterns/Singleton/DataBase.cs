using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class DataBase
    {
        private static int count = 0;

        private DataBase()
        {
            count++;
            Console.WriteLine($"count:{count}");
        }
        private static DataBase _instance;
        private static readonly object _lock = new object();
        public static DataBase GetInstance(string value)
        {

            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DataBase();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;

        }
        public string Value { get; set; }
    }
}
