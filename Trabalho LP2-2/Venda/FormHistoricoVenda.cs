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
    public partial class FormHistoricoVenda : Form
    {
        ClienteDAO cliente = new ClienteDAO();
        VendaDAO venda = new VendaDAO();
        List<Cliente> c = new List<Cliente>();
        List<Venda> v = new List<Venda>();

        public FormHistoricoVenda()
        {
            InitializeComponent();
            txtTelefone.Enabled = false;
            txtNome.Enabled = false;
            tbRG.Enabled = false;
            txtEmail.Enabled = false;
            txtEcivil.Enabled = false;

            v = venda.ListAll();
        }


        
        private void AtualizaDGV()
        {
            
            
            v = venda.ListAll();
            dgvPesquisar.Rows.Clear();
            foreach (Venda ve in v)
            {
                foreach(Cliente cl in c)
                {
                if(ve.Cliente.Id == cl.Id)
                dgvPesquisar.Rows.Add(ve.Id, ve.Cliente.Nome, ve.Carro.Nome, ve.Vendedor.Nome);
                if (ve.Cliente.Nome == "")
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
            v = venda.ListByCliente(nome);
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
            c = cliente.ListAll();

            foreach (Cliente cli in c)
            {
                if (txtCpf.Text == cli.Cpf)
                    key = cli.Id;
            }
            if (key != 0)
            {
                foreach(Venda ve in v)
                 if (ve.Cliente.Id == key)
                  {
                    txtEcivil.Text = ve.Cliente.Ecivil;
                    txtEmail.Text = ve.Cliente.Email;
                    tbRG.Text = ve.Cliente.Rg;
                    txtNome.Text = ve.Cliente.Nome;
                    txtTelefone.Text = ve.Cliente.Telefone;
                    AtualizaDGVFiltrado(ve.Cliente.Nome);
                }
            }
            else
            {
                txtEcivil.Text = "";
                txtEmail.Text = "";
                txtNome.Text = "";
                txtRg.Text = "";
                txtTelefone.Text = "";
            }

            
            
        }



    }
}
