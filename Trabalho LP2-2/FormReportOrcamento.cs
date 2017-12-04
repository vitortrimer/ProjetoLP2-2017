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
    public partial class FormReportOrcamento : Form
    {
        List<Venda> venda = new List<Venda>();
        public FormReportOrcamento()
        {
            InitializeComponent();
        }

        public FormReportOrcamento(Venda v)
        {
            InitializeComponent();
            venda.Add(v);
        }

        private void FormReportOrcamento_Load(object sender, EventArgs e)
        {
            crOrcamento report = new crOrcamento();
            report.SetDataSource(venda);
            crvOrcamento.ReportSource = report;
            report.Refresh();
        }
    }
}
