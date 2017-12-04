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
    public partial class FormVendaCarro : Form
    {
        CarroDAO carro = new CarroDAO();
        List<Carro> lc = new List<Carro>();
        private Carro c = new Carro();
        public double Preco, Juros;
        public int NParcelas;
        private Carro carroVenda = new Carro();
        private double precoCarro, desconto;
        Venda v = new Venda();
        public bool erro;

     

        public FormVendaCarro()
        {
            InitializeComponent();

            Lc = carro.ListAll();

            cbNome.DataSource = Lc;
            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "Id";
            cbModelo.Text = "";


            cbNome.SelectedIndex = -1;
            cbMotor.SelectedIndex = -1;

            cbModelo.Enabled = false;
            cbMotor.Enabled = false;
            cbOpcionais.Enabled = false;
            txtDesconto.Enabled = false;
            txtJuros.Enabled = false;
            txtParcelas.Enabled = false;
            txtPrecoCarro.Enabled = false;
            txtPrecoTotal.Enabled = false;
            txtRestante.Enabled = false;
            txtEntrada.Enabled = false;
            btnOutraEscolha.Enabled = false;
            btnFinalizaEscolha.Enabled = false;
            btCalcPreco.Enabled = false;
            txtPrecoAPagar.Enabled = false;
            txtValParcela.Enabled = false;

           
        }


        public FormVendaCarro(Venda vend)
        {
            InitializeComponent();

            cbNome.SelectedIndex = -1;
            cbMotor.SelectedIndex = -1;
            cbModelo.Text = "";

            btnFinalizaEscolha.Enabled = false;
            btLimpar.Enabled = false;
            cbNome.Enabled = false;
            cbModelo.Enabled = false;
            cbMotor.Enabled = false;
            cbOpcionais.Enabled = false;
            txtDesconto.Enabled = false;
            txtJuros.Enabled = false;
            txtParcelas.Enabled = false;
            txtPrecoCarro.Enabled = false;
            txtPrecoTotal.Enabled = false;
            txtRestante.Enabled = false;
            txtEntrada.Enabled = false;
            btnOutraEscolha.Enabled = false;
            btnFinalizaEscolha.Enabled = false;
            btCalcPreco.Enabled = false;
            txtPrecoAPagar.Enabled = false;
            txtValParcela.Enabled = false;
            btEscolher.Text = "Fechar";

            
            cbNome.Text = vend.Carro.Nome;
            cbModelo.Text = vend.Carro.Modelo;
            foreach(Motor m in vend.Carro.Motor)
              cbMotor.Text = m.Nome;

            cbOpcionais.DataSource = vend.Carro.Opcional;
            cbOpcionais.DisplayMember = "Nome";
            cbOpcionais.ValueMember = "Id";

            txtDesconto.Text = "" + vend.Desconto;
            txtJuros.Text = "" + vend.Juros;
            txtParcelas.Text = "" + vend.NParcelas;
            txtPrecoCarro.Text = "" + vend.PrecoCarro;
            txtPrecoTotal.Text = "" + vend.PrecoTotal;
            txtRestante.Text = "" + vend.Restante;
            txtEntrada.Text = "" + vend.Entrada;
            txtPrecoAPagar.Text = "" + vend.PrecoAPAgar;
            txtValParcela.Text = "" + vend.ValParcela;


        }

        public FormVendaCarro(bool orcamento)
        {
            InitializeComponent();

            Lc = carro.ListAll();

            cbNome.DataSource = Lc;
            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "Id";

            cbModelo.Text = "";

            btEscolher.Click -= new System.EventHandler(this.btEscolher_Click);
            btEscolher.Click += new System.EventHandler(this.btEscolherOrcamento_Click);

            cbNome.SelectedIndex = -1;
            cbMotor.SelectedIndex = -1;

            cbModelo.Enabled = false;
            cbMotor.Enabled = false;
            cbOpcionais.Enabled = false;
            txtDesconto.Enabled = false;
            txtJuros.Enabled = false;
            txtParcelas.Enabled = false;
            txtPrecoCarro.Enabled = false;
            txtPrecoTotal.Enabled = false;
            txtRestante.Enabled = false;
            txtEntrada.Enabled = false;
            btnOutraEscolha.Enabled = false;
            btnFinalizaEscolha.Enabled = false;
            btCalcPreco.Enabled = false;
            txtPrecoAPagar.Enabled = false;
            txtValParcela.Enabled = false;


        }




        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btEscolher_Click(object sender, EventArgs e)
        {
            v.Juros = double.Parse(txtJuros.Text);
            v.NParcelas = int.Parse(txtParcelas.Text);
            v.PrecoParcela = double.Parse(txtValParcela.Text);
            v.PrecoTotal = double.Parse(txtPrecoTotal.Text);
            v.PrecoCarro = double.Parse(txtPrecoCarro.Text);
            v.Carro = CarroVenda;
            Preco = double.Parse(txtPrecoTotal.Text);
            v.Restante = double.Parse(txtRestante.Text);
            v.ValParcela = double.Parse(txtValParcela.Text);
            v.PrecoAPAgar = double.Parse(txtPrecoAPagar.Text);

            Dispose();
        }

        private void btEscolherOrcamento_Click(object sender, EventArgs e)
        {
            v.Juros = double.Parse(txtJuros.Text);
            v.NParcelas = int.Parse(txtParcelas.Text);
            v.PrecoParcela = double.Parse(txtValParcela.Text);
            v.PrecoTotal = double.Parse(txtPrecoTotal.Text);
            v.PrecoCarro = double.Parse(txtPrecoCarro.Text);
            v.Carro = CarroVenda;
            v.Restante = double.Parse(txtRestante.Text);
            v.ValParcela = double.Parse(txtValParcela.Text);
            v.PrecoAPAgar = double.Parse(txtPrecoAPagar.Text);

            FormReportOrcamento form = new FormReportOrcamento(v);
            form.Show();
            
            Dispose();
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {


            txtPrecoCarro.Text = "";
            txtPrecoTotal.Text = "";
            txtDesconto.Text = "";
            txtJuros.Text = "";
            txtParcelas.Text = "";

            if(cbNome.Text != "")
            {
                cbMotor.Enabled = true;
                cbOpcionais.Enabled = true;
                txtDesconto.Enabled = true;
                txtEntrada.Enabled = true;
                

                C = cbNome.SelectedItem as Carro;
                CarroVenda = cbNome.SelectedItem as Carro;

                cbMotor.DataSource = C.Motor;
                cbMotor.DisplayMember = "Nome";
                cbMotor.ValueMember = "Id";

                cbModelo.Text = C.Modelo;
                
                //cbModelo.SelectedIndex = -1;
                cbMotor.SelectedIndex = -1;
                cbOpcionais.SelectedIndex = -1;

                

                cbOpcionais.DataSource = C.Opcional;
                cbOpcionais.DisplayMember = "Nome";
                cbOpcionais.ValueMember = "Id";

                foreach (int i in cbOpcionais.CheckedIndices)
                {
                    cbOpcionais.SetItemCheckState(i, CheckState.Unchecked);
                }

                /*
                cbMotor.Items.Clear();
                cbMotor.ResetText();
                cbOpcionais.Items.Clear();
                cbOpcionais.ResetText();
                */


            }

            precoCarro = 0;
            precoCarro += C.PrecoBase;
            txtPrecoCarro.Text = "" + Math.Round(precoCarro, 2);

            if (CarroVenda.Motor != null)
                CarroVenda.Motor.Clear();

            btnFinalizaEscolha.Enabled = true;

        }




        private void cbOpcionais_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motor mot = new Motor();
            CarroVenda.Opcional = cbOpcionais.CheckedItems.OfType<Opcional>().ToList();

            precoCarro = CarroVenda.PrecoBase;
            
           if (("" + cbMotor.SelectedItem) != "")
            {
                foreach (Motor m in CarroVenda.Motor)
                 precoCarro += m.PrecoBase;
            }
               
                    

            if (CarroVenda.Opcional != null)
                foreach (Opcional op in CarroVenda.Opcional)
                    precoCarro += op.Preco;

            txtPrecoCarro.Text = "" + Math.Round(precoCarro, 2);
        }


        private void cbMotor_SelectedIndexChanged(object sender, EventArgs e)
        {

            Motor mot = new Motor();
            precoCarro = CarroVenda.PrecoBase;
            mot = cbMotor.SelectedItem as Motor;
            if(CarroVenda.Motor != null)
             CarroVenda.Motor.Clear();
            CarroVenda.Motor.Add(mot);

               if(mot != null)
                precoCarro += mot.PrecoBase;

            if (CarroVenda.Opcional != null)
                foreach (Opcional op in CarroVenda.Opcional)
                    precoCarro += op.Preco;

            txtPrecoCarro.Text = "" + Math.Round(precoCarro, 2);
        }


        public List<Carro> Lc
        {
            get
            {
                return lc;
            }

            set
            {
                lc = value;
            }
        }

        public Carro C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        private void btCalcPreco_Click(object sender, EventArgs e)
        {

            if (txtDesconto.Text == "")
            {
                txtDesconto.Text = "0";
                v.Desconto = 0;
            }

            if (txtEntrada.Text == "")
            {
                txtEntrada.Text = "0";
                v.Entrada = 0;
            }

            if (txtJuros.Text == "" && txtParcelas.Text == "")
            { 
                v.NParcelas = 1;
                v.Juros = 0;
            }

            if (txtJuros.Text == "" && txtParcelas.Text != "")
            {
                erro = true;
            }

            if (txtJuros.Text != "" && txtParcelas.Text == "")
            {
                erro = true;
            }

            


            double auxJuros;
            txtPrecoTotal.Text = txtPrecoCarro.Text;
            double contaParcela;
            if(v.Desconto != 0)
            v.Desconto = double.Parse(txtDesconto.Text);
            if(v.NParcelas != 1)
            v.NParcelas = int.Parse(txtParcelas.Text);
            if(v.Juros != 0)
            v.Juros = double.Parse(txtJuros.Text);
            v.PrecoCarro = double.Parse(txtPrecoCarro.Text);
            auxJuros = v.Juros / 100;
            double Parc = v.NParcelas;

            if(v.NParcelas > 32)
            {
                 MessageBox.Show("O maximo permitido são 32 parcelas", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                v.NParcelas = 32;

            }
            else if(erro == true)
                MessageBox.Show("Ocorreu um erro!", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                contaParcela = Math.Round((double.Parse(txtRestante.Text) * Math.Pow((1 + auxJuros), Parc)), 2);
                txtPrecoAPagar.Text = "" + contaParcela;
                txtPrecoTotal.Text = "" + Math.Round((contaParcela + double.Parse(txtEntrada.Text)), 2);
                txtValParcela.Text = "" + Math.Round((contaParcela / Parc), 2);
            }
              
        
                
            
        }

        public Carro CarroVenda
        {
            get
            {
                return carroVenda;
            }

            set
            {
                carroVenda = value;
            }
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {

            if (txtEntrada.Text != "")
                txtRestante.Text = "" + (double.Parse(txtPrecoCarro.Text) - double.Parse(txtEntrada.Text));
            else
                txtRestante.Text = ("" + ((desconto / 100) * precoCarro));
        }

        private void btnFinalizaEscolha_Click(object sender, EventArgs e)
        {
            if (txtDesconto.Text == "")
                v.Desconto = 0;

            if (double.Parse(txtDesconto.Text) > 100)
                erro = true;

            if (txtEntrada.Text != "")
                txtRestante.Text = "" + (double.Parse(txtPrecoCarro.Text) - double.Parse(txtEntrada.Text));
            else 
                txtRestante.Text = ("" + ((desconto / 100) * precoCarro));
            if(txtDesconto.Text == "" && txtEntrada.Text == "")
                txtRestante.Text = txtPrecoCarro.Text;

            txtParcelas.Enabled = true;
            txtJuros.Enabled = true;
            btCalcPreco.Enabled = true;
            cbNome.Enabled = false;
            cbModelo.Enabled = false;
            cbMotor.Enabled = false;
            cbOpcionais.Enabled = false;
            txtEntrada.Enabled = false;
            txtDesconto.Enabled = false;
            btnOutraEscolha.Enabled = true;
            btnFinalizaEscolha.Enabled = false;

            txtPrecoTotal.Text = txtPrecoCarro.Text;


        }

        private void btnOutraEscolha_Click(object sender, EventArgs e)
        {
            txtJuros.Text = "";
            txtPrecoTotal.Text = "";
            txtValParcela.Text = "";
            txtRestante.Text = "";
            txtPrecoAPagar.Text = "";
            txtParcelas.Text = "";

            txtParcelas.Enabled = false;
            txtJuros.Enabled = false;
            btCalcPreco.Enabled = false;
            cbNome.Enabled = true;
            cbModelo.Enabled = true;
            cbMotor.Enabled = true;
            cbOpcionais.Enabled = true;
            txtEntrada.Enabled = true;
            txtDesconto.Enabled = true;
            btnOutraEscolha.Enabled = false;
            btnFinalizaEscolha.Enabled = true;
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            
            if (txtDesconto.Text != "")
            {
                desconto = double.Parse(txtDesconto.Text);
                txtPrecoCarro.Text = "" + (precoCarro - ((desconto / 100) * precoCarro));
            }
               
            else
                txtPrecoCarro.Text = "" + precoCarro;
        }

        public Venda V
        {
            get
            {
                return v;
            }

            set
            {
                v = value;
            }
        }
    }
}
