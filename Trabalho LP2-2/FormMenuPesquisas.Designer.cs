namespace Trabalho_LP2_2
{
    partial class FormMenuPesquisas
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
            this.btHistCompras = new System.Windows.Forms.Button();
            this.btHistCarros = new System.Windows.Forms.Button();
            this.btHistFuncionarios = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btHistCompras
            // 
            this.btHistCompras.BackColor = System.Drawing.Color.Transparent;
            this.btHistCompras.FlatAppearance.BorderSize = 0;
            this.btHistCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btHistCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btHistCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistCompras.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistCompras.ForeColor = System.Drawing.Color.Silver;
            this.btHistCompras.Location = new System.Drawing.Point(12, 43);
            this.btHistCompras.Name = "btHistCompras";
            this.btHistCompras.Size = new System.Drawing.Size(216, 25);
            this.btHistCompras.TabIndex = 4;
            this.btHistCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHistCompras.UseVisualStyleBackColor = false;
            this.btHistCompras.Click += new System.EventHandler(this.btHistCompras_Click);
            // 
            // btHistCarros
            // 
            this.btHistCarros.BackColor = System.Drawing.Color.Transparent;
            this.btHistCarros.FlatAppearance.BorderSize = 0;
            this.btHistCarros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btHistCarros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btHistCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistCarros.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistCarros.ForeColor = System.Drawing.Color.Silver;
            this.btHistCarros.Location = new System.Drawing.Point(12, 85);
            this.btHistCarros.Name = "btHistCarros";
            this.btHistCarros.Size = new System.Drawing.Size(188, 25);
            this.btHistCarros.TabIndex = 5;
            this.btHistCarros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHistCarros.UseVisualStyleBackColor = false;
            this.btHistCarros.Click += new System.EventHandler(this.btHistCarros_Click);
            // 
            // btHistFuncionarios
            // 
            this.btHistFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.btHistFuncionarios.FlatAppearance.BorderSize = 0;
            this.btHistFuncionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btHistFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btHistFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistFuncionarios.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistFuncionarios.ForeColor = System.Drawing.Color.Silver;
            this.btHistFuncionarios.Location = new System.Drawing.Point(15, 126);
            this.btHistFuncionarios.Name = "btHistFuncionarios";
            this.btHistFuncionarios.Size = new System.Drawing.Size(241, 25);
            this.btHistFuncionarios.TabIndex = 6;
            this.btHistFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHistFuncionarios.UseVisualStyleBackColor = false;
            this.btHistFuncionarios.Click += new System.EventHandler(this.btHistFuncionarios_Click);
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
            this.btVoltar.Location = new System.Drawing.Point(190, 223);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(82, 25);
            this.btVoltar.TabIndex = 7;
            this.btVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // FormMenuPesquisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabalho_LP2_2.Properties.Resources.bgMenuHistorico;
            this.ClientSize = new System.Drawing.Size(287, 262);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btHistFuncionarios);
            this.Controls.Add(this.btHistCarros);
            this.Controls.Add(this.btHistCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuPesquisas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMenuPesquisas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btHistCompras;
        private System.Windows.Forms.Button btHistCarros;
        private System.Windows.Forms.Button btHistFuncionarios;
        private System.Windows.Forms.Button btVoltar;
    }
}