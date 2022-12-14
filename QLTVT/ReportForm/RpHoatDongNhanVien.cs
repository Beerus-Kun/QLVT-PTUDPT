using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTVT.ReportForm
{
    public partial class RpHoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public RpHoatDongNhanVien(String maNV, DateTime tuNgay, DateTime denNgay, String tenNV)
        {
            InitializeComponent();

            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maNV;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = denNgay;
            this.sqlDataSource1.Fill();

            txtNhanVien.Text = tenNV;
            txtTuNgay.Text = tuNgay.ToString("dd/MM/yyyy");
            txtDenNgay.Text = denNgay.ToString("dd/MM/yyyy");

        }

    }
}
