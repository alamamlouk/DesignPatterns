using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Register
    {
        private Dictionary<string,IDocumentPrototype> _documents= new Dictionary<string, IDocumentPrototype>();
        public void RegisterDocument(string key, IDocumentPrototype document)
        {
            _documents.Add(key, document);
        }
        public IDocumentPrototype GetDocumentPrototype(string key)
        {
            return _documents[key].Clone();
        }

    }
}
