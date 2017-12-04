using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public abstract class Pessoa
    {
        private string nome, telefone, cpf, rg, datanasc, ecivil, email, 
            cep, rua, bairro, numero, complemento, nomeBanco, agencia, nconta;
        private int id, removido;

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

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public string Datanasc
        {
            get
            {
                return datanasc;
            }

            set
            {
                datanasc = value;
            }
        }

        public string Ecivil
        {
            get
            {
                return ecivil;
            }

            set
            {
                ecivil = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public string Rua
        {
            get
            {
                return rua;
            }

            set
            {
                rua = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {
                complemento = value;
            }
        }

        public string NomeBanco
        {
            get
            {
                return nomeBanco;
            }

            set
            {
                nomeBanco = value;
            }
        }

        public string Agencia
        {
            get
            {
                return agencia;
            }

            set
            {
                agencia = value;
            }
        }

        public string Nconta
        {
            get
            {
                return nconta;
            }

            set
            {
                nconta = value;
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

        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string telefone, string cpf, string rg, string datanasc, string ecivil, string email, string cep, string rua, string bairro, string numero, string complemento, string nomeBanco, string agencia, string nconta, int id)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            this.rg = rg;
            this.datanasc = datanasc;
            this.ecivil = ecivil;
            this.email = email;
            this.cep = cep;
            this.rua = rua;
            this.bairro = bairro;
            this.numero = numero;
            this.complemento = complemento;
            this.nomeBanco = nomeBanco;
            this.agencia = agencia;
            this.nconta = nconta;
            this.id = id;
        }
    }
}
