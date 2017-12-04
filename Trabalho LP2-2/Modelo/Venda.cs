using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public class Venda
    {
        private Cliente cliente = new Cliente();
        private Funcionario vendedor = new Funcionario();
        private Carro carro = new Carro();
        private string dataVenda;
        private double desconto, juros, precoCarro, precoTotal, entrada, precoParcela, restante, precoAPAgar, valParcela;
        private int nParcelas, id, idCliente, idVendedor, idCarro, removido;



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

        public Funcionario Vendedor
        {
            get
            {
                return vendedor;
            }

            set
            {
                vendedor = value;
            }
        }

        public Carro Carro
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

        public string DataVenda
        {
            get
            {
                return dataVenda;
            }

            set
            {
                dataVenda = value;
            }
        }

        public double Desconto
        {
            get
            {
                return desconto;
            }

            set
            {
                desconto = value;
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

        public double PrecoCarro
        {
            get
            {
                return precoCarro;
            }

            set
            {
                precoCarro = value;
            }
        }

        public double PrecoTotal
        {
            get
            {
                return precoTotal;
            }

            set
            {
                precoTotal = value;
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

        public double Entrada
        {
            get
            {
                return entrada;
            }

            set
            {
                entrada = value;
            }
        }

        public double PrecoParcela
        {
            get
            {
                return precoParcela;
            }

            set
            {
                precoParcela = value;
            }
        }

        public double Restante
        {
            get
            {
                return restante;
            }

            set
            {
                restante = value;
            }
        }

        public double PrecoAPAgar
        {
            get
            {
                return precoAPAgar;
            }

            set
            {
                precoAPAgar = value;
            }
        }

        public double ValParcela
        {
            get
            {
                return valParcela;
            }

            set
            {
                valParcela = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public int IdVendedor
        {
            get
            {
                return idVendedor;
            }

            set
            {
                idVendedor = value;
            }
        }

        public int IdCarro
        {
            get
            {
                return idCarro;
            }

            set
            {
                idCarro = value;
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
