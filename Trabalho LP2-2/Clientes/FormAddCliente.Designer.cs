namespace Trabalho_LP2_2
{
    partial class FormAddCliente
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
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lbRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbbairro = new System.Windows.Forms.Label();
            this.lbCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumeroEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.lbRG = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.lbDataNasc = new System.Windows.Forms.Label();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.gbDadosBancarios = new System.Windows.Forms.GroupBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.lbAgencia = new System.Windows.Forms.Label();
            this.lbConta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDadosPessoais.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbDadosBancarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 22);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(221, 21);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Codigo";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(37, 48);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(27, 13);
            this.lbCpf.TabIndex = 2;
            this.lbCpf.Text = "CPF";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(15, 96);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 3;
            this.lbTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(48, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(302, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(267, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 25;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(70, 45);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(70, 93);
            this.txtTelefone.Mask = "(00)0000-00000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(14, 438);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 18;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(95, 438);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 19;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(19, 48);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(27, 13);
            this.lbRua.TabIndex = 12;
            this.lbRua.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(50, 45);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(300, 20);
            this.txtRua.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(50, 70);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(219, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // lbbairro
            // 
            this.lbbairro.AutoSize = true;
            this.lbbairro.Location = new System.Drawing.Point(15, 73);
            this.lbbairro.Name = "lbbairro";
            this.lbbairro.Size = new System.Drawing.Size(34, 13);
            this.lbbairro.TabIndex = 15;
            this.lbbairro.Text = "Bairro";
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(17, 22);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(28, 13);
            this.lbCep.TabIndex = 16;
            this.lbCep.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(50, 19);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(120, 20);
            this.txtCep.TabIndex = 9;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(275, 96);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(75, 20);
            this.txtComplemento.TabIndex = 13;
            // 
            // txtNumeroEnd
            // 
            this.txtNumeroEnd.Location = new System.Drawing.Point(50, 96);
            this.txtNumeroEnd.Name = "txtNumeroEnd";
            this.txtNumeroEnd.Size = new System.Drawing.Size(95, 20);
            this.txtNumeroEnd.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Complemento";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(286, 438);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 20;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 33);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cliente";
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.AutoSize = true;
            this.lbEstadoCivil.Location = new System.Drawing.Point(184, 74);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.lbEstadoCivil.TabIndex = 25;
            this.lbEstadoCivil.Text = "Estado Civil";
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Location = new System.Drawing.Point(250, 70);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(100, 20);
            this.txtEstadoCivil.TabIndex = 5;
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(220, 48);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(23, 13);
            this.lbRG.TabIndex = 27;
            this.lbRG.Text = "RG";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.CustomFormat = "yyyy-MM-dd";
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNasc.Location = new System.Drawing.Point(70, 70);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(100, 20);
            this.dtpDataNasc.TabIndex = 4;
            this.dtpDataNasc.Value = new System.DateTime(2017, 11, 8, 0, 0, 0, 0);
            // 
            // lbDataNasc
            // 
            this.lbDataNasc.AutoSize = true;
            this.lbDataNasc.Location = new System.Drawing.Point(6, 73);
            this.lbDataNasc.Name = "lbDataNasc";
            this.lbDataNasc.Size = new System.Drawing.Size(58, 13);
            this.lbDataNasc.TabIndex = 30;
            this.lbDataNasc.Text = "Data Nasc";
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.txtRG);
            this.gbDadosPessoais.Controls.Add(this.label7);
            this.gbDadosPessoais.Controls.Add(this.txtRenda);
            this.gbDadosPessoais.Controls.Add(this.txtEmail);
            this.gbDadosPessoais.Controls.Add(this.lbEmail);
            this.gbDadosPessoais.Controls.Add(this.txtTelefone);
            this.gbDadosPessoais.Controls.Add(this.lbTelefone);
            this.gbDadosPessoais.Controls.Add(this.lbNome);
            this.gbDadosPessoais.Controls.Add(this.lbDataNasc);
            this.gbDadosPessoais.Controls.Add(this.dtpDataNasc);
            this.gbDadosPessoais.Controls.Add(this.lbCpf);
            this.gbDadosPessoais.Controls.Add(this.txtEstadoCivil);
            this.gbDadosPessoais.Controls.Add(this.lbEstadoCivil);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.lbRG);
            this.gbDadosPessoais.Controls.Add(this.txtCpf);
            this.gbDadosPessoais.Location = new System.Drawing.Point(11, 48);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(356, 156);
            this.gbDadosPessoais.TabIndex = 31;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados pessoais";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(250, 44);
            this.txtRG.Mask = "00,000,000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Renda mensal";
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(249, 95);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(101, 20);
            this.txtRenda.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(29, 124);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 31;
            this.lbEmail.Text = "E-mail";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.txtCep);
            this.gbEndereco.Controls.Add(this.lbRua);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.label2);
            this.gbEndereco.Controls.Add(this.lbbairro);
            this.gbEndereco.Controls.Add(this.label1);
            this.gbEndereco.Controls.Add(this.lbCep);
            this.gbEndereco.Controls.Add(this.txtNumeroEnd);
            this.gbEndereco.Controls.Add(this.txtComplemento);
            this.gbEndereco.Location = new System.Drawing.Point(11, 210);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(356, 127);
            this.gbEndereco.TabIndex = 32;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Enredeço";
            // 
            // gbDadosBancarios
            // 
            this.gbDadosBancarios.Controls.Add(this.txtAgencia);
            this.gbDadosBancarios.Controls.Add(this.txtConta);
            this.gbDadosBancarios.Controls.Add(this.txtNomeBanco);
            this.gbDadosBancarios.Controls.Add(this.lbAgencia);
            this.gbDadosBancarios.Controls.Add(this.lbConta);
            this.gbDadosBancarios.Controls.Add(this.label4);
            this.gbDadosBancarios.Location = new System.Drawing.Point(11, 343);
            this.gbDadosBancarios.Name = "gbDadosBancarios";
            this.gbDadosBancarios.Size = new System.Drawing.Size(356, 85);
            this.gbDadosBancarios.TabIndex = 33;
            this.gbDadosBancarios.TabStop = false;
            this.gbDadosBancarios.Text = "Dados bancarios";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(98, 52);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(100, 20);
            this.txtAgencia.TabIndex = 15;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(256, 52);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(94, 20);
            this.txtConta.TabIndex = 16;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(98, 26);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(252, 20);
            this.txtNomeBanco.TabIndex = 14;
            // 
            // lbAgencia
            // 
            this.lbAgencia.AutoSize = true;
            this.lbAgencia.Location = new System.Drawing.Point(45, 55);
            this.lbAgencia.Name = "lbAgencia";
            this.lbAgencia.Size = new System.Drawing.Size(46, 13);
            this.lbAgencia.TabIndex = 2;
            this.lbAgencia.Text = "Agencia";
            // 
            // lbConta
            // 
            this.lbConta.AutoSize = true;
            this.lbConta.Location = new System.Drawing.Point(215, 55);
            this.lbConta.Name = "lbConta";
            this.lbConta.Size = new System.Drawing.Size(35, 13);
            this.lbConta.TabIndex = 1;
            this.lbConta.Text = "Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome do banco";
            // 
            // FormAddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 472);
            this.ControlBox = false;
            this.Controls.Add(this.gbDadosBancarios);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormAddCliente_Load);
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbDadosBancarios.ResumeLayout(false);
            this.gbDadosBancarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbbairro;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumeroEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEstadoCivil;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label lbDataNasc;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.GroupBox gbDadosBancarios;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.Label lbAgencia;
        private System.Windows.Forms.Label lbConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtRG;
    }
}