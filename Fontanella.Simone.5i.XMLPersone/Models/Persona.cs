using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fontanella.Simone._5i.XMLPersone
{
    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Numero { get; set; }
        public string Indirizzo { get; set; }

        public Persona(XElement e)
        {
            Nome = e.Attribute("Nome").Value;
            Cognome = e.Attribute("Cognome").Value;
            Numero = e.Attribute("Numero").Value;
            Indirizzo = e.Attribute("Indirizzo").Value;
        }
    }
}
