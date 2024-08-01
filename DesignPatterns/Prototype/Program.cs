using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Program
    {
        public void PrototypeProgram()
        {
          
            Register register = new Register();
            register.RegisterDocument("Document",new Document { Title="design pattern", Content="prototype" });
            register.RegisterDocument("Resume", new Resume { Name = "fd", Address = "sd", BirthDate = "sd", Experience = "fs" ,Surname="df"});

            IDocumentPrototype document = register.GetDocumentPrototype("Document");
            IDocumentPrototype resume = register.GetDocumentPrototype("Resume");
            Console.WriteLine(document.ToString());
            Console.WriteLine(resume.ToString());
        }
    }
}
