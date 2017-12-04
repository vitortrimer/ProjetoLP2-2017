namespace Trabalho_LP2_2
{
    partial class FormReportVenda
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
            this.crystalVenda = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalVenda
            // 
            this.crystalVenda.ActiveViewIndex = -1;
            this.crystalVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalVenda.Location = new System.Drawing.Point(0, 0);
            this.crystalVenda.Name = "crystalVenda";
            this.crystalVenda.ShowLogo = false;
            this.crystalVenda.Size = new System.Drawing.Size(751, 538);
            this.crystalVenda.TabIndex = 0;
            // 
            // FormReportVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 538);
            this.Controls.Add(this.crystalVenda);
            this.Name = "FormReportVenda";
            this.ShowIcon = false;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.FormReportVenda_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalVenda;
    }
}