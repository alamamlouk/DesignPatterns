﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public interface IPaymentProcess
    {
        void ProcessPayment(double amount);
        
    }
}
