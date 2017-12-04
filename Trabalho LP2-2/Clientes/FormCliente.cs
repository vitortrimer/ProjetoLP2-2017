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
    public partial class FormCliente : Form
    {
        private ClienteDAO cliente = new ClienteDAO();

       

        public FormCliente()
        {
            InitializeComponent();
            AtualizaDGV();
        }




        private void AtualizaDGV()
        {
            List<Cliente> cli = new List<Cliente>(); 
            cli = cliente.ListAll();
            dgvPesquisar.Rows.Clear();
            foreach (Cliente c in cli) { 
                if(c.Removido == 0) { 
                dgvPesquisar.Rows.Add(c.Id, c.Nome, c.Telefone);
                }
                if (c.Nome == "") { 
                    cliente.DeleteNull(c.Id);
                    AtualizaDGV();
                }
            }
            dgvPesquisar.Refresh();
            
        }
        

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FormAddCliente form = new FormAddCliente();
            List<Cliente> cli = new List<Cliente>();
            cli = cliente.ListAll();
            form.ShowDialog();

            if(form.Erro == false) {
                if (form.Salva.Nome != null) 
                cliente.Create(form.Salva);
                AtualizaDGV();
                }

            else if (form.Erro == true)
                MessageBox.Show("Ocorreu um erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void btVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                FormAddCliente form = new FormAddCliente(cliente.Read(key), false);
                form.ShowDialog(this);
            }
            else
                MessageBox.Show("Selecione uma linha para visualizar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }
    


        private void btEditar_Click(object sender, EventArgs e)
        {

            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                FormAddCliente form = new FormAddCliente(cliente.Read(key), true);
                form.ShowDialog(this);
                if (form.Erro == true)
                    MessageBox.Show("Ocorreu um erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else {
                    cliente.Update(form.Salva);
                }
                AtualizaDGV();
            }
            else
                MessageBox.Show("Selecione uma linha para editar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }




        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                cliente.Delete(key);
                AtualizaDGV();
            }
            else
                MessageBox.Show("Selecione uma linha para remover!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        
        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            List<Cliente> c = new List<Cliente>();
            c = cliente.ListByName(txtFiltrar.Text);
            dgvPesquisar.Rows.Clear();

            foreach (Cliente cFilt in c)
                if(cFilt.Removido == 0)
                dgvPesquisar.Rows.Add(cFilt.Id, cFilt.Nome, cFilt.Telefone);
            
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
