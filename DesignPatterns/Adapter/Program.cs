using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Program
    {
        public void Pay()
        {
            Console.WriteLine("Welcome to Payment Process");
            Console.WriteLine("which currency you are using");
            Console.WriteLine("1. USD");
            Console.WriteLine("2. Euro");
            int currency = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount");
            double amount= Convert.ToDouble(Console.ReadLine());
            switch (currency)
            {
                case 1:
                    IPaymentProcess paymentProcessInUSD = new PaymentProcessAdapter();
                    paymentProcessInUSD.ProcessPayment(amount);
                    break;
                case 2:
                    IPaymentProcess paymentProcessInEuro = new EuroProcessPayment();
                    paymentProcessInEuro.ProcessPayment(amount);
                    break;
                default:
                    Console.WriteLine("Invalid currency");
                    break;
            }
        }
    }
}
