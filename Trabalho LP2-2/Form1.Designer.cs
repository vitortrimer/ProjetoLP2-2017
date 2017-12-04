namespace Trabalho_LP2_2
{
    partial class Programa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btHistoricos = new System.Windows.Forms.Button();
            this.btVenda = new System.Windows.Forms.Button();
            this.btCarros = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 50);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1024, 600);
            this.pPrincipal.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Trabalho_LP2_2.Properties.Resources.bgmenu2;
            this.panel1.Controls.Add(this.btFuncionario);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.btHistoricos);
            this.panel1.Controls.Add(this.btVenda);
            this.panel1.Controls.Add(this.btCarros);
            this.panel1.Controls.Add(this.btCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 50);
            this.panel1.TabIndex = 2;
            // 
            // btFuncionario
            // 
            this.btFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btFuncionario.Dock = System.Windows.Forms.DockStyle.Left;
            this.btFuncionario.FlatAppearance.BorderSize = 0;
            this.btFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFuncionario.ForeColor = System.Drawing.Color.Silver;
            this.btFuncionario.Image = global::Trabalho_LP2_2.Properties.Resources.icons8_permanent_job_802;
            this.btFuncionario.Location = new System.Drawing.Point(550, 0);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(191, 50);
            this.btFuncionario.TabIndex = 5;
            this.btFuncionario.Text = "Funcionarios";
            this.btFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFuncionario.UseVisualStyleBackColor = false;
            this.btFuncionario.Click += new System.EventHandler(this.btFuncionario_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 247);
            this.panel2.TabIndex = 3;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Transparent;
            this.btSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.Silver;
            this.btSair.Image = global::Trabalho_LP2_2.Properties.Resources.icons8_return_402;
            this.btSair.Location = new System.Drawing.Point(892, 0);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(132, 50);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "Logout";
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btHistoricos
            // 
            this.btHistoricos.BackColor = System.Drawing.Color.Transparent;
            this.btHistoricos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btHistoricos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btHistoricos.FlatAppearance.BorderSize = 0;
            this.btHistoricos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btHistoricos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btHistoricos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistoricos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistoricos.ForeColor = System.Drawing.Color.Silver;
            this.btHistoricos.Image = global::Trabalho_LP2_2.Properties.Resources.icons8_search3;
            this.btHistoricos.Location = new System.Drawing.Point(390, 0);
            this.btHistoricos.Name = "btHistoricos";
            this.btHistoricos.Size = new System.Drawing.Size(160, 50);
            this.btHistoricos.TabIndex = 3;
            this.btHistoricos.Text = "Historicos";
            this.btHistoricos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHistoricos.UseVisualStyleBackColor = false;
            this.btHistoricos.Click += new System.EventHandler(this.btHistoricos_Click);
            // 
            // btVenda
            // 
            this.btVenda.BackColor = System.Drawing.Color.Transparent;
            this.btVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btVenda.Dock = System.Windows.Forms.DockStyle.Left;
            this.btVenda.FlatAppearance.BorderSize = 0;
            this.btVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVenda.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenda.ForeColor = System.Drawing.Color.Silver;
            this.btVenda.Image = global::Trabalho_LP2_2.Properties.Resources.icons8_shopping_cart;
            this.btVenda.Location = new System.Drawing.Point(260, 0);
            this.btVenda.Name = "btVenda";
            this.btVenda.Size = new System.Drawing.Size(130, 50);
            this.btVenda.TabIndex = 2;
            this.btVenda.Text = "Venda";
            this.btVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btVenda.UseVisualStyleBackColor = false;
            this.btVenda.Click += new System.EventHandler(this.btVenda_Click);
            // 
            // btCarros
            // 
            this.btCarros.BackColor = System.Drawing.Color.Transparent;
            this.btCarros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCarros.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCarros.FlatAppearance.BorderSize = 0;
            this.btCarros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btCarros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCarros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarros.ForeColor = System.Drawing.Color.Silver;
            this.btCarros.Image = global::Trabalho_LP2_2.Properties.Resources.icons9_car;
            this.btCarros.Location = new System.Drawing.Point(130, 0);
            this.btCarros.Name = "btCarros";
            this.btCarros.Size = new System.Drawing.Size(130, 50);
            this.btCarros.TabIndex = 1;
            this.btCarros.Text = "Carros";
            this.btCarros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCarros.UseVisualStyleBackColor = false;
            this.btCarros.Click += new System.EventHandler(this.btCarros_Click);
            // 
            // btCliente
            // 
            this.btCliente.BackColor = System.Drawing.Color.Transparent;
            this.btCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCliente.FlatAppearance.BorderSize = 0;
            this.btCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCliente.ForeColor = System.Drawing.Color.Silver;
            this.btCliente.Image = global::Trabalho_LP2_2.Properties.Resources.icons8_customer__1_3;
            this.btCliente.Location = new System.Drawing.Point(0, 0);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(130, 50);
            this.btCliente.TabIndex = 0;
            this.btCliente.Text = "Cliente";
            this.btCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCliente.UseVisualStyleBackColor = false;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // Programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 650);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Programa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa";
            this.Load += new System.EventHandler(this.Programa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button btCarros;
        private System.Windows.Forms.Button btHistoricos;
        private System.Windows.Forms.Button btVenda;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btFuncionario;
    }
}

