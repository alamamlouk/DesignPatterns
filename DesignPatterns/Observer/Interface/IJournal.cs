using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public interface IJournal
    {
        void AddSubscriber(IObserver observer);
        void DetachSubscriber(IObserver observer);
        void Notify();
    }
}
