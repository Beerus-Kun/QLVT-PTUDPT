using DevExpress.XtraEditors;
using QLTVT.SubForm;
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

namespace QLTVT
{
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        //private string taiKhoan = "";
        //private string matKhau = "";
        //private string maNhanVien = "";
        //private string vaiTro = "";
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChonNhanVien_Click(object sender, EventArgs e)
        {
            FormChonNhanVien form = new FormChonNhanVien();
            form.ShowDialog();

            txtMaNhanVien.Text = Program.maNhanVienDuocChon;
            txtUsername.Text = Program.maNhanVienDuocChon;
        }

        private bool kiemTraDuLieuDauVao()
        {
            if( txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Thiếu mã nhân viên","Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if( txtMatKhau.Text == "" )
            {
                MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if(txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtXacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if( txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }    

            return true;
        } 

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            // kiem tra username - ma NV
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_KiemTraUser] '" +
                    txtMaNhanVien.Text.Trim() + "' " +
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

            if (result == 0 )
            {
                MessageBox.Show("Mã nhân viên này đã được tạo tài khoản !", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string serverHienTai = Program.serverName;

            if (Program.role == "CHINHANH")
            {
                // kiem tra login
                cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_KiemTraLogin] '" +
                    txtUsername.Text.Trim() + "' " +
                    "SELECT 'Value' = @result"; ;
                sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
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
                result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result == 0)
                {
                    MessageBox.Show("Tên đăng nhập đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                // tai khoan
                cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_TaoTaiKhoan] '" +
                    txtUsername.Text.Trim() + "', '" +
                    txtMatKhau.Text.Trim() + "', '" +
                    txtMaNhanVien.Text.Trim() + "', '" +
                    Program.role + "' "; 
                sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
                try
                {
                    Program.ExecSqlNonQuery(cauTruyVan);
                    
                    MessageBox.Show("Đăng kí tài khoản thành công\n\n", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return;
                }
                
            }

            if(Program.role == "CONGTY")
            {
                // kiem tra login

                for (int i = 0; i < Program.bindingSource.Count; i++)
                {
                    DataRowView drv = ((DataRowView)Program.bindingSource[i]);
                    Program.serverName = drv["TENSERVER"].ToString().Trim();

                    Program.KetNoi();

                    cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_KiemTraLogin] '" +
                    txtUsername.Text.Trim() + "' " +
                    "SELECT 'Value' = @result";
                    sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
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
                    result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result == 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                }

                // tao tai khoan 2 noi
                for (int i = 0; i < Program.bindingSource.Count; i++)
                {
                    DataRowView drv = ((DataRowView)Program.bindingSource[i]);
                    //drv["TENSERVER"].ToString();
                    Program.serverName = drv["TENSERVER"].ToString().Trim();

                    Program.KetNoi();

                    cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_TaoTaiKhoan] '" +
                    txtUsername.Text.Trim() + "', '" +
                    txtMatKhau.Text.Trim() + "', '" +
                    txtMaNhanVien.Text.Trim() + "', '" +
                    Program.role + "' ";
                    sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
                    try
                    {
                        Program.ExecSqlNonQuery(cauTruyVan);
                        /*khong co ket qua tra ve thi ket thuc luon*/
                        if (Program.myReader == null)
                        {
                            return;
                        }

                        MessageBox.Show("Đăng kí tài khoản thành công\n\n", "Thông Báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }

                Program.serverName = serverHienTai;
                Program.KetNoi();
            }

            txtMaNhanVien.Text = "";
            txtMatKhau.Text = "";
            txtXacNhanMatKhau.Text = "";
            txtUsername.Text = "";
            
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            
        }
    }
}