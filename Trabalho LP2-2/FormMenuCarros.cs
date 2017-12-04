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
    public partial class FormMenuCarros : Form
    {
        public int Opc = 9;
        private FormGerenciaCarros formAdmCarros;

        public FormMenuCarros()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btGerenciaCarros_Click(object sender, EventArgs e)
        {
            Opc = 1;
            Dispose();
        }

        private void btOrcamento_Click(object sender, EventArgs e)
        {
            Opc = 0;
            Dispose();
        }
    }
}
