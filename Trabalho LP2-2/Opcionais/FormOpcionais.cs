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
    
    public partial class FormOpcionais : Form
    {
        private OpcionalDAO opcional = new OpcionalDAO();
        public Opcional Op = new Opcional();
        public List<Opcional> Lo = new List<Opcional>();
        private bool modoSelecao;


        public FormOpcionais()
        {
            InitializeComponent();
            AtualizaDGV();
            btViewMode.Visible = false;
            btAdicionar.Visible = true;
        }

        public FormOpcionais(List<Opcional> opcionais, bool edit)
        {

            
            InitializeComponent();
            Lo = opcionais;

            if (edit == true)
            {
                btAdicionar.Visible = true;
                btViewMode.Visible = false;

            }
            else
            {
                btAdicionar.Visible = false;
                btEditar.Visible = false;
                btRemover.Visible = false;
                btEscolher.Visible = false;
                btRetira.Visible = false;
                btVisualizar.Visible = false;
                dgvPesquisar.Enabled = false;

            }

            modoSelecao = true;
            AtualizaDGV();
            AtualizaAdicionados();


        }



        private void AtualizaDGV()
        {
            List<Opcional> op = new List<Opcional>();
            op = opcional.ListAll();
            dgvPesquisar.Rows.Clear();
            foreach (Opcional o in op)
            {
                if (o.Removido == 0)
                    dgvPesquisar.Rows.Add(o.Id, o.Nome, o.Preco);
                if (o.Nome == "")
                {
                    opcional.DeleteNull(o.Id);
                    AtualizaDGV();
                }
            }
            dgvPesquisar.Refresh();

        }

        private void AtualizaAdicionados()
        {

            dgvAdicionados.Rows.Clear();
            
            foreach (Opcional o in Lo)
            {
                dgvAdicionados.Rows.Add(o.Id, o.Nome, o.Preco);
                if (o.Nome == "")
                {
                    opcional.Delete(o.Id);
                    AtualizaAdicionados();
                }
            }

            dgvAdicionados.Refresh();

        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FormAddOpcionais form = new FormAddOpcionais();
            form.ShowDialog();
            opcional.Create(form.Op);
            AtualizaDGV();
        }

        private void btEscolher_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                Op = opcional.Read(key);
                foreach (Opcional o in Lo)
                    if (Op.Id == o.Id)
                        found = true;
                if (found == true)
                    MessageBox.Show("Este opcional ja está adicionado!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    Lo.Add(Op);
            }
            else
                MessageBox.Show("Selecione uma linha para visualizar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            AtualizaAdicionados();
        }

        private void FormOpcionais_Load(object sender, EventArgs e)
        {

        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                FormAddOpcionais form = new FormAddOpcionais(opcional.Read(key), false);
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
                FormAddOpcionais form = new FormAddOpcionais(opcional.Read(key), true);
                form.ShowDialog(this);
                opcional.Update(form.Op);
                AtualizaDGV();
            }
            else
                MessageBox.Show("Selecione uma linha para editar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            
        }

        private void btRetira_Click(object sender, EventArgs e)
        {
            List<Opcional> auxOpc = new List<Opcional>();
            if (dgvAdicionados.CurrentRow != null)
            {
                //LIST.REMOVE() NAO FUNCIONA!  ???
                int key = int.Parse(dgvAdicionados.CurrentRow.Cells[0].Value.ToString());
                Op = opcional.Read(key);
                Lo.Remove(Op);

                foreach (Opcional o in Lo)
                    if (o.Id != Op.Id)
                        auxOpc.Add(o);

                Lo = auxOpc;

            }
            else
                MessageBox.Show("Voce deve selecionar um opcional para retirar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            AtualizaAdicionados();
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btViewMode_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvAdicionados.CurrentRow.Cells[0].Value.ToString());
                FormAddOpcionais form = new FormAddOpcionais(opcional.Read(key), false);
                form.ShowDialog(this);
            }
            else
                MessageBox.Show("Selecione uma linha para visualizar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                opcional.Delete(key);
                AtualizaDGV();
            }
            else
                MessageBox.Show("Selecione uma linha para remover!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Opcional> o = new List<Opcional>();
            o = opcional.ListByName(txtFiltrar.Text);
            dgvPesquisar.Rows.Clear();

            foreach (Opcional oFilt in o)
                if(oFilt.Removido == 0)
                dgvPesquisar.Rows.Add(oFilt.Id, oFilt.Nome, oFilt.Preco);
        }
    }
}
