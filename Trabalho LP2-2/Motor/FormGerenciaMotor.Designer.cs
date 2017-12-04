namespace Trabalho_LP2_2
{
    partial class FormGerenciaMotor
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbLitragem = new System.Windows.Forms.Label();
            this.lbCavalos = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLitragem = new System.Windows.Forms.TextBox();
            this.txtCavalos = new System.Windows.Forms.TextBox();
            this.txtPrecoBase = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciar Motores";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(40, 49);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // lbLitragem
            // 
            this.lbLitragem.AutoSize = true;
            this.lbLitragem.Location = new System.Drawing.Point(28, 75);
            this.lbLitragem.Name = "lbLitragem";
            this.lbLitragem.Size = new System.Drawing.Size(47, 13);
            this.lbLitragem.TabIndex = 2;
            this.lbLitragem.Text = "Litragem";
            // 
            // lbCavalos
            // 
            this.lbCavalos.AutoSize = true;
            this.lbCavalos.Location = new System.Drawing.Point(30, 101);
            this.lbCavalos.Name = "lbCavalos";
            this.lbCavalos.Size = new System.Drawing.Size(45, 13);
            this.lbCavalos.TabIndex = 3;
            this.lbCavalos.Text = "Cavalos";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(187, 75);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(26, 13);
            this.lbAno.TabIndex = 4;
            this.lbAno.Text = "Ano";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(14, 127);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(61, 13);
            this.lbPreco.TabIndex = 5;
            this.lbPreco.Text = "Preço base";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(191, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtLitragem
            // 
            this.txtLitragem.Location = new System.Drawing.Point(81, 72);
            this.txtLitragem.Name = "txtLitragem";
            this.txtLitragem.Size = new System.Drawing.Size(100, 20);
            this.txtLitragem.TabIndex = 7;
            // 
            // txtCavalos
            // 
            this.txtCavalos.Location = new System.Drawing.Point(81, 98);
            this.txtCavalos.Name = "txtCavalos";
            this.txtCavalos.Size = new System.Drawing.Size(100, 20);
            this.txtCavalos.TabIndex = 8;
            // 
            // txtPrecoBase
            // 
            this.txtPrecoBase.Location = new System.Drawing.Point(81, 124);
            this.txtPrecoBase.Name = "txtPrecoBase";
            this.txtPrecoBase.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoBase.TabIndex = 9;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(219, 72);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(53, 20);
            this.txtAno.TabIndex = 10;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(18, 167);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(57, 23);
            this.btSalvar.TabIndex = 11;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(81, 167);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(62, 23);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(209, 167);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(63, 23);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(182, 200);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 13);
            this.lbId.TabIndex = 14;
            this.lbId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(209, 196);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 20);
            this.txtId.TabIndex = 15;
            // 
            // FormGerenciaMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 222);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtPrecoBase);
            this.Controls.Add(this.txtCavalos);
            this.Controls.Add(this.txtLitragem);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbCavalos);
            this.Controls.Add(this.lbLitragem);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGerenciaMotor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciar Motor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbLitragem;
        private System.Windows.Forms.Label lbCavalos;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLitragem;
        private System.Windows.Forms.TextBox txtCavalos;
        private System.Windows.Forms.TextBox txtPrecoBase;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtId;
    }
}