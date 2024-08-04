using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Journal : IJournal
    {
        public string PaperName { get; set; }
        public Journal(string paperName)
        {
            PaperName = paperName;
        }
       private List<IObserver> _subscribers = new List<IObserver>();

        public void AddSubscriber(IObserver observer)
        {
            _subscribers.Add(observer);
        }

        public void DetachSubscriber(IObserver observer)
        {
            _subscribers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }

        public void NewIssue()
        {
            Console.WriteLine($"New issue of {PaperName} is out!");
            Notify();
        }

    }
}
