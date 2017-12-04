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
    public partial class Programa : Form
    {
        private FormCliente formcliente;
        private FormGerenciaCarros formAdmCarros;
        //private FormOrcamento formOrcamento;
        private FormVenda formVenda;
        private FormHistoricoVenda formHistorico;
        private FormHistoricoCarros formHistoricoCarros;
        private FormFuncionarios formFuncionarios;
        private FormHistoricoVendedor formHistoricoVend;
        private bool admin = false;
       
       
        
        public Programa()
        {
            InitializeComponent();
            if (admin == false)
                btFuncionario.Visible = false;
        }

        public Programa(bool funcao)
        {
            InitializeComponent();
            admin = funcao;

            if(funcao == false)
            {
                btFuncionario.Visible = false;
            }


        }

        public void Change()
        {
            if(formcliente != null)
             formcliente.Dispose();

            if (formAdmCarros != null)
                formAdmCarros.Dispose();
            

            if (formVenda != null)
                formVenda.Dispose();

            if (formHistorico != null)
                formHistorico.Dispose();

            if (formHistoricoCarros != null)
                formHistoricoCarros.Dispose();

            if (formFuncionarios != null)
                formFuncionarios.Dispose();

            if (formHistoricoVend != null)
                formHistoricoVend.Dispose();
            

        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            Change();
            if (formcliente == null) { 
            formcliente = new FormCliente();
            formcliente.MdiParent = this;
            }
            formcliente.WindowState = FormWindowState.Maximized;
            formcliente.Show();
            formcliente.Activate();
        }

        private void Programa_Load(object sender, EventArgs e)
        {

        }
        
        

        private void btCliente_Click(object sender, EventArgs e)
        {
            Change();
            
                formcliente = new FormCliente();
                formcliente.TopLevel = false;
                //formcliente.Parent = pPrincipal;
            pPrincipal.Controls.Add(formcliente);
            formcliente.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formcliente.Dock = DockStyle.Fill;
           // formcliente.MdiParent = this;
            //formcliente.WindowState = FormWindowState.Maximized;
            formcliente.Show();
            
        }
        

        private void btCarros_Click(object sender, EventArgs e)
        {
            if(admin == true)
            {
                FormMenuCarros form = new FormMenuCarros();
                form.ShowDialog();
                if (form.Opc == 1)
                {
                        Change();
                        formAdmCarros = new FormGerenciaCarros();
                        formAdmCarros.TopLevel = false;
                        formAdmCarros.Parent = pPrincipal;
                         formAdmCarros.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        formAdmCarros.Dock = DockStyle.Fill;
                        formAdmCarros.TopMost = true;
                        formAdmCarros.Activate();
                        formAdmCarros.Show();
                }
                if(form.Opc == 0)
                {
                    FormVendaCarro formOrcamento = new FormVendaCarro(true);
                    formOrcamento.Show();
                }
                
               
            }
            else
            {

                FormVendaCarro formOrcamento = new FormVendaCarro();
                formOrcamento.Show();
                
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btVenda_Click(object sender, EventArgs e)
        {

            Change();

            formVenda = new FormVenda();
            formVenda.TopLevel = false;
            pPrincipal.Controls.Add(formVenda);
            formVenda.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formVenda.Dock = DockStyle.Fill;
            formVenda.Show();



        }

        private void btHistoricos_Click(object sender, EventArgs e)
        {
            FormMenuPesquisas form = new FormMenuPesquisas();
            form.ShowDialog();
            if(form.Opc == 1)
            {
                Change();
                if (formHistorico == null)
                {
                    formHistorico = new FormHistoricoVenda();
                    formHistorico.TopLevel = false;
                    pPrincipal.Controls.Add(formHistorico);
                    formHistorico.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    formHistorico.Dock = DockStyle.Fill;
                }
              
                formHistorico.Show();
            }

            if(form.Opc == 2)
            {
                Change();
                if (formHistoricoCarros == null)
                {
                    formHistoricoCarros = new FormHistoricoCarros();
                    formHistoricoCarros.TopLevel = false;
                    pPrincipal.Controls.Add(formHistoricoCarros);
                    formHistoricoCarros.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    formHistoricoCarros.Dock = DockStyle.Fill;
                }

                formHistoricoCarros.Show();
            }

            if (form.Opc == 3)
            {
                Change();
                if (formHistoricoVend == null)
                {
                    formHistoricoVend = new FormHistoricoVendedor();
                    formHistoricoVend.TopLevel = false;
                    pPrincipal.Controls.Add(formHistoricoVend);
                    formHistoricoVend.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    formHistoricoVend.Dock = DockStyle.Fill;
                }

                formHistoricoVend.Show();
            }


        }

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            Change();
                formFuncionarios = new FormFuncionarios();
                formFuncionarios.TopLevel = false;
                pPrincipal.Controls.Add(formFuncionarios);
                formFuncionarios.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formFuncionarios.Dock = DockStyle.Fill;
            

            formFuncionarios.Show();
        }
    }
}
