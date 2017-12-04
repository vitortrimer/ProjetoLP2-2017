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
    public partial class FormReportVendedor : Form
    {
        FuncionarioDAO funcionario = new FuncionarioDAO();
        List<Funcionario> f = new List<Funcionario>();

       

        public FormReportVendedor()
        {
            InitializeComponent();
        }

        public FormReportVendedor(List<Funcionario> func)
        {
            InitializeComponent();
            f = func;
        }

        private void FormReportVendedor_Load(object sender, EventArgs e)
        {
            crVendasVendedor report = new crVendasVendedor();
            report.SetDataSource(f);
            crystalReportViewer1.ReportSource = report;
            report.Refresh();
        }
    }
}
