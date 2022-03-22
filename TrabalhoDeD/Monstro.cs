using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDeD
{
    class Monstro
    {
        public string nome { get; private set; }
        public int nivel { get; private set; }
        public Status status { get; private set; }

        public Monstro(string nome, int nivel, Status status)
        {
            this.nome = nome;
            this.nivel = nivel;
            this.status = status;
        }
    }
}
