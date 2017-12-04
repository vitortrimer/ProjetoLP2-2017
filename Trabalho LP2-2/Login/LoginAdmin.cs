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
    public partial class LoginAdmin : Form
    {
        private bool valida = false;
        private bool admin = false;
        private bool cancela = false;
        FuncionarioDAO funcionario = new FuncionarioDAO();

        

        public LoginAdmin()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            List<Funcionario> lf = new List<Funcionario>();
            lf = funcionario.ListAll();

            foreach(Funcionario f in lf)
            {
                if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
                {
                    Valida = true;
                    admin = true;
                    Programa programa = new Programa(admin);
                    programa.ShowDialog();
                    break;
                }

                else if (txtLogin.Text == "" + f.Login && txtSenha.Text == "" + f.Senha)
                {
                    Valida = true;
                    admin = false;
                    Programa programa = new Programa(admin);
                    programa.ShowDialog();
                    break;
                }
                
            }
            if(valida == false)
                MessageBox.Show("Usuario ou senha invalido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            Hide();
            
            Show();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Valida = false;
            Cancela = true;
            Dispose();
        }



        public bool Valida
        {
            get
            {
                return valida;
            }

            set
            {
                valida = value;
            }
        }

        public bool Cancela
        {
            get
            {
                return cancela;
            }

            set
            {
                cancela = value;
            }
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "Login";
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
