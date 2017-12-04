using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public class Funcionario : Pessoa
    {
        string senha, login;
        double salarioBase, salarioFinal, totVendas;

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public double SalarioBase
        {
            get
            {
                return salarioBase;
            }

            set
            {
                salarioBase = value;
            }
        }

        public double SalarioFinal
        {
            get
            {
                return salarioFinal;
            }

            set
            {
                salarioFinal = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public double TotVendas
        {
            get
            {
                return totVendas;
            }

            set
            {
                totVendas = value;
            }
        }

        public Funcionario()
        {

        }
        


        public Funcionario(string senha, string login, double salarioBase, double salarioFinal, double totVendas)
        {
            this.senha = senha;
            this.login = login;
            this.salarioBase = salarioBase;
            this.salarioFinal = salarioFinal;
            this.totVendas = totVendas;
        }
    }
    }

