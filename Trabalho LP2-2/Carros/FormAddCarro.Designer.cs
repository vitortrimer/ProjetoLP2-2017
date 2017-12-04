namespace Trabalho_LP2_2
{
    partial class FormAddCarro
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbGerenciarCarro = new System.Windows.Forms.Label();
            this.btMotor = new System.Windows.Forms.Button();
            this.btOpcionais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(19, 58);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(19, 84);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 2;
            this.lbModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(67, 81);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(213, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(18, 252);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 25;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(99, 252);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 26;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(205, 252);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 27;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbGerenciarCarro
            // 
            this.lbGerenciarCarro.AutoSize = true;
            this.lbGerenciarCarro.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerenciarCarro.Location = new System.Drawing.Point(12, 9);
            this.lbGerenciarCarro.Name = "lbGerenciarCarro";
            this.lbGerenciarCarro.Size = new System.Drawing.Size(235, 34);
            this.lbGerenciarCarro.TabIndex = 28;
            this.lbGerenciarCarro.Text = "Gerenciar Carro";
            // 
            // btMotor
            // 
            this.btMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMotor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMotor.Location = new System.Drawing.Point(67, 152);
            this.btMotor.Name = "btMotor";
            this.btMotor.Size = new System.Drawing.Size(181, 38);
            this.btMotor.TabIndex = 29;
            this.btMotor.Text = "Selecionar Motores";
            this.btMotor.UseVisualStyleBackColor = true;
            this.btMotor.Click += new System.EventHandler(this.btMotor_Click);
            // 
            // btOpcionais
            // 
            this.btOpcionais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpcionais.Location = new System.Drawing.Point(67, 196);
            this.btOpcionais.Name = "btOpcionais";
            this.btOpcionais.Size = new System.Drawing.Size(181, 37);
            this.btOpcionais.TabIndex = 30;
            this.btOpcionais.Text = "Selecionar Opcionais";
            this.btOpcionais.UseVisualStyleBackColor = true;
            this.btOpcionais.Click += new System.EventHandler(this.btOpcionais_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Preço base";
            // 
            // txtPrecoBase
            // 
            this.txtPrecoBase.Location = new System.Drawing.Point(148, 107);
            this.txtPrecoBase.Name = "txtPrecoBase";
            this.txtPrecoBase.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoBase.TabIndex = 32;
            // 
            // FormAddCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 287);
            this.ControlBox = false;
            this.Controls.Add(this.txtPrecoBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOpcionais);
            this.Controls.Add(this.btMotor);
            this.Controls.Add(this.lbGerenciarCarro);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbGerenciarCarro;
        private System.Windows.Forms.Button btMotor;
        private System.Windows.Forms.Button btOpcionais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoBase;
    }
}