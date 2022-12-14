using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace QLTVT.ReportForm
{
    public partial class FormBaoCaoNhapXuat : Form
    {
        public FormBaoCaoNhapXuat()
        {
            InitializeComponent();
            dteTuNgay.EditValue = "1/6/2022";
            dteToiNgay.EditValue = "1/12/2022";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dteTuNgay.EditValue.ToString() == "")
            {
                dteTuNgay.Focus();
                MessageBox.Show("Vui lòng nhập ngày bắt đầu\n", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (dteToiNgay.EditValue.ToString() == "")
            {
                dteToiNgay.Focus();
                MessageBox.Show("Vui lòng nhập ngày kết thúc\n", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            RpBaoCaoNhapXuat report = new RpBaoCaoNhapXuat(dteTuNgay.DateTime, dteToiNgay.DateTime);
           
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
