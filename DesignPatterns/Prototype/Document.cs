using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    internal class Document:IDocumentPrototype
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public IDocumentPrototype Clone()
        {
            return new Document { Title=Title, Content=Content };
        }

        public override string ToString()
        {
            return Title + " " + Content;
        }
    }
    
}
