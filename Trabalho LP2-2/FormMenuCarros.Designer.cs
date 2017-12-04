namespace Trabalho_LP2_2
{
    partial class FormMenuCarros
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
            this.btGerenciaCarros = new System.Windows.Forms.Button();
            this.btOrcamento = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGerenciaCarros
            // 
            this.btGerenciaCarros.BackColor = System.Drawing.Color.Transparent;
            this.btGerenciaCarros.FlatAppearance.BorderSize = 0;
            this.btGerenciaCarros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btGerenciaCarros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btGerenciaCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGerenciaCarros.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerenciaCarros.ForeColor = System.Drawing.Color.Silver;
            this.btGerenciaCarros.Location = new System.Drawing.Point(25, 139);
            this.btGerenciaCarros.Name = "btGerenciaCarros";
            this.btGerenciaCarros.Size = new System.Drawing.Size(247, 39);
            this.btGerenciaCarros.TabIndex = 0;
            this.btGerenciaCarros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGerenciaCarros.UseVisualStyleBackColor = false;
            this.btGerenciaCarros.Click += new System.EventHandler(this.btGerenciaCarros_Click);
            // 
            // btOrcamento
            // 
            this.btOrcamento.BackColor = System.Drawing.Color.Transparent;
            this.btOrcamento.FlatAppearance.BorderSize = 0;
            this.btOrcamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btOrcamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrcamento.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrcamento.ForeColor = System.Drawing.Color.Silver;
            this.btOrcamento.Location = new System.Drawing.Point(12, 59);
            this.btOrcamento.Name = "btOrcamento";
            this.btOrcamento.Size = new System.Drawing.Size(260, 43);
            this.btOrcamento.TabIndex = 1;
            this.btOrcamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOrcamento.UseVisualStyleBackColor = false;
            this.btOrcamento.Click += new System.EventHandler(this.btOrcamento_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.Silver;
            this.btVoltar.Location = new System.Drawing.Point(189, 224);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(86, 24);
            this.btVoltar.TabIndex = 3;
            this.btVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // FormMenuCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Trabalho_LP2_2.Properties.Resources.bgmenucarros4;
            this.ClientSize = new System.Drawing.Size(287, 262);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btOrcamento);
            this.Controls.Add(this.btGerenciaCarros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMenuCarros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGerenciaCarros;
        private System.Windows.Forms.Button btOrcamento;
        private System.Windows.Forms.Button btVoltar;
    }
}