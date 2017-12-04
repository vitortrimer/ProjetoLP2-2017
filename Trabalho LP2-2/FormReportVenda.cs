using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_LP2_2
{
    public partial class FormReportVenda : Form
    {
        private List<Venda> venda = new List<Venda>();

        public FormReportVenda()
        {
            InitializeComponent();
        }

        public FormReportVenda(Venda v)
        {
            InitializeComponent();
            venda.Add(v);
        }

        private void FormReportVenda_Load(object sender, EventArgs e)
        {

            crVenda report = new crVenda();
            report.SetDataSource(venda);
            crystalVenda.ReportSource = report;
            report.Refresh();
        }
    }
}
