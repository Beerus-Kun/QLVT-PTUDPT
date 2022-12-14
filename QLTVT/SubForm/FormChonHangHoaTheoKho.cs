using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FormChonHangHoaTheoKho : Form
    {
        public FormChonHangHoaTheoKho()
        {
            InitializeComponent();
        }

        private void FormChonHangHoaTheoKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.view_ChonChiTietHoaDon' table. You can move, or remove it, as needed.
            //this.cthdTableAdapter.Fill(this.qLVTDataSet.view_ChonChiTietHoaDon);

            qLVTDataSet.EnforceConstraints = false;
            this.cthdTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cthdTableAdapter.Fill(this.qLVTDataSet.view_ChonChiTietHoaDon);
            this.bdsChiTietHoaDon.Filter = "MAKHO = '" + Program.maKhoDuocChon + "'";

        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsChiTietHoaDon.Current));
            //string maDonHang = drv["MAHH"].ToString().Trim();
            string maVatTu = drv["MAHH"].ToString().Trim();

            Program.donGia = drv["DONGIA"].ToString().Trim();
            Program.maVatTuDuocChon = maVatTu;
            this.Close();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
