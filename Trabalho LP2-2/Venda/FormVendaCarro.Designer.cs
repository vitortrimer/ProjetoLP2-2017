namespace Trabalho_LP2_2
{
    partial class FormVendaCarro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cbOpcionais = new System.Windows.Forms.CheckedListBox();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.txtPrecoCarro = new System.Windows.Forms.TextBox();
            this.btEscolher = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.cbMotor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btCalcPreco = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinalizaEscolha = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRestante = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOutraEscolha = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtValParcela = new System.Windows.Forms.TextBox();
            this.txtPrecoAPagar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o carro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do carro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Escolha um motor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Escolha os opcionais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Preço do carro";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(371, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 23);
            this.btnFechar.TabIndex = 30;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cbOpcionais
            // 
            this.cbOpcionais.FormattingEnabled = true;
            this.cbOpcionais.Location = new System.Drawing.Point(18, 169);
            this.cbOpcionais.Name = "cbOpcionais";
            this.cbOpcionais.Size = new System.Drawing.Size(376, 139);
            this.cbOpcionais.TabIndex = 31;
            this.cbOpcionais.SelectedIndexChanged += new System.EventHandler(this.cbOpcionais_SelectedIndexChanged);
            // 
            // cbNome
            // 
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(98, 59);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(297, 21);
            this.cbNome.TabIndex = 34;
            this.cbNome.SelectedIndexChanged += new System.EventHandler(this.cbNome_SelectedIndexChanged);
            // 
            // txtPrecoCarro
            // 
            this.txtPrecoCarro.Location = new System.Drawing.Point(258, 314);
            this.txtPrecoCarro.Name = "txtPrecoCarro";
            this.txtPrecoCarro.Size = new System.Drawing.Size(136, 20);
            this.txtPrecoCarro.TabIndex = 35;
            // 
            // btEscolher
            // 
            this.btEscolher.Location = new System.Drawing.Point(19, 619);
            this.btEscolher.Name = "btEscolher";
            this.btEscolher.Size = new System.Drawing.Size(75, 23);
            this.btEscolher.TabIndex = 36;
            this.btEscolher.Text = "Escolher";
            this.btEscolher.UseVisualStyleBackColor = true;
            this.btEscolher.Click += new System.EventHandler(this.btEscolher_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(319, 619);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 37;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // cbMotor
            // 
            this.cbMotor.FormattingEnabled = true;
            this.cbMotor.Location = new System.Drawing.Point(113, 119);
            this.cbMotor.Name = "cbMotor";
            this.cbMotor.Size = new System.Drawing.Size(200, 21);
            this.cbMotor.TabIndex = 38;
            this.cbMotor.SelectedIndexChanged += new System.EventHandler(this.cbMotor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "N° de Parcelas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "% de Juros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "% de desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(98, 314);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(63, 20);
            this.txtDesconto.TabIndex = 43;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // txtParcelas
            // 
            this.txtParcelas.Location = new System.Drawing.Point(88, 16);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(63, 20);
            this.txtParcelas.TabIndex = 44;
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(88, 42);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(63, 20);
            this.txtJuros.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Preço Total";
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.Location = new System.Drawing.Point(11, 37);
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.Size = new System.Drawing.Size(111, 20);
            this.txtPrecoTotal.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(96, 607);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 9);
            this.label11.TabIndex = 48;
            this.label11.Text = "confira todos os campos antes de finalizar a escolha";
            // 
            // btCalcPreco
            // 
            this.btCalcPreco.Location = new System.Drawing.Point(263, 39);
            this.btCalcPreco.Name = "btCalcPreco";
            this.btCalcPreco.Size = new System.Drawing.Size(119, 23);
            this.btCalcPreco.TabIndex = 49;
            this.btCalcPreco.Text = "Calcular preço total";
            this.btCalcPreco.UseVisualStyleBackColor = true;
            this.btCalcPreco.Click += new System.EventHandler(this.btCalcPreco_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFinalizaEscolha);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtRestante);
            this.groupBox1.Controls.Add(this.txtEntrada);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(7, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 76);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de pagamento";
            // 
            // btnFinalizaEscolha
            // 
            this.btnFinalizaEscolha.Location = new System.Drawing.Point(140, 47);
            this.btnFinalizaEscolha.Name = "btnFinalizaEscolha";
            this.btnFinalizaEscolha.Size = new System.Drawing.Size(105, 23);
            this.btnFinalizaEscolha.TabIndex = 4;
            this.btnFinalizaEscolha.Text = "Finalizar escolha";
            this.btnFinalizaEscolha.UseVisualStyleBackColor = true;
            this.btnFinalizaEscolha.Click += new System.EventHandler(this.btnFinalizaEscolha_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Valor restante";
            // 
            // txtRestante
            // 
            this.txtRestante.Location = new System.Drawing.Point(251, 19);
            this.txtRestante.Name = "txtRestante";
            this.txtRestante.Size = new System.Drawing.Size(100, 20);
            this.txtRestante.TabIndex = 2;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(56, 20);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 1;
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Entrada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtParcelas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btCalcPreco);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtJuros);
            this.groupBox2.Location = new System.Drawing.Point(7, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 68);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculo de parcelas";
            // 
            // btnOutraEscolha
            // 
            this.btnOutraEscolha.Location = new System.Drawing.Point(147, 571);
            this.btnOutraEscolha.Name = "btnOutraEscolha";
            this.btnOutraEscolha.Size = new System.Drawing.Size(126, 23);
            this.btnOutraEscolha.TabIndex = 52;
            this.btnOutraEscolha.Text = "Realizar outra ecolha";
            this.btnOutraEscolha.UseVisualStyleBackColor = true;
            this.btnOutraEscolha.Click += new System.EventHandler(this.btnOutraEscolha_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtValParcela);
            this.groupBox3.Controls.Add(this.txtPrecoAPagar);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtPrecoTotal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(8, 498);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 67);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações da compra";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(289, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "Valor por parcela";
            // 
            // txtValParcela
            // 
            this.txtValParcela.Location = new System.Drawing.Point(281, 37);
            this.txtValParcela.Name = "txtValParcela";
            this.txtValParcela.Size = new System.Drawing.Size(100, 20);
            this.txtValParcela.TabIndex = 50;
            // 
            // txtPrecoAPagar
            // 
            this.txtPrecoAPagar.Location = new System.Drawing.Point(155, 37);
            this.txtPrecoAPagar.Name = "txtPrecoAPagar";
            this.txtPrecoAPagar.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoAPagar.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(169, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Preço a pagar";
            // 
            // cbModelo
            // 
            this.cbModelo.Location = new System.Drawing.Point(63, 88);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(171, 20);
            this.cbModelo.TabIndex = 54;
            // 
            // FormVendaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 655);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOutraEscolha);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMotor);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btEscolher);
            this.Controls.Add(this.txtPrecoCarro);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.cbOpcionais);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVendaCarro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVendaCarro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.CheckedListBox cbOpcionais;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.TextBox txtPrecoCarro;
        private System.Windows.Forms.Button btEscolher;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ComboBox cbMotor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecoTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btCalcPreco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRestante;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFinalizaEscolha;
        private System.Windows.Forms.Button btnOutraEscolha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtValParcela;
        private System.Windows.Forms.TextBox txtPrecoAPagar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cbModelo;
    }
}