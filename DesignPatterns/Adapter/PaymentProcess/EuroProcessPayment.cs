using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class EuroProcessPayment:IPaymentProcess
    {
        public double currency { get; set; }
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Payment processed in Euro: " + amount);
            currency = amount;
        }
    }
}
