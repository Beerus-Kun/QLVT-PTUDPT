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
    public partial class FormChonChiTietDonHang : Form
    {
        public FormChonChiTietDonHang()
        {
            InitializeComponent();
        }

        private void cTDDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsChiTietDonHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void FormChonChiTietDonHang_Load(object sender, EventArgs e)
        {
            qLVTDataSet.EnforceConstraints = false;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVTDataSet.view_ChonChiTietDonDat);
            this.bdsChiTietDonHang.Filter = "MADD = '" + Program.maDonDatHangDuocChonChiTiet + "'";
        }
        /*
         * ta sử dụng maDonDatHangDuocChonChiTiet là vì nếu như ta thêm
         * phiếu nhập cho đơn đặt hàng 1 nhưng chi tiết phiếu nhập ta lại lập
         * bằng chi tiết đơn đặt hàng 2 thì sẽ dẫn tới mâu thuẫn.
         * 
         * đúng thì phải là lập phiếu bằng mã đơn đặt hàng 1 thì chi tiết 
         * phiếu nhập cũng phải chọn chi tiết đơn đặt hàng 1 mới hợp lý
         * 
         * trong formLapPhieu có maDonHangDuocChon là mã đơn hàng của phiếu
         * nhập còn maDonDatHangDuocChonChiTiet là mã đơn hàng khi chọn chi 
         * tiết đơn hàng.
         * 
         * 2 mã này phải giống nhau thì mới cho phép ghi
         */
        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsChiTietDonHang.Current));
            //string maDonHang = drv["MAHH"].ToString().Trim();
            string maVatTu = drv["MAHH"].ToString().Trim();
            Program.maVatTuDuocChon = maVatTu;
            this.Close();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
