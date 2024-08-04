using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Citizen:IObserver
    {
        public string Name { get; set; }
        public Citizen(string name)
        {
            Name = name;
        }

        public void Update(IJournal journal)
        {
            Console.WriteLine($"Citizen {Name} is reading the new issue of {(journal as Journal).PaperName}");
        }
    }
}
