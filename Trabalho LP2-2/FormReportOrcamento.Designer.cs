namespace Trabalho_LP2_2
{
    partial class FormReportOrcamento
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
            this.crvOrcamento = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crOrcamento1 = new Trabalho_LP2_2.crOrcamento();
            this.SuspendLayout();
            // 
            // crvOrcamento
            // 
            this.crvOrcamento.ActiveViewIndex = 0;
            this.crvOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvOrcamento.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvOrcamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvOrcamento.Location = new System.Drawing.Point(0, 0);
            this.crvOrcamento.Name = "crvOrcamento";
            this.crvOrcamento.ReportSource = this.crOrcamento1;
            this.crvOrcamento.Size = new System.Drawing.Size(882, 542);
            this.crvOrcamento.TabIndex = 0;
            // 
            // FormReportOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 542);
            this.Controls.Add(this.crvOrcamento);
            this.Name = "FormReportOrcamento";
            this.Text = "FormReportOrcamento";
            this.Load += new System.EventHandler(this.FormReportOrcamento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvOrcamento;
        private crOrcamento crOrcamento1;
    }
}