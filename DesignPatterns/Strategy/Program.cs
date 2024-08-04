using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public  class Program
    {
        public  void Compress()
        {
            CompressService compressService = new CompressService();
            compressService.SetCompressionStrategy(new CompressToZIP());
            compressService.CompressFile("file1");
            compressService.SetCompressionStrategy(new CompressToRar());
            compressService.CompressFile("file2");
        }
    }
}
