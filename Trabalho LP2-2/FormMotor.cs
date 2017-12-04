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
    public partial class FormMotor : Form
    {
        public FormMotor()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FormGerenciaMotor form = new FormGerenciaMotor();
            form.ShowDialog();
        }
    }
}
