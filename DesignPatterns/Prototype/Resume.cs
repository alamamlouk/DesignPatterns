using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    internal class Resume : IDocumentPrototype
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string Experience { get; set; }
        public IDocumentPrototype Clone()
        {
            return new Resume
            {
                Name = Name,
                Surname = Surname,
                BirthDate = BirthDate,
                Address = Address,
                Experience = Experience
            };
        }
        public override string ToString()
        {
            return "Name: " + Name + " Surname: " + Surname + " BirthDate: " + BirthDate + " Address: " + Address + " Experience: " + Experience;
        }
    }
}
