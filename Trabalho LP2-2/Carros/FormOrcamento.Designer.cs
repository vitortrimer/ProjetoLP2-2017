namespace Trabalho_LP2_2
{
    partial class FormOrcamento
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbMotor = new System.Windows.Forms.Label();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.cbMotor = new System.Windows.Forms.ComboBox();
            this.lbOpcionais = new System.Windows.Forms.Label();
            this.lbParcelas = new System.Windows.Forms.Label();
            this.lbJuros = new System.Windows.Forms.Label();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbOpcionais = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtJuros = new System.Windows.Forms.MaskedTextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(25, 20);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // lbMotor
            // 
            this.lbMotor.AutoSize = true;
            this.lbMotor.Location = new System.Drawing.Point(26, 47);
            this.lbMotor.Name = "lbMotor";
            this.lbMotor.Size = new System.Drawing.Size(34, 13);
            this.lbMotor.TabIndex = 1;
            this.lbMotor.Text = "Motor";
            // 
            // cbNome
            // 
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Items.AddRange(new object[] {
            ""});
            this.cbNome.Location = new System.Drawing.Point(66, 17);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(377, 21);
            this.cbNome.TabIndex = 3;
            this.cbNome.SelectedIndexChanged += new System.EventHandler(this.cbNome_SelectedIndexChanged);
            // 
            // cbMotor
            // 
            this.cbMotor.FormattingEnabled = true;
            this.cbMotor.Location = new System.Drawing.Point(66, 44);
            this.cbMotor.Name = "cbMotor";
            this.cbMotor.Size = new System.Drawing.Size(96, 21);
            this.cbMotor.TabIndex = 4;
            this.cbMotor.SelectedIndexChanged += new System.EventHandler(this.cbMotor_SelectedIndexChanged);
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.AutoSize = true;
            this.lbOpcionais.Location = new System.Drawing.Point(253, 47);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(54, 13);
            this.lbOpcionais.TabIndex = 5;
            this.lbOpcionais.Text = "Opcionais";
            // 
            // lbParcelas
            // 
            this.lbParcelas.AutoSize = true;
            this.lbParcelas.Location = new System.Drawing.Point(49, 74);
            this.lbParcelas.Name = "lbParcelas";
            this.lbParcelas.Size = new System.Drawing.Size(63, 13);
            this.lbParcelas.TabIndex = 7;
            this.lbParcelas.Text = "N° Parcelas";
            // 
            // lbJuros
            // 
            this.lbJuros.AutoSize = true;
            this.lbJuros.Location = new System.Drawing.Point(26, 103);
            this.lbJuros.Name = "lbJuros";
            this.lbJuros.Size = new System.Drawing.Size(86, 13);
            this.lbJuros.TabIndex = 8;
            this.lbJuros.Text = "% de Juros (mes)";
            // 
            // txtParcelas
            // 
            this.txtParcelas.Location = new System.Drawing.Point(118, 71);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(44, 20);
            this.txtParcelas.TabIndex = 9;
            this.txtParcelas.TextChanged += new System.EventHandler(this.txtParcelas_TextChanged);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(37, 139);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 11;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(368, 139);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbOpcionais
            // 
            this.cbOpcionais.FormattingEnabled = true;
            this.cbOpcionais.Location = new System.Drawing.Point(313, 44);
            this.cbOpcionais.Name = "cbOpcionais";
            this.cbOpcionais.Size = new System.Drawing.Size(130, 21);
            this.cbOpcionais.TabIndex = 13;
            this.cbOpcionais.SelectedIndexChanged += new System.EventHandler(this.cbOpcionais_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(313, 71);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(64, 23);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(118, 100);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(44, 20);
            this.txtJuros.TabIndex = 15;
            this.txtJuros.TextChanged += new System.EventHandler(this.txtJuros_TextChanged);
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(272, 103);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(35, 13);
            this.lbPreco.TabIndex = 16;
            this.lbPreco.Text = "Preço";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(313, 100);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(130, 20);
            this.txtValor.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(168, 98);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(71, 23);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(383, 71);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(60, 23);
            this.btnRemover.TabIndex = 19;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // FormOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 174);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cbOpcionais);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtParcelas);
            this.Controls.Add(this.lbJuros);
            this.Controls.Add(this.lbParcelas);
            this.Controls.Add(this.lbOpcionais);
            this.Controls.Add(this.cbMotor);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.lbMotor);
            this.Controls.Add(this.lbNome);
            this.Name = "FormOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Orçamento";
            this.Load += new System.EventHandler(this.FormOrcamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbMotor;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.ComboBox cbMotor;
        private System.Windows.Forms.Label lbOpcionais;
        private System.Windows.Forms.Label lbParcelas;
        private System.Windows.Forms.Label lbJuros;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbOpcionais;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.MaskedTextBox txtJuros;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRemover;
    }
}