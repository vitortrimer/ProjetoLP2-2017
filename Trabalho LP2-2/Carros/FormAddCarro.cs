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
    public partial class FormAddCarro : Form
    {
        private Carro carro = new Carro();
        private CarroDAO dbcarros = new CarroDAO();
        private bool validaCampo = true;
        private bool editMode;
        private int verifOpc = 0;

        public FormAddCarro()
        {
            InitializeComponent();
        }

        public FormAddCarro(Carro C, bool edit)
        {
            InitializeComponent();
            btMotor.Click -= new System.EventHandler(this.btMotor_Click);
            btMotor.Click += new System.EventHandler(this.btMotorEdit_Click);
            btOpcionais.Click -= new System.EventHandler(this.btOpcionais_Click);
            btOpcionais.Click += new System.EventHandler(this.btOpcionalEdit_Click);
            txtNome.Text = C.Nome;
            txtModelo.Text = C.Modelo;
            txtPrecoBase.Text = "" + C.PrecoBase;


            editMode = edit;
            if (editMode)
            {
                btLimpar.Visible = false;
            }
            else
            {
                btLimpar.Visible = false;
                btSalvar.Visible = false;
                btCancelar.Text = "Fechar";
                txtNome.Enabled = false;
                txtModelo.Enabled = false;
                txtPrecoBase.Enabled = false;
                
            }

            Carro = C;

        }



        private void btCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
           
            txtModelo.Text = "";
            txtNome.Text = "";
           
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "" || txtNome.Text == "" || txtPrecoBase.Text == "")
                ValidaCampo = false;
            ValidaCampo = Verifica();
            if (ValidaCampo == false)
                Dispose();
            else { 
            Carro.Nome = txtNome.Text;
            Carro.Modelo = txtModelo.Text;
                Carro.PrecoBase = double.Parse(txtPrecoBase.Text);
           
            Dispose();
            }
        }



        private bool Verifica()
        {
            if (txtNome.Text == "" || txtModelo.Text == "")
                return false;
            else return true;
        }




        private void btMotorEdit_Click(object sender, EventArgs e)
        {
            FormMotor form = new FormMotor(Carro.Motor, editMode);
            form.ShowDialog();
            
            
                Carro.Motor = form.AuxDgv;
        }


        private void btMotor_Click(object sender, EventArgs e)
        {
            FormMotor form;
            if (Carro.Motor == null)
              form = new FormMotor();
            else
                form = new FormMotor(Carro.Motor, true);

            form.ShowDialog();
                Carro.Motor = form.AuxDgv;

        }


        private void btOpcionalEdit_Click(object sender, EventArgs e)
        {
            FormOpcionais form = new FormOpcionais(Carro.Opcional, editMode);
            form.ShowDialog();

            if (form.Op.Nome != null)
                Carro.Opcional = form.Lo;
        }

        private void btOpcionais_Click(object sender, EventArgs e)
        {
            FormOpcionais form;
            if (Carro.Opcional == null)
                form = new FormOpcionais();
            else
                form = new FormOpcionais(Carro.Opcional, true);
            form.ShowDialog();

            if (form.Op.Nome != null)
                Carro.Opcional = form.Lo;
        }





        

        public bool ValidaCampo
        {
            get
            {
                return validaCampo;
            }

            set
            {
                validaCampo = value;
            }
        }

        public int VerifOpc
        {
            get
            {
                return verifOpc;
            }

            set
            {
                verifOpc = value;
            }
        }

        public Carro Carro
        {
            get
            {
                return carro;
            }

            set
            {
                carro = value;
            }
        }
    }
}
