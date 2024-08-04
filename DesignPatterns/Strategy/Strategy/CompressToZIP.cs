using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class CompressToZIP : IDataCompressionStrategy
    {
        public void CompressData(string fileName)
        {
            Console.WriteLine("Compressing to ZIP: " + fileName);
        }
    }
 
}
