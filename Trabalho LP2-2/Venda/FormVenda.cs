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
    public partial class FormVenda : Form
    {
        VendaDAO venda = new VendaDAO();

        public FormVenda()
        {
            InitializeComponent();
            AtualizaDGV();
        }



        private void AtualizaDGV()
        {
            List<Venda> v = new List<Venda>();
            v = venda.ListAll();
            dgvPesquisar.Rows.Clear();
            foreach (Venda ve in v)
            {
                dgvPesquisar.Rows.Add(ve.Id, ve.Carro.Nome, ve.Cliente.Nome, ve.Vendedor.Nome);
                if (ve.DataVenda == null)
                {
                    venda.Delete(ve.Id);
                    AtualizaDGV();
                }
            }
            dgvPesquisar.Refresh();


           
        }




        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Venda> v = new List<Venda>();
            v = venda.ListByCliente(txtFiltrar.Text);
            dgvPesquisar.Rows.Clear();

            foreach (Venda ve in v)
                dgvPesquisar.Rows.Add(ve.Id, ve.Carro.Nome, ve.Cliente.Nome, ve.Vendedor.Nome);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FormAddVenda form = new FormAddVenda();
            form.ShowDialog();
            if(form.Erro == false) {
            venda.Create(form.V);
            AtualizaDGV();
            }
        }

        private void btVisualizar_Click(object sender, EventArgs e)
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

        /*
        private void btEditar_Click(object sender, EventArgs e)
        {
            
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
               // FormAddVenda form = new FormAddVenda(venda.Read(key), true);
              //  form.ShowDialog(this);
                if (form.Erro == true)
                    MessageBox.Show("Ocorreu um erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //venda.Update(form.V);
                }
                AtualizaDGV();
            }
            else
                MessageBox.Show("Selecione uma linha para editar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
    }
    */
    
      
        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                venda.Delete(key);
                AtualizaDGV();
            }
            else
                MessageBox.Show("Selecione uma linha para remover!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
