using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public class Opcional
    {
        private int id, removido = 0;
        private string nome, itens, ano;
        private double preco;

        public Opcional()
        {

        }

        public Opcional(int id, string nome, string itens, string ano, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.itens = itens;
            this.ano = ano;
            this.preco = preco;
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

        public string Itens
        {
            get
            {
                return itens;
            }

            set
            {
                itens = value;
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

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
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
