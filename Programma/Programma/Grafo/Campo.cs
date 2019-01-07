using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programma
{
    public class Campo
    {
        public string nome;
        public string valore;

        public Campo(string nome)
        {
            this.nome = nome;
        }

        public string inStringa()
        {
            return nome + ": " + valore;
        }
    }
}
