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
    public partial class FormMotor : Form
    {
        private MotorDAO motor = new MotorDAO();
        public Motor M = new Motor();
         bool modoSelecao;
        private List<Motor> listamot = new List<Motor>();
        private List<Motor> auxDgv = new List<Motor>();

        public List<Motor> AuxDgv
        {
            get
            {
                return auxDgv;
            }

            set
            {
                auxDgv = value;
            }
        }

        public FormMotor()
        {
            InitializeComponent();
            AtualizaDGV();
            btViewMode.Visible = false;
            btAdicionar.Visible = true;
        }

        public FormMotor(List<Motor> motor, bool edit)
        {

          
            InitializeComponent();
            listamot = motor;
            AuxDgv = motor;
            
            if (edit == true)
            {
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
                List<Motor> mt = new List<Motor>();
                mt = motor.ListAll();
            dgvPesquisar.Rows.Clear();

            foreach (Motor m in mt)
            {
                if (m.Removido == 0)
                    dgvPesquisar.Rows.Add(m.Id, m.Nome, m.PrecoBase, m.Cavalos);
                    
            
                if (m.Nome == "")
                {
                    motor.DeleteNull(m.Id);
                    AtualizaDGV();
                }
                
             }
            
            dgvPesquisar.Refresh();

        }

        private void AtualizaAdicionados()
        {
           
            dgvAdicionados.Rows.Clear();

            foreach (Motor m in AuxDgv)
            {
                    dgvAdicionados.Rows.Add(m.Id, m.Nome, m.PrecoBase, m.Cavalos);


                if (m.Nome == "")
                {
                    motor.DeleteNull(m.Id);
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
            FormGerenciaMotor form = new FormGerenciaMotor();
            form.ShowDialog();
            motor.Create(form.M);
            AtualizaDGV();

        }

        private void btEscolher_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                M = motor.Read(key);
                foreach (Motor percmot in AuxDgv)
                    if (percmot.Id == M.Id)
                        found = true;
                if (found == true)
                    MessageBox.Show("Este motor ja está adicionado!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    AuxDgv.Add(M);
                
            }
            else
                MessageBox.Show("Voce deve selecionar uma linha para adicionar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            AtualizaAdicionados();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                motor.Delete(key);
                AtualizaDGV();
            }
            else
                MessageBox.Show("Selecione uma linha para remover!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                FormGerenciaMotor form = new FormGerenciaMotor(motor.Read(key), false);
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
                FormGerenciaMotor form = new FormGerenciaMotor(motor.Read(key), true);
                form.ShowDialog(this);
                motor.Update(form.M);
            }
            else
                MessageBox.Show("Selecione uma linha para Editar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            AtualizaDGV();

        }

        private void btRetira_Click(object sender, EventArgs e)
        {
            List<Motor> outraAuxDgv = new List<Motor>();
            if (dgvAdicionados.CurrentRow != null)
            {
                //LIST.REMOVE() NAO FUNCIONA!  ???
                int key = int.Parse(dgvAdicionados.CurrentRow.Cells[0].Value.ToString());
                M = motor.Read(key);
                AuxDgv.Remove(M);

                foreach (Motor mt in AuxDgv)
                    if (mt.Id != M.Id)
                        outraAuxDgv.Add(mt);

                AuxDgv = outraAuxDgv;

            }
            else
                MessageBox.Show("Voce deve selecionar uma linha para remover!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            AtualizaAdicionados();
        }

        private void btViewMode_Click(object sender, EventArgs e)
        {
            if (dgvAdicionados.CurrentRow != null)
            {
                int key = int.Parse(dgvAdicionados.CurrentRow.Cells[0].Value.ToString());
                FormGerenciaMotor form = new FormGerenciaMotor(motor.Read(key), false);
                form.ShowDialog(this);
            }
            else
                MessageBox.Show("Selecione uma linha para visualizar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Motor> m = new List<Motor>();
            m = motor.ListByName(txtFiltrar.Text);
            dgvPesquisar.Rows.Clear();

            foreach (Motor mFilt in m)
                if(mFilt.Removido == 0)
                dgvPesquisar.Rows.Add(mFilt.Id, mFilt.Nome, mFilt.PrecoBase, mFilt.Cavalos);
        }
    }
}
