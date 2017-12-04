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
    public partial class FormFuncionarios : Form
    {
        FuncionarioDAO funcionario = new FuncionarioDAO();


        public FormFuncionarios()
        {
            InitializeComponent();
            AtualizaDGV();
        }


        private void AtualizaDGV()
        {
            List<Funcionario> func = new List<Funcionario>();
            func = funcionario.ListAll();
            dgvPesquisar.Rows.Clear();
            foreach (Funcionario c in func)
            {
                if (c.Removido == 0)
                {
                    dgvPesquisar.Rows.Add(c.Id, c.Nome, c.Telefone);
                }
                if (c.Nome == "")
                {
                    funcionario.DeleteNull(c.Id);
                    AtualizaDGV();
                }
            }
            dgvPesquisar.Refresh();

        }




        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEditar_Click(object sender, EventArgs e)
        {

            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                FormAddFuncionariocs form = new FormAddFuncionariocs(funcionario.Read(key), true);
                form.ShowDialog(this);
                if (form.Erro == true)
                    MessageBox.Show("Ocorreu um erro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    funcionario.Update(form.F);
                }
                AtualizaDGV();
            }
            else
                MessageBox.Show("Selecione uma linha para editar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FormAddFuncionariocs form = new FormAddFuncionariocs();
            List<Funcionario> cli = new List<Funcionario>();
            cli = funcionario.ListAll();
            form.ShowDialog();

            if (form.Erro == false)
            {
                if (form.F.Nome != null)
                    funcionario.Create(form.F);
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
                FormAddFuncionariocs form = new FormAddFuncionariocs(funcionario.Read(key), false);
                form.ShowDialog(this);
            }
            else
                MessageBox.Show("Selecione uma linha para visualizar!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void txtFiltrar_TextChanged_1(object sender, EventArgs e)
        {
            List<Funcionario> f = new List<Funcionario>();
            f = funcionario.ListByName(txtFiltrar.Text);
            dgvPesquisar.Rows.Clear();

            foreach (Funcionario fFilt in f)
                if (fFilt.Removido == 0)
                    dgvPesquisar.Rows.Add(fFilt.Id, fFilt.Nome, fFilt.Telefone);
        }

        private void btRelatVendas_Click(object sender, EventArgs e)
        {
            List<Funcionario> f = new List<Funcionario>();
            f = funcionario.ListAll();
            foreach (Funcionario fun in f)
                fun.SalarioFinal = 0;
 

            VendaDAO venda = new VendaDAO();
            List<Venda> v = new List<Venda>();
            v = venda.ListAll();

            foreach (Venda ve in v)
            {
                foreach (Funcionario fun in f)
                    if (ve.Vendedor.Id == fun.Id)
                        fun.SalarioFinal++;

            }
       
            
            FormReportVendedor form = new FormReportVendedor(f);
            form.Show();

            Dispose();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.CurrentRow != null)
            {
                int key = int.Parse(dgvPesquisar.CurrentRow.Cells[0].Value.ToString());
                funcionario.Delete(key);
                AtualizaDGV();
            }
            else
                MessageBox.Show("Selecione uma linha para remover!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
