using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class PaymentProcessAdapter:IPaymentProcess
    {
        private EuroProcessPayment _euroProcessPayment;
        public PaymentProcessAdapter()
        {
            _euroProcessPayment = new EuroProcessPayment();
        }
        public void ProcessPayment(double amount)
        {
            _euroProcessPayment.ProcessPayment(amount*1.08);
        }
    }
    
}
