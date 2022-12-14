using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTVT.ReportForm
{
    public partial class RpTongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public RpTongHopNhapXuat(int thangBD, int namBD, int thangKT, int namKT, string NX, string vitri)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = thangBD;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = namBD;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = thangKT;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = namKT;
            this.sqlDataSource1.Queries[0].Parameters[4].Value = NX;
            this.sqlDataSource1.Queries[0].Parameters[5].Value = vitri;
            this.sqlDataSource1.Fill();

            if(NX == "N")
            {
                txtTuaDe.Text = "CHI TIẾT SỐ LƯỢNG HÀNG NHẬP";
            }
            else
            {
                txtTuaDe.Text = "CHI TIẾT SỐ LƯỢNG HÀNG XUẤT";
            }

            txtTuThang.Text = thangBD + "/" + namBD;
            txtDenThang.Text = thangKT + "/" + namKT;

        }

    }
}
