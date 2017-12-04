using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public class Carro
    {
        private int id, removido = 0;
        private string nome, modelo;
        private double precoBase;
        private List<Motor> motor = new List<Motor>();
        private List<Opcional> opcional = new List<Opcional>();
        

        public Carro()
        {

        }

        public Carro(string nome, string modelo, double precoBase, List<Motor> motor, List<Opcional> opcional)
        {
            this.Nome = nome;
            this.Modelo = modelo;
            this.PrecoBase = precoBase;
            this.Motor = motor;
            this.Opcional = opcional;
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

        public List<Motor> Motor
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

        public List<Opcional> Opcional
        {
            get
            {
                return opcional;
            }

            set
            {
                opcional = value;
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
    }
}
