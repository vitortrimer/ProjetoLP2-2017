using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    public class VendaOpcional
    {
        private int idvenda, idopcional;

        public int Idopcional
        {
            get
            {
                return idopcional;
            }

            set
            {
                idopcional = value;
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
