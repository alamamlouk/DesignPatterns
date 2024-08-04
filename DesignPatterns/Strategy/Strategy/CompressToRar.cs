using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class CompressToRar : IDataCompressionStrategy
    {
        public void CompressData(string fileName)
        {
            Console.WriteLine("Compressing to RAR: " + fileName);
        }
    }
}
