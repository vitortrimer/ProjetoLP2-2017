using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public class Vendas
    {
        private Carros carro;
        private Cliente cliente;
        private double precoFinal, juros;
        private int nParcelas, id;
        private DateTime data;

        public Vendas()
        {

        }

        public Vendas(Carros carro, Cliente cliente, double precoFinal, double juros, int nParcelas, int id, DateTime data)
        {
            this.carro = carro;
            this.cliente = cliente;
            this.precoFinal = precoFinal;
            this.juros = juros;
            this.nParcelas = nParcelas;
            this.id = id;
            this.data = data;
        }

        public Carros Carro
        {
            get
            {
                return carro;
            }

            set
            {
                carro = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }
        

        public double PrecoFinal
        {
            get
            {
                return precoFinal;
            }

            set
            {
                precoFinal = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public double Juros
        {
            get
            {
                return juros;
            }

            set
            {
                juros = value;
            }
        }

        public int NParcelas
        {
            get
            {
                return nParcelas;
            }

            set
            {
                nParcelas = value;
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
    }
}
