using DevExpress.XtraEditors;
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
using System.Text.RegularExpressions;

namespace QLTVT.SubForm
{
    public partial class FormChuyenChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        
        public FormChuyenChiNhanh()
        {
            InitializeComponent();
        }
       

        private void FormChuyenChiNhanh_Load(object sender, EventArgs e)
        { 
            /*Lấy dữ liệu từ form đăng nhập đổ vào nhưng chỉ lấn đúng danh sách
             phân mảnh mà thôi*/
            cmbCHINHANH.DataSource  = Program.bindingSource.DataSource;
            /*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "tencn";
            cmbCHINHANH.ValueMember = "tenserver";
            cmbCHINHANH.SelectedIndex = Program.brand;

            txtMANVCU.Text = Program.userName;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        /************************************************************
         * tạo delegate - một cái biến mà khi được gọi, nó sẽ thực hiện 1 hàm(function) khác
         * Ví dụ: ở class formNhanVien, ta có hàm chuyển chi nhánh, hàm này cần 1 tham số, chính
         * là tên server được chọn ở formChuyenChiNhanh này. Để gọi được hàm chuyển chi nhánh ở formNHANVIEN
         * Chúng ta khai báo 1 delete là branchTransfer để gọi hàm chuyển chi nhánh về form này
         *************************************************************/
        public delegate void MyDelegate(string chiNhanh, String maNVMoi);
        public MyDelegate branchTransfer;
        private void btnXACNHAN_Click(object sender, EventArgs e)
        {

            if (txtMANVMOI.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                txtMANVMOI.Focus();
                return ;
            }

            if (Regex.IsMatch(txtMANVMOI.Text.Trim(), @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã nhân viên chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtMANVMOI.Focus();
                return ;
            }

            if (txtMANVMOI.Text.Trim().Length > 20)
            {
                MessageBox.Show("Mã nhân viên không được quá 20 ký tự", "Thông báo", MessageBoxButtons.OK);
                txtMANVMOI.Focus();
                return ;
            }

            if (cmbCHINHANH.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (Program.serverName == cmbCHINHANH.SelectedValue.ToString())
            {
                MessageBox.Show("Hãy chọn chi nhánh khác chi nhánh bạn đang đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String maNhanVien = txtMANVMOI.Text.Trim();// Trim() de loai bo khoang trang thua


            /*declare @returnedResult int
              exec @returnedResult = sp_TraCuu_KiemTraMaNhanVien '20'
              select @returnedResult*/
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_TraCuu_KiemTraMaNhanVien] '" +
                    maNhanVien + "' " +
                    "SELECT 'Value' = @result"; ;
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            if (result == 1)
            {
                MessageBox.Show("Mã nhân viên này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                txtMANVMOI.Focus();
                return;
            }

            /*Step 2*/
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chuyển nhân viên này đi ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if( dialogResult == DialogResult.OK)
            {
                branchTransfer(cmbCHINHANH.SelectedValue.ToString(), txtMANVMOI.Text.Trim());
            }
                
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}