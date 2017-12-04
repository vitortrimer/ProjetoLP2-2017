namespace Trabalho_LP2_2
{
    partial class FormMotor
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btVisualizar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.gbAdicionados = new System.Windows.Forms.GroupBox();
            this.dgvAdicionados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cavalagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPesquisar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEscolher = new System.Windows.Forms.Button();
            this.btRetira = new System.Windows.Forms.Button();
            this.btViewMode = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.gbAdicionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(691, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 23);
            this.btnFechar.TabIndex = 28;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Motor";
            // 
            // btVisualizar
            // 
            this.btVisualizar.Location = new System.Drawing.Point(451, 615);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(62, 23);
            this.btVisualizar.TabIndex = 26;
            this.btVisualizar.Text = "Visualizar";
            this.btVisualizar.UseVisualStyleBackColor = true;
            this.btVisualizar.Click += new System.EventHandler(this.btVisualizar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(650, 615);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(65, 23);
            this.btRemover.TabIndex = 25;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(519, 615);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(58, 23);
            this.btEditar.TabIndex = 24;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(384, 615);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(61, 23);
            this.btAdicionar.TabIndex = 23;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(422, 56);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(296, 20);
            this.txtFiltrar.TabIndex = 22;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Location = new System.Drawing.Point(381, 59);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(32, 13);
            this.lbFiltrar.TabIndex = 21;
            this.lbFiltrar.Text = "Filtrar";
            // 
            // gbAdicionados
            // 
            this.gbAdicionados.Controls.Add(this.dgvAdicionados);
            this.gbAdicionados.Location = new System.Drawing.Point(18, 56);
            this.gbAdicionados.Name = "gbAdicionados";
            this.gbAdicionados.Size = new System.Drawing.Size(334, 521);
            this.gbAdicionados.TabIndex = 20;
            this.gbAdicionados.TabStop = false;
            this.gbAdicionados.Text = "Motores adicionados";
            // 
            // dgvAdicionados
            // 
            this.dgvAdicionados.AllowUserToAddRows = false;
            this.dgvAdicionados.AllowUserToDeleteRows = false;
            this.dgvAdicionados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAdicionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdicionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Preço,
            this.Cavalagem});
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
            // ID
            // 
            this.ID.FillWeight = 20F;
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
            this.Preço.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Preço.FillWeight = 50F;
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            this.Preço.Width = 85;
            // 
            // Cavalagem
            // 
            this.Cavalagem.FillWeight = 30F;
            this.Cavalagem.HeaderText = "Cavalagem";
            this.Cavalagem.Name = "Cavalagem";
            this.Cavalagem.ReadOnly = true;
            this.Cavalagem.Width = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(384, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 495);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // dgvPesquisar
            // 
            this.dgvPesquisar.AllowUserToAddRows = false;
            this.dgvPesquisar.AllowUserToDeleteRows = false;
            this.dgvPesquisar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 30F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Cavalagem";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 65;
            // 
            // btEscolher
            // 
            this.btEscolher.Location = new System.Drawing.Point(387, 580);
            this.btEscolher.Name = "btEscolher";
            this.btEscolher.Size = new System.Drawing.Size(36, 23);
            this.btEscolher.TabIndex = 29;
            this.btEscolher.Text = "<<";
            this.btEscolher.UseVisualStyleBackColor = true;
            this.btEscolher.Click += new System.EventHandler(this.btEscolher_Click);
            // 
            // btRetira
            // 
            this.btRetira.Location = new System.Drawing.Point(21, 580);
            this.btRetira.Name = "btRetira";
            this.btRetira.Size = new System.Drawing.Size(36, 23);
            this.btRetira.TabIndex = 30;
            this.btRetira.Text = ">>";
            this.btRetira.UseVisualStyleBackColor = true;
            this.btRetira.Click += new System.EventHandler(this.btRetira_Click);
            // 
            // btViewMode
            // 
            this.btViewMode.Location = new System.Drawing.Point(100, 615);
            this.btViewMode.Name = "btViewMode";
            this.btViewMode.Size = new System.Drawing.Size(63, 23);
            this.btViewMode.TabIndex = 31;
            this.btViewMode.Text = "Visualizar";
            this.btViewMode.UseVisualStyleBackColor = true;
            this.btViewMode.Click += new System.EventHandler(this.btViewMode_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(19, 615);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btFinalizar.TabIndex = 36;
            this.btFinalizar.Text = "Fechar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // FormMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 644);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btViewMode);
            this.Controls.Add(this.btRetira);
            this.Controls.Add(this.btEscolher);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVisualizar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.gbAdicionados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMotor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMotor";
            this.gbAdicionados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVisualizar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.GroupBox gbAdicionados;
        private System.Windows.Forms.DataGridView dgvAdicionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cavalagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btEscolher;
        private System.Windows.Forms.Button btRetira;
        private System.Windows.Forms.Button btViewMode;
        private System.Windows.Forms.Button btFinalizar;
    }
}