using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTVT.ReportForm
{
    public partial class RpDonHangKhongPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public RpDonHangKhongPhieuNhap()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();

        }

    }
}
