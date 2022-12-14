using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FormChonDonDatHang : Form
    {
        public FormChonDonDatHang()
        {
            InitializeComponent();
        }

        private void FormChonDonDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.view_ChonChiTietHoaDon' table. You can move, or remove it, as needed.
            //this.view_ChonChiTietHoaDonTableAdapter.Fill(this.qLVTDataSet.view_ChonChiTietHoaDon);
            /*không kiểm tra khóa ngoại nữa*/
            qLVTDataSet.EnforceConstraints = false;

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVTDataSet.DONDAT);
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /********************************************************
         * tao phieu nhap thi can tu dong dien cac truong sau
         * 1.Ma Don Dat Hang
         * 2.Ma Nhan Vien
         * 3.Ma Kho
         ********************************************************/
        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsDonDatHang.Current));
            //string maNhanVien = drv["MANV"].ToString().Trim();
            string maDonHang = drv["MADD"].ToString().Trim();
            //string maKho = drv["MaKho"].ToString().Trim();

            //if( Program.userName != maNhanVien)
            //{
            //    MessageBox.Show("Bạn không thể lập phiếu trên đơn đặt hàng do người khác tạo", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}

            //int ketQua = kiemTraDonHangCoPhieuNhap(maDonHang);
            
            //if( ketQua == 1)
            //{
            //    MessageBox.Show("Đơn hàng này đã có phiếu nhập không thể tạo thêm", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}    

            Program.maDonDatHangDuocChon = maDonHang;
            //Program.maKhoDuocChon = maKho;

            //Console.WriteLine("Don dat hang duoc chon");
            //Console.WriteLine(maDonHang);
            //Console.WriteLine(maKho);

            this.Close();
        }
    }
}
