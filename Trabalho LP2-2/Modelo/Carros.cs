using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public class Carros
    {
        private int cod, codoriginal;
        private string nome, modelo, motorTexto;
        private double precoTotal, pAdicional;
        private Motores motor = new Motores();
        private bool tetoSolar = false, multimidia = false, ligaLeve = false;



        public Carros()
        {

        }

        public Carros(int cod, int codoriginal, string nome, string modelo, string motorTexto, double precoTotal, double pAdicional, Motores motor, bool tetoSolar, bool multimidia, bool ligaLeve)
        {
            this.cod = cod;
            this.codoriginal = codoriginal;
            this.nome = nome;
            this.modelo = modelo;
            this.motorTexto = motorTexto;
            this.precoTotal = precoTotal;
            this.pAdicional = pAdicional;
            this.motor = motor;
            this.tetoSolar = tetoSolar;
            this.multimidia = multimidia;
            this.ligaLeve = ligaLeve;
        }

        public int Cod
        {
            get
            {
                return cod;
            }

            set
            {
                cod = value;
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

        public Motores Motor
        {
            get
            {
                return motor;
            }

            set
            {
                motor = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public bool TetoSolar
        {
            get
            {
                return tetoSolar;
            }

            set
            {
                tetoSolar = value;
            }
        }

        public bool Multimidia
        {
            get
            {
                return multimidia;
            }

            set
            {
                multimidia = value;
            }
        }

        public bool LigaLeve
        {
            get
            {
                return ligaLeve;
            }

            set
            {
                ligaLeve = value;
            }
        }

        public double PAdicional
        {
            get
            {
                return pAdicional;
            }

            set
            {
                pAdicional = value;
            }
        }

        public string MotorTexto
        {
            get
            {
                return motorTexto;
            }

            set
            {
                motorTexto = value;
            }
        }

        public int Codoriginal
        {
            get
            {
                return codoriginal;
            }

            set
            {
                codoriginal = value;
            }
        }
    }
}
