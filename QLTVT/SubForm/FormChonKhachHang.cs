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
    public partial class FormChonKhachHang : Form
    {
        public FormChonKhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhachHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void FormChonKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            

            qLVTDataSet.EnforceConstraints = false;
            this.kHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHACHHANGTableAdapter.Fill(this.qLVTDataSet.KHACHHANG);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maVatTu = ((DataRowView)bdsKhachHang.Current)["IDKH"].ToString();
            //int soLuongVatTu = int.Parse( ((DataRowView)bdsVatTu.Current)["SOLUONGTON"].ToString() );

            Program.maKhachHangDuocChon = maVatTu;
            //Program.soLuongVatTu = soLuongVatTu;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
