using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTVT.ReportForm
{
    public partial class RpBaoCaoNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public RpBaoCaoNhapXuat(DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = denNgay;
            this.sqlDataSource1.Fill();

            txtTuNgay.Text = tuNgay.ToString("dd/MM/yyyy");
            txtDenNgay.Text = denNgay.ToString("dd/MM/yyyy");

        }

    }
}
