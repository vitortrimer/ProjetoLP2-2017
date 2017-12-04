namespace Trabalho_LP2_2
{
    partial class FormOpcionais
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
            this.btVisualizar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.gbPesquisar = new System.Windows.Forms.GroupBox();
            this.dgvPesquisar = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btFechar = new System.Windows.Forms.Button();
            this.lbOpcionais = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btEscolher = new System.Windows.Forms.Button();
            this.btViewMode = new System.Windows.Forms.Button();
            this.btRetira = new System.Windows.Forms.Button();
            this.gbAdicionados = new System.Windows.Forms.GroupBox();
            this.dgvAdicionados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.gbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).BeginInit();
            this.gbAdicionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionados)).BeginInit();
            this.SuspendLayout();
            // 
            // btVisualizar
            // 
            this.btVisualizar.Location = new System.Drawing.Point(422, 597);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(62, 23);
            this.btVisualizar.TabIndex = 17;
            this.btVisualizar.Text = "Visualizar";
            this.btVisualizar.UseVisualStyleBackColor = true;
            this.btVisualizar.Click += new System.EventHandler(this.btVisualizar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(621, 597);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(65, 23);
            this.btRemover.TabIndex = 16;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(490, 597);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(58, 23);
            this.btEditar.TabIndex = 15;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(355, 597);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(61, 23);
            this.btAdicionar.TabIndex = 14;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(392, 44);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(296, 20);
            this.txtFiltrar.TabIndex = 13;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Location = new System.Drawing.Point(351, 47);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(32, 13);
            this.lbFiltrar.TabIndex = 12;
            this.lbFiltrar.Text = "Filtrar";
            // 
            // gbPesquisar
            // 
            this.gbPesquisar.Controls.Add(this.dgvPesquisar);
            this.gbPesquisar.Location = new System.Drawing.Point(354, 72);
            this.gbPesquisar.Name = "gbPesquisar";
            this.gbPesquisar.Size = new System.Drawing.Size(334, 495);
            this.gbPesquisar.TabIndex = 11;
            this.gbPesquisar.TabStop = false;
            this.gbPesquisar.Text = "Pesquisar";
            // 
            // dgvPesquisar
            // 
            this.dgvPesquisar.AllowUserToAddRows = false;
            this.dgvPesquisar.AllowUserToDeleteRows = false;
            this.dgvPesquisar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Preço});
            this.dgvPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPesquisar.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPesquisar.Location = new System.Drawing.Point(3, 16);
            this.dgvPesquisar.Name = "dgvPesquisar";
            this.dgvPesquisar.ReadOnly = true;
            this.dgvPesquisar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPesquisar.RowHeadersVisible = false;
            this.dgvPesquisar.Size = new System.Drawing.Size(328, 476);
            this.dgvPesquisar.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Preço
            // 
            this.Preço.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Preço.FillWeight = 50F;
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(345, -49);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(24, 23);
            this.btFechar.TabIndex = 10;
            this.btFechar.Text = "X";
            this.btFechar.UseVisualStyleBackColor = true;
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.AutoSize = true;
            this.lbOpcionais.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpcionais.Location = new System.Drawing.Point(29, -52);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(155, 34);
            this.lbOpcionais.TabIndex = 9;
            this.lbOpcionais.Text = "Opcionais";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(664, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 23);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "Opcionais";
            // 
            // btEscolher
            // 
            this.btEscolher.Location = new System.Drawing.Point(360, 568);
            this.btEscolher.Name = "btEscolher";
            this.btEscolher.Size = new System.Drawing.Size(33, 23);
            this.btEscolher.TabIndex = 20;
            this.btEscolher.Text = "<<";
            this.btEscolher.UseVisualStyleBackColor = true;
            this.btEscolher.Click += new System.EventHandler(this.btEscolher_Click);
            // 
            // btViewMode
            // 
            this.btViewMode.Location = new System.Drawing.Point(95, 597);
            this.btViewMode.Name = "btViewMode";
            this.btViewMode.Size = new System.Drawing.Size(69, 23);
            this.btViewMode.TabIndex = 34;
            this.btViewMode.Text = "Visualizar";
            this.btViewMode.UseVisualStyleBackColor = true;
            this.btViewMode.Click += new System.EventHandler(this.btViewMode_Click);
            // 
            // btRetira
            // 
            this.btRetira.Location = new System.Drawing.Point(13, 568);
            this.btRetira.Name = "btRetira";
            this.btRetira.Size = new System.Drawing.Size(36, 23);
            this.btRetira.TabIndex = 33;
            this.btRetira.Text = ">>";
            this.btRetira.UseVisualStyleBackColor = true;
            this.btRetira.Click += new System.EventHandler(this.btRetira_Click);
            // 
            // gbAdicionados
            // 
            this.gbAdicionados.Controls.Add(this.dgvAdicionados);
            this.gbAdicionados.Location = new System.Drawing.Point(11, 47);
            this.gbAdicionados.Name = "gbAdicionados";
            this.gbAdicionados.Size = new System.Drawing.Size(334, 521);
            this.gbAdicionados.TabIndex = 32;
            this.gbAdicionados.TabStop = false;
            this.gbAdicionados.Text = "Opcionais Adicionados";
            // 
            // dgvAdicionados
            // 
            this.dgvAdicionados.AllowUserToAddRows = false;
            this.dgvAdicionados.AllowUserToDeleteRows = false;
            this.dgvAdicionados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAdicionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdicionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvAdicionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdicionados.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAdicionados.Location = new System.Drawing.Point(3, 16);
            this.dgvAdicionados.Name = "dgvAdicionados";
            this.dgvAdicionados.ReadOnly = true;
            this.dgvAdicionados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAdicionados.RowHeadersVisible = false;
            this.dgvAdicionados.Size = new System.Drawing.Size(328, 502);
            this.dgvAdicionados.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 20F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(14, 597);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btFinalizar.TabIndex = 35;
            this.btFinalizar.Text = "Fechar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // FormOpcionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 630);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btViewMode);
            this.Controls.Add(this.btRetira);
            this.Controls.Add(this.gbAdicionados);
            this.Controls.Add(this.btEscolher);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVisualizar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.gbPesquisar);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lbOpcionais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOpcionais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormOpcionais";
            this.Load += new System.EventHandler(this.FormOpcionais_Load);
            this.gbPesquisar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).EndInit();
            this.gbAdicionados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVisualizar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.GroupBox gbPesquisar;
        private System.Windows.Forms.DataGridView dgvPesquisar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label lbOpcionais;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEscolher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.Button btViewMode;
        private System.Windows.Forms.Button btRetira;
        private System.Windows.Forms.GroupBox gbAdicionados;
        private System.Windows.Forms.DataGridView dgvAdicionados;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}