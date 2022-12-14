using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections;

namespace QLTVT
{
    public partial class FormKhachHang : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;

        String maChiNhanh = "";
        Stack undoList = new Stack();

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {

            qLVTDataSet.EnforceConstraints = false;

            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.qLVTDataSet.KHACHHANG);

            this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoaDonTableAdapter.Fill(this.qLVTDataSet.HOADON);

            /*van con ton tai loi chua sua duoc*/
            maChiNhanh = ((DataRowView)bdsKhachHang[0])["MACN"].ToString();
            /*Step 2*/
            cmbCHINHANH.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.role == "CONGTY")
            {
                cmbCHINHANH.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                //this.btnCHUYENCHINHANH.Enabled = false;
                this.btnTHOAT.Enabled = true;

                this.panelNhapLieu.Enabled = false;
            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbCHINHANH.Enabled = false;

                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                //this.btnCHUYENCHINHANH.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.panelNhapLieu.Enabled = true;
                //this.txtMANV.Enabled = false;
            }
            //bdsNhanVien.Filter = "MANV='NV2'";
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsKhachHang.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;


            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsKhachHang.AddNew();
            txtMaCN.Text = maChiNhanh;
            txtDiaChi.Text = "97 Man Thiện";
            txtNgaySinh.EditValue = "1995-6-9";
            //chbPhai.Checked = true;

            Random rnd = new Random();
            txtSDT.Text = "0" + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString();
            //dteNGAYSINH.EditValue = "2000-05-01";
            //txtLUONG.Value = 4000000;// dat san muc luong toi thieu


            /*Step 3*/
            //this..Enabled = true;
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            //this.btnCHUYENCHINHANH.Enabled = false;
            this.btnTHOAT.Enabled = false;
            //this.chbDanhDauDaXoa.Checked = false;

            //gridView1.HideFindPanel();

            this.gcKhachHang.Enabled = false;
            this.panelNhapLieu.Enabled = true;
        }

        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 - */
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                //this.txtMANV.Enabled = false;
                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                //this.btnCHUYENCHINHANH.Enabled = true;
                this.btnTHOAT.Enabled = true;
                //this.chbDanhDauDaXoa.Checked = false;

                gridView1.ShowFindPanel();

                this.gcKhachHang.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                bdsKhachHang.CancelEdit();
                /*xoa dong hien tai*/
                //bdsNhanVien.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsKhachHang.Position = viTri;
                this.khachHangTableAdapter.Fill(this.qLVTDataSet.KHACHHANG);
                return;
            }


            /*Step 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                return;
            }

            /*Step 2*/
            bdsKhachHang.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            //Console.WriteLine(cauTruyVanHoanTac);

            if (Program.KetNoi() == 0)
            {
                return;
            }
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            this.khachHangTableAdapter.Fill(this.qLVTDataSet.KHACHHANG);

            if (undoList.Count == 0)
            {
                //MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                //return;
            }
            /*
            bdsNhanVien.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
             */
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.khachHangTableAdapter.Fill(this.qLVTDataSet.KHACHHANG);
                this.gcKhachHang.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = (DataRowView)bdsKhachHang[bdsKhachHang.Position];
            String tenNV = drv["IDKH"].ToString();
            /*Step 1*/

            // khong cho xoa nguoi dang dang nhap ke ca nguoi do khong co don hang - phieu nhap - phieu xuat

            if (bdsKhachHang.Count == 0)
            {
                btnXOA.Enabled = false;
            }

            if (bdsHoaDon.Count > 0)
            {
                MessageBox.Show("Không thể xóa khách hàng, vì khách đã có hóa đơn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            /* Phần này phục vụ tính năng hoàn tác
                    * Đưa câu truy vấn hoàn tác vào undoList 
                    * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/
            //int trangThai = (chbDanhDauDaXoa.Checked == true) ? 1 : 0;
            /*Lấy ngày sinh trong grid view*/
            DateTime NGAYSINH = (DateTime)((DataRowView)bdsKhachHang[bdsKhachHang.Position])["NGAYSINH"];

            string cauTruyVanHoanTac =

                string.Format("INSERT INTO DBO.KHACHHANG( TEN,DIACHI,NGAYSINH,SDT, MACN)" +
            "VALUES('{0}','{1}',CAST({2} AS DATETIME), '{3}','{4}')",
            drv["TEN"].ToString(),
            drv["DIACHI"].ToString(), 
            NGAYSINH.ToString("yyyy-MM-dd"),
            drv["SDT"].ToString(),
            drv["MACN"].ToString());

            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);


            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                viTri = bdsKhachHang.Position;
                try
                {
                    /*Step 3*/
                    bdsKhachHang.RemoveCurrent();

                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Update(this.qLVTDataSet.KHACHHANG);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa khách hàng. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.khachHangTableAdapter.Fill(this.qLVTDataSet.KHACHHANG);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsKhachHang.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            /*Neu combobox khong co so lieu thi ket thuc luon*/
            Console.WriteLine("combo chi nhanh: " + cmbCHINHANH.SelectedValue.ToString());
            if (cmbCHINHANH.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbCHINHANH.SelectedValue.ToString();

            Program.loginName = Program.currentLogin;
            Program.loginPassword = Program.currentPassword;

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            //if ( cmbCHINHANH.SelectedIndex != Program.brand )
            //{
            //    Program.loginName = Program.remoteLogin;
            //    Program.loginPassword = Program.remotePassword;
            //}
            ///*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            //else
            //{
            //    Program.loginName = Program.currentLogin;
            //    Program.loginPassword = Program.currentPassword;
            //}

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {

                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.qLVTDataSet.KHACHHANG);

                this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hoaDonTableAdapter.Fill(this.qLVTDataSet.HOADON);
                /*Tu dong lay maChiNhanh hien tai - phuc vu cho phan btnTHEM*/
                /*Cho dong nay chay thi bi loi*/
                //maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString().Trim();
            }
        }

        private bool kiemTraDuLieuDauVao()
        {
            txtTen.Text = txtTen.Text.Trim();
            txtDiaChi.Text = txtDiaChi.Text.Trim();
            txtSDT.Text = txtSDT.Text.Trim();
            /*kiem tra txtTEN*/
            if (txtTen.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }

            if (Regex.IsMatch(txtTen.Text.Trim(), @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Tên người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }

            if (txtTen.Text.Trim().Length > 50)
            {
                MessageBox.Show("Tên không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }
            /*kiem tra txtDIACHI*/
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            if (Regex.IsMatch(txtDiaChi.Text.Trim(), @"^[a-zA-Z0-9, /ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            if (txtDiaChi.Text.Trim().Length > 100)
            {
                MessageBox.Show("Địa chỉ không được lớn hơn 100 ký tự", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            /*kiem tra dteNGAYSINH*/
            if (CalculateAge(txtNgaySinh.DateTime) < 18)
            {
                MessageBox.Show("Khách hàng chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                txtNgaySinh.Focus();
                //return false;
            }

            if (CalculateAge(txtNgaySinh.DateTime) < 10)
            {
                MessageBox.Show("Khách hàng chưa đủ 10 tuổi", "Thông báo", MessageBoxButtons.OK);
                txtNgaySinh.Focus();
                return false;
            }

            /*kiem tra so dien thoai*/
            if (Regex.IsMatch(txtSDT.Text.Trim(), @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số điện thoại chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
                return false;
            }

            if (txtSDT.Text.Trim().Length < 7)
            {
                MessageBox.Show("Số điện thoại phải từ 7 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
                return false;
            }

            if (txtSDT.Text.Trim().Length > 11)
            {
                MessageBox.Show("Số điện thoại không quá 11 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
                return false;
            }
            return true;
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            /*Step 2*/
            int viTriConTro = bdsKhachHang.Position;
            int viTriMaNhanVien = bdsKhachHang.Find("SDT", txtSDT.Text);

            if (viTriConTro != viTriMaNhanVien && viTriMaNhanVien > -1)
            {
                MessageBox.Show("Số điện thoại đã được sử dụng cho khách hàng khác!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else/*them moi | sua nhan vien*/
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        /*bật các nút về ban đầu*/
                        this.btnTHEM.Enabled = true;
                        this.btnXOA.Enabled = true;
                        this.btnGHI.Enabled = true;
                        this.btnHOANTAC.Enabled = true;

                        this.btnLAMMOI.Enabled = true;
                        // btnCHUYENCHINHANH.Enabled = true;
                        this.btnTHOAT.Enabled = true;

                        //this.txtMANV.Enabled = false;
                        this.bdsKhachHang.EndEdit();
                        //this.bdsNhanVien.ResetCurrentItem();
                        this.khachHangTableAdapter.Update(this.qLVTDataSet.KHACHHANG);
                        this.gcKhachHang.Enabled = true;

                        /*lưu 1 câu truy vấn để hoàn tác yêu cầu*/
                        String cauTruyVanHoanTac = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE FROM DBO.KHACHHANG " +
                                "WHERE SDT = '" + txtSDT.Text.Trim() + "' AND MACN = '" + txtMaCN.Text.Trim() + "'";
                        }
                        /*trước khi ấn btnGHI là sửa thông tin nhân viên*/
                        else
                        {

                            DataRowView drv = ((DataRowView)bdsKhachHang[bdsKhachHang.Position]);
                            String ten = drv["TEN"].ToString();
                            String sdt = drv["SDT"].ToString();
                            String diaChi = drv["DIACHI"].ToString();
                            String ID = drv["IDKH"].ToString();

                            DateTime ngaySinh = ((DateTime)drv["NGAYSINH"]);
                            //DateTime ngaySinh = DateTime.ParseExact(drv["NGAYSINH"].ToString(), "yyyy-MM-dd",
                            //                    System.Globalization.CultureInfo.InvariantCulture);


                            //int luong = int.Parse(drv["LUONG"].ToString());
                            String maChiNhanh = drv["MACN"].ToString();
                            //int trangThai = (chbDanhDauDaXoa.Checked == true) ? 1 : 0;
                            //int phai = (chbPhai.Checked == true) ? 1 : 0;

                            cauTruyVanHoanTac =
                                "UPDATE DBO.KHACHHANG " +
                                "SET " +
                                "TEN = '" + ten + "'," +
                                "DIACHI = '" + diaChi + "'," +
                                "NGAYSINH = CAST('" + ngaySinh.ToString("yyyy-MM-dd") + "' AS DATETIME)," +
                                "SDT = '" + sdt + "'" +
                                "WHERE IDKH = '" + ID + "'";
                        }
                        Console.WriteLine(cauTruyVanHoanTac);

                        /*Đưa câu truy vấn hoàn tác vào undoList 
                         * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/
                        undoList.Push(cauTruyVanHoanTac);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bdsKhachHang.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

    }
}
