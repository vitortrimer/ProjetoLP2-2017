using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_LP2_2
{
    public partial class FormMenuPesquisas : Form
    {
        public int Opc = 0;

        public FormMenuPesquisas()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btHistCompras_Click(object sender, EventArgs e)
        {
            Opc = 1;
            Dispose();
        }

        private void btHistCarros_Click(object sender, EventArgs e)
        {
            Opc = 2;
            Dispose();
        }

        private void btHistFuncionarios_Click(object sender, EventArgs e)
        {
            Opc = 3;
            Dispose();
        }
    }
}
