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
    public partial class FormGerenciaCarros : Form
    {
        private CarroDAO dbcarros = new CarroDAO();

        public FormGerenciaCarros()
        {
            InitializeComponent();
            AtualizaDGV();
        }


        private void AtualizaDGV()
        {
            List<Carro> ca = new List<Carro>();
            ca = dbcarros.ListAll();
            dgvGerCarros.Rows.Clear();
            foreach (Carro c in ca)
            {
                if(c.Removido == 0)
                dgvGerCarros.Rows.Add(c.Id, c.Nome, c.Modelo);
                if (c.Nome == "")
                {
                    dbcarros.DeleteNull(c.Id);
                    AtualizaDGV();
                }
            }
            dgvGerCarros.Refresh();

        }
        

        /*
        private List<Carros> ListarFiltro(string texto)
        {
            List<Carros> carroFiltrado = new List<Carros>();
            List<Carros> ca = new List<Carros>();
            ca = dbcarros.ListAll();
            
            foreach (Carros c in ca)
            {
                string aux = "" + c.Cod;
                if (aux.Contains(texto) || c.Nome.Contains(texto) || c.Modelo.Contains(texto))
                    carroFiltrado.Add(c);
            }

            return carroFiltrado;
        }
        */
        

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            List<Carro> ca = new List<Carro>();
            FormAddCarro form = new FormAddCarro();
            ca = dbcarros.ListAll();
            form.ShowDialog();
            if (form.ValidaCampo)
               dbcarros.Create(form.Carro);
            else
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            AtualizaDGV();
        }

        


        private void btVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvGerCarros.CurrentRow != null)
            {
                int key = int.Parse(dgvGerCarros.CurrentRow.Cells[0].Value.ToString());
                FormAddCarro form = new FormAddCarro(dbcarros.Read(key), false);
                form.ShowDialog(this);
            }
            else
                MessageBox.Show("Selecione uma linha para visualizar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void btEditar_Click(object sender, EventArgs e)
        {

            if (dgvGerCarros.CurrentRow != null)
            {
                int key = int.Parse(dgvGerCarros.CurrentRow.Cells[0].Value.ToString());
                FormAddCarro form = new FormAddCarro(dbcarros.Read(key), true);
                Carro c = new Carro();
                form.ShowDialog(this);
                if (form.ValidaCampo == false)
                    MessageBox.Show("Ocorreu um erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    dbcarros.Update(form.Carro);
                }
                AtualizaDGV();
            }
            else
                MessageBox.Show("Selecione uma linha para editar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvGerCarros.CurrentRow != null)
            {
                int key = int.Parse(dgvGerCarros.CurrentRow.Cells[0].Value.ToString());
                dbcarros.Delete(key);
                AtualizaDGV();
            }
            else
                MessageBox.Show("Selecione uma linha para remover!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            
            List<Carro> c = new List<Carro>();
            c = dbcarros.ListByName(txtFiltrar.Text);
            dgvGerCarros.Rows.Clear();

            foreach (Carro cFilt in c)
                if(cFilt.Removido == 0)
                dgvGerCarros.Rows.Add(cFilt.Id, cFilt.Nome, cFilt.Modelo);

        }

        private void FormGerenciaCarros_Load(object sender, EventArgs e)
        {

        }
    }
}
