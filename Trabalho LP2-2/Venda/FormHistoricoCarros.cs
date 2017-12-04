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
    public partial class FormHistoricoCarros : Form
    {
        CarroDAO dbcarros = new CarroDAO();
        VendaDAO venda = new VendaDAO();
        Carro carro = new Carro();
        List<Cliente> c = new List<Cliente>();


        public FormHistoricoCarros()
        {
            InitializeComponent();

            List<Carro> lc = new List<Carro>();
            lc = dbcarros.ListAll();


            cbNome.DataSource = lc;
            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "Id";

            cbNome.SelectedIndex = -1;
            

        }


        private void AtualizaDGV()
        {
            
            List<Venda> v = new List<Venda>();
            v = venda.ListAll();
            dgvPesquisar.Rows.Clear();
            foreach (Venda ve in v)
            {
                foreach (Cliente cl in c)
                {
                    if (ve.Cliente.Id == cl.Id)
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
            v = venda.ListByCarro(nome);
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

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPesquisar.Rows.Clear();

            if (cbNome.Text != "")
            {
                AtualizaDGVFiltrado(cbNome.Text);
                
                List<Carro> lc = new List<Carro>();
                foreach (Carro c in lc)
                    if (c.Id == int.Parse("" + cbNome.SelectedValue))
                        carro = c;
                        
                carro = cbNome.SelectedItem as Carro;
            }

          

        }
        
    }
}
