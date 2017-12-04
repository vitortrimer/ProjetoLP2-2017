using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public class VendaMotor
    {
        private int idvenda, idmotor;

        public int Idmotor
        {
            get
            {
                return idmotor;
            }

            set
            {
                idmotor = value;
            }
        }

        public int Idvenda
        {
            get
            {
                return idvenda;
            }

            set
            {
                idvenda = value;
            }
        }
    }
}
