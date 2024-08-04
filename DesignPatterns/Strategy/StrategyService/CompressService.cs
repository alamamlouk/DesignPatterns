using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class CompressService
    {
        private IDataCompressionStrategy _compressionStrategy;
        public void CompressFile(string fileName)
        {
            _compressionStrategy.CompressData(fileName);
        }
        public void SetCompressionStrategy(IDataCompressionStrategy compressionStrategy)
        {
            _compressionStrategy = compressionStrategy;
        }
    }
}
