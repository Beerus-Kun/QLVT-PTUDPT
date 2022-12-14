using DevExpress.XtraReports.UI;
using QLTVT.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.ReportForm
{
    public partial class FormHoatDongNhanVien : Form
    {
        public FormHoatDongNhanVien()
        {
            InitializeComponent();
        }

        private void btnChonNhanVien_Click(object sender, EventArgs e)
        {
            FormChonNhanVien form = new FormChonNhanVien();
            form.ShowDialog();

            txtMaNhanVien.Text = Program.maNhanVienDuocChon;
            //txtHoVaTen.Text = Program.hoTen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text;
            //string loaiPhieu = (cmbLoaiPhieu.SelectedIndex == 1) ? "N" : "X";
            DateTime fromDate = dteTuNgay.DateTime;
            DateTime toDate = dteToiNgay.DateTime;
            /*
            int fromYear = dteTuNgay.DateTime.Year;
            int fromMonth = dteTuNgay.DateTime.Month;
            int toYear = dteToiNgay.DateTime.Year;
            int toMonth = dteToiNgay.DateTime.Month;
            */
            if(txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "", MessageBoxButtons.OK);
                return;
            }
            if (dteTuNgay.EditValue.ToString().Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu", "", MessageBoxButtons.OK);
                return;
            }
            if (dteToiNgay.EditValue.ToString().Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày kết thúc", "", MessageBoxButtons.OK);
                return;
            }


            RpHoatDongNhanVien report = new RpHoatDongNhanVien(maNhanVien, fromDate, toDate, Program.hoTen);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void FormHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            //cmbLoaiPhieu.SelectedIndex = 1;
            dteTuNgay.EditValue = "1/6/2022";
            dteToiNgay.EditValue = "1/12/2022";
        }


    }
}
