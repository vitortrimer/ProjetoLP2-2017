using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public class Cliente : Pessoa
    {
        private double renda;

        public double Renda
        {
            get
            {
                return renda;
            }

            set
            {
                renda = value;
            }
        }
    }
}
