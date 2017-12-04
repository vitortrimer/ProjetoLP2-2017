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
    public partial class FormAddFuncionariocs : Form
    {
        private Funcionario f = new Funcionario();
        private bool erro;



        public FormAddFuncionariocs()
        {
            InitializeComponent();
            txtId.Enabled = false;
            
        }


        public FormAddFuncionariocs(Funcionario c, bool edit)
        {
            InitializeComponent();

            txtId.Text = "" + c.Id;
            txtCpf.Text = c.Cpf;
            txtRua.Text = c.Rua;
            txtNome.Text = c.Nome;
            txtTelefone.Text = c.Telefone;
            txtAgencia.Text = c.Agencia;
            txtBairro.Text = c.Bairro;
            txtCep.Text = c.Cep;
            txtComplemento.Text = c.Complemento;
            txtConta.Text = c.Nconta;
            txtEmail.Text = c.Email;
            txtEstadoCivil.Text = c.Ecivil;
            txtNomeBanco.Text = c.NomeBanco;
            txtNumeroEnd.Text = c.Numero;
            txtSalario.Text = "" + c.SalarioBase;
            txtRG.Text = c.Rg;
            dtpDataNasc.Text = c.Datanasc;
            txtLogin.Text = c.Login;
            txtSenha.Text = c.Senha;

            if (edit)
            {
                btLimpar.Visible = false;
                txtId.Enabled = false;
            }
            else
            {
                btSalvar.Visible = false;
                btLimpar.Visible = false;
                btCancelar.Text = "Fechar";
                txtId.Enabled = false;
                txtCpf.Enabled = false;
                txtRua.Enabled = false;
                txtNome.Enabled = false;
                txtTelefone.Enabled = false;
                txtAgencia.Enabled = false;
                txtBairro.Enabled = false;
                txtCep.Enabled = false;
                txtComplemento.Enabled = false;
                txtConta.Enabled = false;
                txtCpf.Enabled = false;
                txtEmail.Enabled = false;
                txtEstadoCivil.Enabled = false;
                txtNomeBanco.Enabled = false;
                txtNumeroEnd.Enabled = false;
                txtSalario.Enabled = false;
                txtRG.Enabled = false;
                txtTelefone.Enabled = false;
                dtpDataNasc.Enabled = false;
                txtLogin.Enabled = false;
                txtSenha.Enabled = false;
            }
        }




        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtAgencia.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            txtComplemento.Text = "";
            txtConta.Text = "";
            txtEstadoCivil.Text = "";
            txtNomeBanco.Text = "";
            txtCpf.Text = "";
            txtRua.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtNumeroEnd.Text = "";
            txtRG.Text = "";
            txtEmail.Text = "";
            dtpDataNasc.Text = "";
            txtSalario.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtNomeBanco.Text = "";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            if (txtComplemento.Text == "")
                F.Complemento = "0";
            else
                F.Complemento = txtComplemento.Text;
            F.Cpf = txtCpf.Text;
            F.Telefone = txtTelefone.Text;
            F.Nome = txtNome.Text;
            F.Bairro = txtBairro.Text;
            F.Rua = txtRua.Text;
            F.Email = txtEmail.Text;
            F.Rg = txtRG.Text;
            F.SalarioBase = double.Parse(txtSalario.Text);
            F.Numero = txtNumeroEnd.Text;
            F.Datanasc = dtpDataNasc.Text;
            F.Agencia = txtAgencia.Text;
            F.Nconta = txtConta.Text;
            F.NomeBanco = txtNomeBanco.Text;
            F.Ecivil = txtEstadoCivil.Text;
            F.Cep = txtCep.Text;
            F.Login = txtLogin.Text;
            F.Senha = txtSenha.Text;

            if (txtId.Text != "")
                F.Id = int.Parse(txtId.Text);
            Dispose();
        }



        public Funcionario F
        {
            get
            {
                return f;
            }

            set
            {
                f = value;
            }
        }

        public bool Erro
        {
            get
            {
                return erro;
            }

            set
            {
                erro = value;
            }
        }

    }
}
