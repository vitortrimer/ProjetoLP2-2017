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
    public partial class FormAddOpcionais : Form
    {
        public Opcional Op = new Opcional();
        

        public FormAddOpcionais()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        public FormAddOpcionais(Opcional op, bool edit)
        {
            InitializeComponent();
            txtId.Enabled = false;

            txtAno.Text = op.Ano;
            txtId.Text = "" + op.Id;
            txtItens.Text = op.Itens;
            txtNome.Text = op.Nome;
            txtPreco.Text = "" + op.Preco;

            if(edit == true)
            {
                btLimpar.Visible = false;
            }
            else
            {
                btSalvar.Visible = false;
                btLimpar.Visible = false;
                btCancelar.Text = "Fechar";

                txtAno.Enabled = false;
                txtId.Enabled = false;
                txtItens.Enabled = false;
                txtNome.Enabled = false;
                txtPreco.Enabled = false;
            }



        }


        private void FormAddOpcionais_Load(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Op.Ano = txtAno.Text;
            Op.Itens = txtItens.Text;
            Op.Nome = txtNome.Text;
            Op.Preco = double.Parse(txtPreco.Text);
            if (txtId.Text != "")
            Op.Id = int.Parse(txtId.Text);
            Dispose();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtAno.Text = "";
            txtItens.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
        }
        


    }
}
