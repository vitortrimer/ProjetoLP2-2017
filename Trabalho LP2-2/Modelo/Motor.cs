using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public class Motor
    {
        private int id, removido = 0;
        private string nome, litragem, ano, cavalos;
        private double precoBase;

        public Motor()
        {

        }

        public Motor(int id, string nome, string litragem, string ano, string cavalos, double precoBase)
        {
            this.id = id;
            this.nome = nome;
            this.litragem = litragem;
            this.ano = ano;
            this.cavalos = cavalos;
            this.precoBase = precoBase;
        }

        public string Ano
        {
            get
            {
                return ano;
            }

            set
            {
                ano = value;
            }
        }

        public string Cavalos
        {
            get
            {
                return cavalos;
            }

            set
            {
                cavalos = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Litragem
        {
            get
            {
                return litragem;
            }

            set
            {
                litragem = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public double PrecoBase
        {
            get
            {
                return precoBase;
            }

            set
            {
                precoBase = value;
            }
        }

        public int Removido
        {
            get
            {
                return removido;
            }

            set
            {
                removido = value;
            }
        }
    }
}
