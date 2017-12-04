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
    public partial class FormGerenciaMotor : Form
    {
        public Motor M = new Motor();

        public FormGerenciaMotor()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        public FormGerenciaMotor(Motor m, bool edit)
        {
            InitializeComponent();
            txtId.Enabled = false;

            txtPrecoBase.Text = "" + m.PrecoBase;
            txtNome.Text = m.Nome;
            txtLitragem.Text = m.Litragem;
            txtId.Text = "" + m.Id;
            txtCavalos.Text = m.Cavalos;
            txtAno.Text = m.Ano;


            if (edit)
            {
                btLimpar.Visible = false;
            }
            else
            {
                btSalvar.Visible = false;
                btLimpar.Visible = false;
                btCancelar.Text = "Fechar";
                txtAno.Enabled = false;
                txtCavalos.Enabled = false;
                txtId.Enabled = false;
                txtLitragem.Enabled = false;
                txtNome.Enabled = false;
                txtPrecoBase.Enabled = false;
            }
            
    }



        public void btCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void btSalvar_Click(object sender, EventArgs e)
        {
            M.Ano = txtAno.Text;
            M.Cavalos = txtCavalos.Text;
            M.Litragem = txtLitragem.Text;
            M.Nome = txtNome.Text;
            M.PrecoBase = double.Parse(txtPrecoBase.Text);
            if(txtId.Text != "")
            M.Id = int.Parse(txtId.Text);
            Dispose();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtAno.Text = "";
            txtCavalos.Text = "";
            txtLitragem.Text = "";
            txtNome.Text = "";
            txtPrecoBase.Text = "";
        }
    }
}
