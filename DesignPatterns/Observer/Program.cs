using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public  class Program
    {
        public void Publish() { 
            IObserver observer1 = new Citizen("John");
            IObserver observer2 = new Citizen("Jane");
            Journal journal = new Journal("New York Times");
            journal.AddSubscriber(observer1);
            journal.AddSubscriber(observer2);
            journal.NewIssue();
            journal.DetachSubscriber(observer1);
        }
    }
}
