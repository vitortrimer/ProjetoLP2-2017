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
    public partial class FormAddCliente : Form
    {
        Cliente salva = new Cliente();
        private bool erro, editMode = false;
         
        
        

        public Cliente GetDTO()
        {
            Erro = false;
            Cliente c = new Cliente();

            if (txtCpf.Text == "" || txtNome.Text == "" || txtTelefone.Text == "" || txtRua.Text == ""
                || txtBairro.Text == "" || txtCep.Text == "" || txtRG.Text == "" || txtEstadoCivil.Text == ""
                || txtEmail.Text == "" || txtNumeroEnd.Text == "" || txtNomeBanco.Text == "" ||
                txtAgencia.Text == "" || txtConta.Text == "")
                Erro = true;
            c.Cpf = txtCpf.Text;
            c.Telefone = txtTelefone.Text;
            c.Nome = txtNome.Text;
            c.Bairro = txtBairro.Text;
            c.Rua = txtRua.Text;
            c.Email = txtEmail.Text;
            c.Rg = txtRG.Text;
            if (txtRenda.Text == "")
                c.Renda = 0;
            else
             c.Renda = double.Parse(txtRenda.Text);

            c.Numero = txtNumeroEnd.Text;
            if (txtComplemento.Text == "")
                c.Complemento = "0";
            else
              c.Complemento = txtComplemento.Text;

            c.Datanasc = dtpDataNasc.Text;
            c.Agencia = txtAgencia.Text;
            c.Nconta = txtConta.Text;
            c.Cep = txtCep.Text;
            c.NomeBanco = txtNomeBanco.Text;
            c.Ecivil = txtEstadoCivil.Text;
            if(txtCodigo.Text != "")
            {
                c.Id = int.Parse(txtCodigo.Text);
            }

            

            return c;
        }

        public void SetDTO(Cliente c)
        {
            txtCodigo.Text = "" + c.Id;
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
            txtRenda.Text = "" + c.Renda;
            txtRG.Text = c.Rg;
            dtpDataNasc.Text = c.Datanasc;
        }

        public FormAddCliente()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
        }
        
        public FormAddCliente(Cliente c, bool edit)
        {
            InitializeComponent();
            editMode = edit;
            SetDTO(c);
            if (editMode)
            {
                btLimpar.Visible = false;
                txtCodigo.Enabled = false;
            }
            else
            {
                btSalvar.Visible = false;
                btLimpar.Visible = false;
                btCancelar.Text = "Fechar";
                txtCodigo.Enabled = false;
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
                txtRenda.Enabled = false;
                txtRG.Enabled = false;
                txtTelefone.Enabled = false;
                dtpDataNasc.Enabled = false;
            }

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Salva = GetDTO();
           
            Dispose();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            
            Dispose();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
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
            txtRenda.Text = "";
            txtRG.Text = "";
            txtEmail.Text = "";
            dtpDataNasc.Text = "";
        }

        
        
        public Cliente Salva
        {
            get
            {
                return salva;
            }

            set
            {
                salva = value;
            }
        }

        private void FormAddCliente_Load(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
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
