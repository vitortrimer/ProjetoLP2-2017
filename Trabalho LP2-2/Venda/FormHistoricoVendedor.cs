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
    public partial class FormHistoricoVendedor : Form
    {
        FuncionarioDAO vendedor = new FuncionarioDAO();
        VendaDAO venda = new VendaDAO();
        List<Funcionario> f = new List<Funcionario>();
        List<Venda> v = new List<Venda>();


        public FormHistoricoVendedor()
        {
            InitializeComponent();
            txtTelefone.Enabled = false;
            txtNome.Enabled = false;
            tbRG.Enabled = false;
            txtEmail.Enabled = false;
            txtEcivil.Enabled = false;

            v = venda.ListAll();

        }
        
        
        private void FormHistoricoVendedor_Load(object sender, EventArgs e)
        {

        }

        private void AtualizaDGV()
        {
            v = venda.ListAll();
            f = vendedor.ListAll();
            dgvPesquisar.Rows.Clear();
            foreach (Venda ve in v)
            {
                foreach (Funcionario func in f)
                {
                    if (ve.Vendedor.Id == func.Id)
                        dgvPesquisar.Rows.Add(ve.Id, ve.Cliente.Nome, ve.Carro.Nome, ve.Vendedor.Nome);
                    if (ve.Vendedor.Nome == "")
                    {
                        venda.Delete(ve.Id);
                        AtualizaDGV();
                    }
                }
            }
            dgvPesquisar.Refresh();
        }

        private void AtualizaDGVFiltrado(string nome)
        {
            List<Venda> v = new List<Venda>();
            v = venda.ListByVendedor(nome);
            dgvPesquisar.Rows.Clear();

            foreach (Venda ve in v)
                dgvPesquisar.Rows.Add(ve.Id, ve.Cliente.Nome, ve.Carro.Nome, ve.Vendedor.Nome);
        }


        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                FormAddVenda form = new FormAddVenda(venda.Read(key), false);
                form.ShowDialog(this);
            }
            else
                MessageBox.Show("Selecione uma linha para visualizar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            int key = 0;
            dgvPesquisar.Rows.Clear();
            v = venda.ListAll();
            f = vendedor.ListAll();

            foreach (Funcionario func in f)
            {
                if (txtCpf.Text == func.Cpf) 
                    key = func.Id;
                
            }
            if (key != 0)
            {
                    foreach (Venda ve in v)
                    if (ve.Vendedor.Id == key)
                    {
                        txtEcivil.Text = ve.Vendedor.Ecivil;
                        txtEmail.Text = ve.Vendedor.Email;
                        tbRG.Text = ve.Vendedor.Rg;
                        txtNome.Text = ve.Vendedor.Nome;
                        txtTelefone.Text = ve.Vendedor.Telefone;
                        AtualizaDGVFiltrado(ve.Vendedor.Nome);
                    }
            }
            else
            {
                txtEcivil.Text = "";
                txtEmail.Text = "";
                txtNome.Text = "";
                tbRG.Text = "";
                txtTelefone.Text = "";
            }

        }
    }
}
