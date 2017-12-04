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
    public partial class FormOrcamento : Form
    {
        bool venda = false;
        CarrosDAO dbcarros = new CarrosDAO();
        Carros carro = new Carros();
        double preco, juros;
        bool tetoSolar, multimidia, ligaLeve, calcJuros;
        int nParcelas;
        bool editMode = false;
        


        public FormOrcamento()
        {
            InitializeComponent();


            List<Carros> lc = new List<Carros>();
            lc = Dbcarros.ListAll();
            

            cbNome.DataSource = lc;
            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "cod";
            

            cbNome.SelectedIndex = -1;
            cbMotor.SelectedIndex = -1;
            cbOpcionais.SelectedIndex = -1;


                cbMotor.Enabled = false;
                cbOpcionais.Enabled = false;
                txtJuros.Enabled = false;
                txtParcelas.Enabled = false;
                btnAdicionar.Enabled = false;
                btnRemover.Enabled = false;
                txtValor.Enabled = false;
                btnCalcular.Enabled = false;
                CalcJuros = false;

        }

        public FormOrcamento(bool Venda)
        {
            this.Venda = Venda;
            InitializeComponent();

            if (Venda == true)
            {
                this.Text = "Carros a venda";
                btnGerar.Text = "Escolher";
                btnGerar.Click -= new System.EventHandler(this.btnGerar_Click);
                btnGerar.Click += new System.EventHandler(this.btnSalvar_Click);

                List<Carros> lc = new List<Carros>();
                lc = Dbcarros.ListAll();


                cbNome.DataSource = lc;
                cbNome.DisplayMember = "Nome";
                cbNome.ValueMember = "cod";


                cbNome.SelectedIndex = -1;
                cbMotor.SelectedIndex = -1;
                cbOpcionais.SelectedIndex = -1;


                cbMotor.Enabled = false;
                cbOpcionais.Enabled = false;
                txtJuros.Enabled = false;
                txtParcelas.Enabled = false;
                btnAdicionar.Enabled = false;
                btnRemover.Enabled = false;
                txtValor.Enabled = false;
                btnCalcular.Enabled = false;
                CalcJuros = false;
            }


        }

        public FormOrcamento(Vendas v, bool Venda, bool edit)
        {
            this.Venda = Venda;
            InitializeComponent();
            this.Text = "Carros a venda";
            btnGerar.Text = "Salvar";
            btnGerar.Click -= new System.EventHandler(this.btnGerar_Click);
            btnGerar.Click += new System.EventHandler(this.btnSalvar_Click);

            List<Carros> lc = new List<Carros>();
            lc = Dbcarros.ListAll();
            cbNome.DataSource = lc;
            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "cod";

            editMode = edit;
            cbNome.Text = v.Carro.Nome;
            if (v.Carro.MotorTexto == "1.0")
                cbMotor.Text = "1.0";
            if (v.Carro.MotorTexto == "1.0 TURBO")
                cbMotor.Text = "1.0 TURBO";
            if (v.Carro.MotorTexto == "1.3")
                cbMotor.Text = "1.3";
            if (v.Carro.MotorTexto == "1.6")
                cbMotor.Text = "1.6";
            if (v.Carro.MotorTexto == "2.0")
                cbMotor.Text = "2.0";
            if (v.Carro.MotorTexto == "2.0 TURBO")
                cbMotor.Text = "2.0 TURBO";

            if (v.Carro.TetoSolar == true)
                tetoSolar = true;
            if (v.Carro.LigaLeve == true)
                ligaLeve = true;
            if (v.Carro.Multimidia == true)
                multimidia = true;

            txtJuros.Text = "" + v.Juros;
            txtParcelas.Text = "" + v.NParcelas;
            txtValor.Text = "" + v.PrecoFinal;
            txtValor.Enabled = false;


            if (editMode == false)
            {
                btnCancelar.Text = "Fechar";
                cbMotor.Enabled = false;
                cbOpcionais.Enabled = false;
                txtJuros.Enabled = false;
                txtParcelas.Enabled = false;
                btnAdicionar.Enabled = false;
                btnRemover.Enabled = false;
                txtValor.Enabled = false;
                btnCalcular.Enabled = false;
                btnGerar.Visible = false;
                cbNome.Enabled = false;
            }
            
        }

        

        private void FormOrcamento_Load(object sender, EventArgs e)
        {
        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

   

        private void btnGerar_Click(object sender, EventArgs e)
        {

        }

        private void cbOpcionais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcionais.Text != "")
                btnAdicionar.Enabled = true;


        }

        private void txtParcelas_TextChanged(object sender, EventArgs e)
        {
            if(txtParcelas.Text != "")
            {
                txtJuros.Enabled = true;
                btnCalcular.Enabled = true;
                NParcelas = int.Parse(txtParcelas.Text);
            }
            else
            {
                txtJuros.Enabled = false;
                btnCalcular.Enabled = false;
                NParcelas = 0;
            }
        }

        
        private void txtJuros_TextChanged(object sender, EventArgs e)
        {
            //Juros = double.Parse(txtJuros.Text);
        }
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Juros = double.Parse(txtJuros.Text);
            if (CalcJuros == false)
            {
                Juros /= 100;
                Preco = Preco + Preco * (Juros * NParcelas);
                txtValor.Text = "" + Preco;
            }
            else
                MessageBox.Show("Calcule apenas uma vez!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            CalcJuros = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(cbMotor.Text != "")
            {
                if(cbOpcionais.Text != "")
                {

                    if(cbOpcionais.Text == "Rodas de Liga leve")
                    { 
                        if(LigaLeve == false)
                        {
                            LigaLeve = true;
                            Preco += Carro.PAdicional;
                            MessageBox.Show("Rodas de liga leve adicionadas!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Voce so pode adicionar os opcionais uma vez!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    if (cbOpcionais.Text == "Teto solar")
                    {
                        if (TetoSolar == false)
                        {
                            TetoSolar = true;
                            Preco += Carro.PAdicional;
                            MessageBox.Show("Teto Solar adicionado!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Voce so pode adicionar os opcionais uma vez!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    if (cbOpcionais.Text == "Central multimidia")
                    {
                        if (Multimidia == false)
                        {
                            Multimidia = true;
                            Preco += Carro.PAdicional;
                            MessageBox.Show("Central multimidia adicionada!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Voce so pode adicionar os opcionais uma vez!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                  MessageBox.Show("Escolha um adicional!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Escolha o motor primeiro!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Error);


            txtValor.Text = "" + Preco;
        }



        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cbMotor.Text != "")
            {
                if (cbOpcionais.Text != "")
                {

                    if (cbOpcionais.Text == "Rodas de Liga leve")
                    {
                        if (LigaLeve == true)
                        {
                            LigaLeve = false;
                            Preco -= Carro.PAdicional;
                            MessageBox.Show("Rodas de liga leve removidas!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Rodas de liga leve já estavam removidas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    if (cbOpcionais.Text == "Teto solar")
                    {
                        if (TetoSolar == true)
                        {
                            TetoSolar = false;
                            Preco -= Carro.PAdicional;
                            MessageBox.Show("Teto Solar removido!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Teto solar já estava removido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    if (cbOpcionais.Text == "Central multimidia")
                    {
                        if (Multimidia == true)
                        {
                            Multimidia = false;
                            Preco -= Carro.PAdicional;
                            MessageBox.Show("Central multimidia removida!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Central multimidia já estava removida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                    MessageBox.Show("Escolha um adicional!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Escolha o motor primeiro!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Error);


            txtValor.Text = "" + Preco;


        }


        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preco = 0;
            cbOpcionais.Items.Clear();
            cbOpcionais.ResetText();
            cbMotor.Items.Clear();
            cbMotor.ResetText();
            txtJuros.Text = "";
            txtParcelas.Text = "";

            if(cbNome.Text != "")
            {
                cbMotor.Enabled = true;
                cbOpcionais.Enabled = true;
                txtParcelas.Enabled = true;
                List<Carros> lc = new List<Carros>();
                foreach (Carros c in lc)
                    if (c.Cod == int.Parse("" + cbNome.SelectedValue))
                        Carro = c;


                Carro = cbNome.SelectedItem as Carros;

                //opcionais
                if (Carro.LigaLeve == true)
                    cbOpcionais.Items.Add("Rodas de Liga leve");
                if (Carro.Multimidia == true)
                    cbOpcionais.Items.Add("Central multimidia");
                if (Carro.TetoSolar == true)
                    cbOpcionais.Items.Add("Teto solar");

                //motores
                if (Carro.Motor.M10 == true)
                    cbMotor.Items.Add("1.0");
                if (Carro.Motor.M10t == true)
                    cbMotor.Items.Add("1.0 TURBO");
                if (Carro.Motor.M13 == true)
                    cbMotor.Items.Add("1.3");
                if (Carro.Motor.M16 == true)
                    cbMotor.Items.Add("1.6");
                if (Carro.Motor.M20 == true)
                    cbMotor.Items.Add("2.0");
                if (Carro.Motor.M20t == true)
                    cbMotor.Items.Add("2.0 TURBO");

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            carro.Nome = cbNome.Text;
            carro.MotorTexto = cbMotor.Text;
            carro.PrecoTotal = Preco;
            carro.Multimidia = Multimidia;
            carro.TetoSolar = TetoSolar;
            carro.LigaLeve = LigaLeve;
            Dispose();
        }



   

        private void cbMotor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Multimidia == true || LigaLeve == true || TetoSolar == true)
                MessageBox.Show("Opcionais zerados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Preco = 0;
            Multimidia = false;
            LigaLeve = false;
            TetoSolar = false;

            if ("" + cbMotor.Text == "1.0")
                Preco = Carro.Motor.P10;
            
            if ("" + cbMotor.Text == "1.0 TURBO")
                Preco = Carro.Motor.P10t;

            if ("" + cbMotor.Text == "1.3")
                Preco = Carro.Motor.P13;

            if ("" + cbMotor.Text == "1.6")
                Preco = Carro.Motor.P16;

            if ("" + cbMotor.Text == "2.0")
                Preco = Carro.Motor.P20;

            if ("" + cbMotor.Text == "2.0 TURBO")
                Preco = Carro.Motor.P20t;

            txtValor.Text = "" + Preco;
        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool Venda
        {
            get
            {
                return Venda1;
            }

            set
            {
                Venda1 = value;
            }
        }

        public bool Venda1
        {
            get
            {
                return venda;
            }

            set
            {
                venda = value;
            }
        }

        public CarrosDAO Dbcarros
        {
            get
            {
                return dbcarros;
            }

            set
            {
                dbcarros = value;
            }
        }

        public Carros Carro
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

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        public double Juros
        {
            get
            {
                return juros;
            }

            set
            {
                juros = value;
            }
        }

        public bool TetoSolar
        {
            get
            {
                return tetoSolar;
            }

            set
            {
                tetoSolar = value;
            }
        }

       

        public bool Multimidia
        {
            get
            {
                return multimidia;
            }

            set
            {
                multimidia = value;
            }
        }

        public bool LigaLeve
        {
            get
            {
                return ligaLeve;
            }

            set
            {
                ligaLeve = value;
            }
        }

        public bool CalcJuros
        {
            get
            {
                return calcJuros;
            }

            set
            {
                calcJuros = value;
            }
        }

        public int NParcelas
        {
            get
            {
                return nParcelas;
            }

            set
            {
                nParcelas = value;
            }
        }


    }
}
