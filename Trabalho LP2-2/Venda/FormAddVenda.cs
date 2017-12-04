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
    public partial class FormAddVenda : Form
    {
        private ClienteDAO cliente = new ClienteDAO();
        private FuncionarioDAO funcionario = new FuncionarioDAO();
        private Venda v = new Venda();
        private List<Venda> lv = new List<Venda>();
        private int key, keyvend, keycli;
        private bool erro, editMode, visualizar, attvend, attcli;
        public VendaMotor vm = new VendaMotor();


        public FormAddVenda()
        {
            InitializeComponent();
            Erro = true;
            txtTelefone.Enabled = false;
            txtNome.Enabled = false;
            txtRg.Enabled = false;
            txtNomeCarro.Enabled = false;
            txtPrecoTotal.Enabled = false;
            txtNomeFunc.Enabled = false;
            txtRg.Enabled = false;
            txtEmail.Enabled = false;
            txtEmailFunc.Enabled = false;
            txtRgFunc.Enabled = false;
            txtId.Enabled = false;
            txtPrecoTotal.Enabled = false;
            btnAddCarro.Enabled = false;
            dtpDataNasc.Enabled = false;

        }

        public FormAddVenda(Venda v, bool edit)
        {
            InitializeComponent();
            EditMode = edit;
            visualizar = true;
            txtCpf.Text = v.Cliente.Cpf;
            Erro = true;
            V = v;
            if (EditMode)
                btnLimpar.Visible = false;
            else
            {

                btnLimpar.Visible = false;
                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
                txtCpfFunc.Enabled = false;

                txtNome.Text = v.Cliente.Cpf;
                txtRg.Text = v.Cliente.Rg;
                txtEmail.Text = v.Cliente.Email;
                txtCpf.Text = v.Cliente.Cpf;
                txtCpfFunc.Text = v.Vendedor.Cpf;
                txtEmailFunc.Text = V.Vendedor.Email;
                txtId.Text = "" + V.Vendedor.Id;
                txtNomeFunc.Text = v.Vendedor.Nome;
                txtRgFunc.Text = v.Vendedor.Rg;
                dtpDataNasc.Text = v.DataVenda;
                txtNomeCarro.Text = V.Carro.Nome;
                txtPrecoTotal.Text = "" + V.PrecoTotal;

            }

            txtNomeFunc.Enabled = false;
            txtRg.Enabled = false;
            txtEmail.Enabled = false;
            txtEmailFunc.Enabled = false;
            txtRgFunc.Enabled = false;
            txtId.Enabled = false;
            txtPrecoTotal.Enabled = false;
            txtCpf.Enabled = false;
            txtTelefone.Enabled = false;
            txtNome.Enabled = false;
            txtRg.Enabled = false;
            txtNomeCarro.Enabled = false;
            txtPrecoTotal.Enabled = false;
            dtpDataNasc.Enabled = false;


            btnAddCarro.Click -= new System.EventHandler(this.btnAddCarro_Click);
            btnAddCarro.Click += new System.EventHandler(this.btnAddCarroEdit_Click);

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            erro = true;
            Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCpf.Text = "";
            txtRg.Text = "";
            txtNome.Text = "";
            txtNomeCarro.Text = "";
            txtTelefone.Text = "";
            txtPrecoTotal.Text = "";
        }

        private void btnAddCarroEdit_Click(object sender, EventArgs e)
        {

            FormVendaCarro form;
            form = new FormVendaCarro(V);
            Cliente c = new Cliente();
            Funcionario f = new Funcionario();


            c = V.Cliente;
            f = V.Vendedor;

            form.ShowDialog();
            /*
            V = form.V;
            V.Cliente = c;
            V.Vendedor = f;
            V.DataVenda = dtpDataNasc.Text;
            txtNomeCarro.Text = v.Carro.Nome;
            txtPrecoTotal.Text = "" + form.Preco;
            */

        }
        


        private void btnAddCarro_Click(object sender, EventArgs e)
        {
            
            FormVendaCarro form;
               // if(visualizar)
             //  form  = new FormOrcamento(V, true, EditMode);
              //   else
                form = new FormVendaCarro();
            Cliente c = new Cliente();
            Funcionario f = new Funcionario();

            c = V.Cliente;
            f = V.Vendedor;

            form.ShowDialog();
            V = form.V;
            V.Cliente = c;
            V.Vendedor = f;
            V.DataVenda = dtpDataNasc.Text;
            txtNomeCarro.Text = v.Carro.Nome;
            txtPrecoTotal.Text = "" +  form.Preco;
             
        }


        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            txtRg.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";

            keycli = 0;
            Key = 0;
            attcli = false;
            List<Cliente> c = new List<Cliente>();
            c = cliente.ListAll();

            foreach (Cliente cli in c)
            {
                if (txtCpf.Text == cli.Cpf)
                    keycli = cli.Id;
            }
            if (keycli != 0)
            {
                V.Cliente = cliente.Read(keycli);

                if (V.Cliente.Id != 0)
                {
                    attcli = true;
                    txtRg.Text = V.Cliente.Rg;
                    txtNome.Text = V.Cliente.Nome;
                    txtTelefone.Text = V.Cliente.Telefone;
                    txtEmail.Text = V.Cliente.Email;
                }
            }

            if(attcli == true && attvend == true)
            {
                btnSalvar.Enabled = true;
                btnAddCarro.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
                btnAddCarro.Enabled = false;
            }

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            VendaOpcional vo = new VendaOpcional();
            

            foreach (Motor m in v.Carro.Motor)
                vm.Idmotor = m.Id;



            v.DataVenda = dtpDataNasc.Text;
            Erro = false;
            if (txtNome.Text == "" || txtPrecoTotal.Text == "" || txtNomeFunc.Text == "")
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Dispose();
            }

            FormReportVenda report = new FormReportVenda(v);
            report.Show();


        }




        public int Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
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
        

        private void txtCpfFunc_TextChanged(object sender, EventArgs e)
        {
            attvend = false;
            keyvend = 0;
            txtRgFunc.Text = "";
            txtNomeFunc.Text = "";
            txtId.Text = "";
            txtEmailFunc.Text = "";

            Key = 0;
            List<Funcionario> f = new List<Funcionario>();
            f = funcionario.ListAll();

            foreach (Funcionario func in f)
            {
                if (txtCpfFunc.Text == func.Cpf)
                    keyvend = func.Id;
            }
            if (keyvend != 0)
            {
                V.Vendedor = funcionario.Read(keyvend);

                if (V.Vendedor.Id != 0)
                {
                    attvend = true;
                    txtRgFunc.Text = V.Vendedor.Rg;
                    txtNomeFunc.Text = V.Vendedor.Nome;
                    txtId.Text = "" + V.Vendedor.Id;
                    txtEmailFunc.Text = V.Vendedor.Email;
                }
            }

            if (attcli == true && attvend == true)
            {
                btnSalvar.Enabled = true;
                btnAddCarro.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
                btnAddCarro.Enabled = false;
            }


        }
        


        public bool EditMode
        {
            get
            {
                return editMode;
            }

            set
            {
                editMode = value;
            }
        }

        public Venda V
        {
            get
            {
                return v;
            }

            set
            {
                v = value;
            }
        }

        public bool Attvend
        {
            get
            {
                return attvend;
            }

            set
            {
                attvend = value;
            }
        }

        public bool Attcli
        {
            get
            {
                return attcli;
            }

            set
            {
                attcli = value;
            }
        }
        
    }
}
