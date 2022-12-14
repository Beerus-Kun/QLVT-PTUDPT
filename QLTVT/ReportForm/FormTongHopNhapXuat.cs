using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.ReportForm
{
    public partial class FormTongHopNhapXuat : Form
    {
        public FormTongHopNhapXuat()
        {
            InitializeComponent();
        }

        private void FormTongHopNhapXuat_Load(object sender, EventArgs e)
        {

            dteTuNgay.EditValue = "01-06-2022";
            dteToiNgay.EditValue = "01-12-2022";  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dteToiNgay.EditValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày kết thúc", "", MessageBoxButtons.OK);
                return; 
            }

            if (dteTuNgay.EditValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu", "", MessageBoxButtons.OK);
                return;
            }
            Console.WriteLine(dteToiNgay.DateTime.Month);
            Console.WriteLine(dteToiNgay.DateTime.Year);
            Console.WriteLine(dteTuNgay.DateTime.Month);
            Console.WriteLine(dteTuNgay.DateTime.Year);

            RpTongHopNhapXuat report = new RpTongHopNhapXuat(dteTuNgay.DateTime.Month, dteTuNgay.DateTime.Year, dteToiNgay.DateTime.Month, dteToiNgay.DateTime.Year, "N", Program.role);

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dteToiNgay.EditValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày kết thúc", "", MessageBoxButtons.OK);
                return;
            }

            if (dteTuNgay.EditValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu", "", MessageBoxButtons.OK);
                return;
            }
            Console.WriteLine(dteToiNgay.DateTime.Month);
            Console.WriteLine(dteToiNgay.DateTime.Year);
            Console.WriteLine(dteTuNgay.DateTime.Month);
            Console.WriteLine(dteTuNgay.DateTime.Year);

            RpTongHopNhapXuat report = new RpTongHopNhapXuat(dteTuNgay.DateTime.Month, dteTuNgay.DateTime.Year, dteToiNgay.DateTime.Month, dteToiNgay.DateTime.Year, "X", Program.role);

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
