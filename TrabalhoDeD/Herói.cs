using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDeD
{
    class Herói
    {
        public string nome { get; private set; }
        public int idade { get; private set; }
        public int nivel { get; private set; }
        public Status status { get; private set; }


        public Herói(string nome, int idade, int nivel, Status status)
        {
            this.nome = nome;
            this.idade = idade;
            this.nivel = nivel;
            this.status = status;
        }
    }
}