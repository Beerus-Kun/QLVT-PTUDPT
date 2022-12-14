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
using QLTVT.SubForm;
using System.Collections;

namespace QLTVT
{
    public partial class FormHoaDon : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        public string makho = "";
        //string maChiNhanh = "";
        Stack undoList = new Stack();
        bool isXem = true;
        bool isChinhSuaHang = false;
        bool isChinhSuaDon = false;

        int sl = 0, dongia = 0;

        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsHoaDon.Position;

            //groupBoxPhieuNhap.Enabled = true;
            //groupBox1.Enabled = false;

            txtSL.Enabled = false;
            txtMaHH.Enabled = false;
            btnChonVatTu.Enabled = false;

            gcCTPN.Enabled = false;
            gcPhieuNhap.Enabled = false;

            dangThemMoi = true;

            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsHoaDon.AddNew();

            this.txtMaHD.Enabled = true;
            this.txtMaKH.Enabled = true;
            this.cmbMAKHO.Enabled = true;
            this.cmbMAKHO.SelectedIndex = 0;

            ((DataRowView)(bdsHoaDon.Current))["MANV"] = Program.userName;
            ((DataRowView)(bdsHoaDon.Current))["NGAYLAP"] = DateTime.Now;

            /*Step 3*/
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnXem.Enabled = false;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnMENU.Enabled = false;
            this.btnThem2.Enabled = false;
            this.btnTHOAT.Enabled = false;
            this.btnChonKhach.Enabled = true;

            isChinhSuaDon = true;
            isChinhSuaHang = false;
        }
        private bool kiemTraDon()
        {
            txtMaHD.Text = txtMaHD.Text.Trim();
            txtMaKH.Text = txtMaKH.Text.Trim();
            if (txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Không thể bỏ trống mã hóa đơn", "Thông báo", MessageBoxButtons.OK);
                txtMaHD.Focus();
                return false;
            }
            if (txtMaHD.Text.Trim().Length > 20)
            {
                MessageBox.Show("Mã phiếu nhập không quá 20 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaHD.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMaHD.Text.Trim(), @"^[A-Za-z0-9-]+$") == false)
            {
                MessageBox.Show("Mã hóa đơn chỉ có chữ cái, số và dấu '-'", "Thông báo", MessageBoxButtons.OK);
                txtMaHD.Focus();
                return false;
            }

            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Không thể bỏ trống mã khách hàng", "Thông báo", MessageBoxButtons.OK);
                txtMaKH.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMaKH.Text.Trim(), @"^[0-9]+$") == false)
            {
                MessageBox.Show("Mã khách hàng chỉ chứa số", "Thông báo", MessageBoxButtons.OK);
                txtMaKH.Focus();
                return false;
            }
            if (bdsKhachHang.Find("IDKH", txtMaKH.Text.Trim()) == -1)
            {
                MessageBox.Show("Mã khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK);
                txtMaKH.Focus();
                return false;
            }

            return true;
        }

        private bool kiemTraHang()
        {
            txtMaHH.Text = txtMaHH.Text.Trim();
            if (txtMaHH.Text.Trim() == "")
            {
                MessageBox.Show("Không thể bỏ trống mã hàng hóa", "Thông báo", MessageBoxButtons.OK);
                txtMaHH.Focus();
                return false;
            }
            if (txtMaHH.Text.Trim().Length > 20)
            {
                MessageBox.Show("Mã hàng hóa không quá 20 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaHH.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMaHH.Text.Trim(), @"^[A-Za-z0-9-]+$") == false)
            {
                MessageBox.Show("Mã hàng hóa chỉ có chữ cái, số và dấu '-'", "Thông báo", MessageBoxButtons.OK);
                txtMaHH.Focus();
                return false;
            }
            if (bdsHangHoa.Find("MAHH", txtMaHH.Text) == -1)
            {
                MessageBox.Show("Mã hàng hóa không tồn tại", "Thông báo", MessageBoxButtons.OK);
                txtMaHH.Focus();
                return false;
            }

            if (sl <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
                txtSL.Focus();
                return false;
            }

            //if (dongia <= 0)
            //{
            //    MessageBox.Show("Đơn giá phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
            //    txtDonGia.Focus();
            //    return false;
            //}
            return true;
        }
        private String taoCauTruyVanHoanTac()
        {
            String cauTruyVan = "";
            DataRowView drv;

            /*Dang chinh sua don dat hang*/
            if (isChinhSuaDon == true && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);

                cauTruyVan = "UPDATE DBO.HOADON " +
                    "SET " +
                    "NGAYLAP = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATETIME), " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "IDKH = " + drv["IDKH"].ToString().Trim() + " " +
                    "WHERE MAHD = '" + drv["MAHD"].ToString().Trim() + "'";
            }
            /*Dang xoa don dat hang*/
            if (isChinhSuaDon == true && dangThemMoi == true)
            {
                //drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                cauTruyVan = "DELETE FROM DBO.HOADON " +
                "WHERE MAHD = '" + txtMaHD.Text.Trim() + "'";
            }

            /*Dang chinh sua chi tiet don dat hang*/
            if (isChinhSuaHang == true && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsCTHD[bdsCTHD.Position]);

                cauTruyVan = "UPDATE DBO.CTHD " +
                    "SET " +
                    "SL = " + drv["SL"].ToString() + " , " +
                    "DONGIA = " + drv["DONGIA"].ToString() + " " +
                    "WHERE MAHD = '" + drv["MAHD"].ToString().Trim() + "'" +
                    " AND MAHH = '" + drv["MAHH"].ToString().Trim() + "'";

            }

            if (isChinhSuaHang == true && dangThemMoi == true)
            {
                //drv = ((DataRowView)bdsCTHD[bdsCTHD.Position]);
                cauTruyVan = "DELETE FROM DBO.CTHD " +
                                "WHERE MAHD = '" + txtMaHD.Text.Trim() + "' " +
                                "AND MAHH = '" + txtMaHH.Text.Trim() + "'";
            }
            return cauTruyVan;
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsHoaDon.Position;
            bool ketQua = true;

            if (isChinhSuaHang == true)
            {
                try
                {
                    sl = int.Parse(txtSL.Text.Trim().Replace(",", ""));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Số lượng chỉ nhận số nguyên dương", "Thông báo", MessageBoxButtons.OK);
                    txtSL.Focus();
                    return;
                }

                try
                {
                    dongia = int.Parse(txtDonGia.Text = txtDonGia.Text.Trim().Replace(",", ""));
                }
                catch (Exception ex)
                {
                    dongia = 0;
                }

                ketQua = kiemTraHang();

                if(dangThemMoi == false)
                {
                        String maDonDatHangMoi = txtMaHD.Text.Trim();

                        String cauTruyVan =
                                "DECLARE	@result int " +
                                "EXEC @result = sp_ThayDoiChiTietHoaDon '" +
                                cmbMAKHO.SelectedValue.ToString().Trim() + "', '" +
                                txtMaHH.Text.Trim() + "', '" +
                                maDonDatHangMoi + "', " +
                                sl + " " +
                                "SELECT 'Value' = @result";
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
                            MessageBox.Show("Không tìm thấy số lượng hàng cũ trong hóa đơn !\n\n", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (result == 2)
                        {
                            MessageBox.Show("Hàng hóa này đã hết hàng, không thể sửa !\n\n", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DataRowView drv = ((DataRowView)bdsCTHD[bdsCTHD.Position]);
                        txtSL.Text = drv["SL"].ToString().Trim();
                        return;
                        }
                        if (result < 0)
                        {
                            MessageBox.Show("Hàng hóa này có thể đổi tối đa " + result * -1 + " sản phẩm !\n\n", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    
                }
            }
            if (isChinhSuaDon == true)
            {
                ketQua = kiemTraDon();
            }
            if (ketQua == false) return;

            String cauTruyVanHoanTac;


            /*Step 3*/
            if (dangThemMoi && isChinhSuaDon)
            {
                String maDonDatHangMoi = txtMaHD.Text.Trim();
                String cauTruyVan =
                        "DECLARE	@result int " +
                        "EXEC @result = sp_KiemTraMaHoaDon '" +
                        maDonDatHangMoi + "' " +
                        "SELECT 'Value' = @result";
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
                    MessageBox.Show("Mã hóa đơn đã được sử dụng!\n\n", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (dangThemMoi && isChinhSuaHang)
            {
                String maDonDatHangMoi = txtMaHD.Text.Trim();

                String cauTruyVan =
                        "DECLARE	@result int " +
                        "EXEC @result = sp_KiemTraMaChiTietHoaDon '" +
                        cmbMAKHO.SelectedValue.ToString().Trim() + "', '" + 
                        txtMaHH.Text.Trim() + "', '" +
                        maDonDatHangMoi + "', " +
                        sl + " " +
                        "SELECT 'Value' = @result";
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
                    MessageBox.Show("Hàng hóa này đã có trong hóa đơn !\n\n", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (result == 2)
                {
                    MessageBox.Show("Không có hàng hóa này trong kho !\n\n", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (result < 0)
                {
                    MessageBox.Show("Hàng hóa này chỉ còn "+ result * -1 + " sản phẩm !\n\n", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(dongia == 0)
                {
                    DataRowView drv = ((DataRowView)bdsHangHoa[bdsHangHoa.Find("MAHH", txtMaHH.Text.Trim())]);
                    txtDonGia.Text = drv["DONGIA"].ToString().Trim();
                    dongia = int.Parse(drv["DONGIA"].ToString().Trim().Replace(",", ""));
                }
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    cauTruyVanHoanTac = taoCauTruyVanHoanTac();
                    undoList.Push(cauTruyVanHoanTac);

                    this.bdsHoaDon.EndEdit();
                    this.bdsCTHD.EndEdit();
                    this.hoaDonTableAdapter.Update(this.qLVTDataSet.HOADON);
                    this.cthdTableAdapter.Update(this.qLVTDataSet.CTHD);
                    this.btnTHEM.Enabled = true;
                    this.btnThem2.Enabled = true;
                    this.btnXOA.Enabled = true;
                    this.btnGHI.Enabled = true;

                    this.btnHOANTAC.Enabled = true;
                    this.btnLAMMOI.Enabled = true;
                    this.btnMENU.Enabled = true;
                    this.btnTHOAT.Enabled = true;

                    this.btnChonKhach.Enabled = false;
                    this.txtMaHD.Enabled = false;
                    this.txtMaKH.Enabled = false;
                    this.cmbMAKHO.Enabled = false;
                    this.txtMaHH.Enabled = false;
                    this.btnChonVatTu.Enabled = false;

                    gcCTPN.Enabled = true;
                    gcPhieuNhap.Enabled = true;
                    Console.WriteLine(10000);
                    /*cập nhật lại trạng thái thêm mới cho chắc*/
                    dangThemMoi = false;
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    if (isChinhSuaDon)
                    {
                        bdsHoaDon.RemoveCurrent();
                    }
                    if (isChinhSuaHang)
                    {
                        bdsCTHD.RemoveCurrent();
                    }
                    MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


        }

        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true)
            {
                dangThemMoi = false;
                bdsHoaDon.Position = viTri;
                /*dang o che do Don Dat Hang*/
                if (isChinhSuaDon == true)
                {
                    this.txtMaHD.Enabled = false;

                    bdsHoaDon.CancelEdit();
                    checkDonHang();
                }
                /*dang o che do Chi Tiet Don Dat Hang*/
                if (isChinhSuaHang == true)
                {
                    txtMaHH.Enabled = false;
                    txtSL.Enabled = false;
                    //txtDonGia.Enabled = false;
                    btnChonVatTu.Enabled = false;

                    bdsCTHD.CancelEdit();
                }

                this.btnTHEM.Enabled = true;
                this.btnThem2.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                //this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.hoaDonTableAdapter.Fill(this.qLVTDataSet.HOADON);
                this.cthdTableAdapter.Fill(this.qLVTDataSet.CTHD);

                gcCTPN.Enabled = true;
                gcPhieuNhap.Enabled = true;

                bdsHoaDon.Position = viTri;
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
            if (isChinhSuaDon)
            {
                bdsHoaDon.CancelEdit();
            }
            if (isChinhSuaHang)
            {
                bdsCTHD.CancelEdit();
            }
            //bds.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            if (undoList.Count == 0)
            {
                //MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                //return;
            }

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.hoaDonTableAdapter.Fill(this.qLVTDataSet.HOADON);
            this.cthdTableAdapter.Fill(this.qLVTDataSet.CTHD);
            bdsHoaDon.Position = viTri;
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.hoaDonTableAdapter.Fill(this.qLVTDataSet.HOADON);
                this.cthdTableAdapter.Fill(this.qLVTDataSet.CTHD);

                this.gcPhieuNhap.Enabled = true;
                this.gcCTPN.Enabled = true;

                bdsHoaDon.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnChonVatTu_Click(object sender, EventArgs e)
        {
            Program.maKhoDuocChon = cmbMAKHO.SelectedValue.ToString().Trim();
            FormChonHangHoaTheoKho form = new FormChonHangHoaTheoKho();
            form.ShowDialog();
            this.txtMaHH.Text = Program.maVatTuDuocChon;
            this.txtDonGia.Text = Program.donGia;
            Program.maKhoDuocChon = "";
            Program.maVatTuDuocChon = "";
            Program.donGia = "";
        }

        private void btnChonKhach_Click(object sender, EventArgs e)
        {
            FormChonKhachHang form = new FormChonKhachHang();
            form.ShowDialog();
            this.txtMaKH.Text = Program.maKhachHangDuocChon;
            Program.maKhachHangDuocChon = "";
        }

        private bool kiemTraHopLeHang(int sl)
        {
            //sl = int.Parse(txtSL.Text.Trim().Replace(",", ""));
            String cauTruyVan =
                        "DECLARE	@result int " +
                        "EXEC @result = sp_KiemTraMaChiTietHoaDon '" + cmbMAKHO.SelectedValue.ToString().Trim() + "', '" +
                        txtMaHH.Text.Trim() + "', '" +
                        txtMaHD.Text.Trim() + "', " +
                        sl + " " +
                        "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if (result == 1)
            {
                MessageBox.Show("Hàng hóa này đã có trong hóa đơn !\n\n", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (result == 2)
            {
                MessageBox.Show("Hàng hóa này không có trong kho !\n\n", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (result <0 )
            {
                MessageBox.Show("Kho chỉ còn " + result  * -1+ " sản phẩm của hàng hóa này!\n\n", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cauTruyVan = "";
            //string cheDo = (btnMENU.Links[0].Caption == "Đơn Đặt Hàng") ? "Đơn Đặt Hàng" : "Chi Tiết Đơn Đặt Hàng";

            //dangThemMoi = true;// bat cai nay len de ung voi dieu kien tao cau truy van

            if (isChinhSuaDon)
            {
                /*Cái bdsChiTietDonHangHang là đại diện cho binding source riêng biệt của CTDDH
                 *Còn cTDDHBindingSource là lấy ngay từ trong data source DATHANG
                 */
                if (bdsCTHD.Count > 0)
                {
                    MessageBox.Show("Không thể xóa hóa đơn này vì có chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                DataRowView drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);

                cauTruyVan = "INSERT INTO DBO.HOADON(IDKH, MAKHO, MAHD, NGAYLAP, MANV) " +
                    "VALUES(" + drv["IDKH"].ToString() + ", '" +
                    drv["MAKHO"].ToString() + "', '" +
                    drv["MAHD"].ToString() + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["MANV"].ToString() + "' )";
            }
            if (isChinhSuaHang)
            {
                //if (!kiemTraHopLeHang(0))
                //{
                //    return;
                //}

                DataRowView drv = ((DataRowView)bdsCTHD[bdsCTHD.Position]);

                cauTruyVan = "INSERT INTO DBO.CTHD(MAHD, MAHH, DONGIA, SL) " +
                    "VALUES('" + drv["MAHD"] + "', '" +
                    drv["MAHH"].ToString() + "', " +
                    drv["DONGIA"].ToString() + ", " +
                    drv["SL"].ToString() + " )";
            }
            undoList.Push(cauTruyVan);

            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    //viTri = 0;
                    //viTri = bdsHoaDon.Position;

                    if (isChinhSuaDon)
                    {
                        
                        bdsHoaDon.RemoveCurrent();
                        this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.hoaDonTableAdapter.Update(this.qLVTDataSet.HOADON);
                    }
                    if (isChinhSuaHang)
                    {
                        //viTri = bdsCTHD.Position;
                        bdsCTHD.RemoveCurrent();
                        this.cthdTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cthdTableAdapter.Update(this.qLVTDataSet.CTHD);
                    }

                    viTri = bdsHoaDon.Position;


                    this.cthdTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cthdTableAdapter.Fill(this.qLVTDataSet.CTHD);

                    this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hoaDonTableAdapter.Fill(this.qLVTDataSet.HOADON);

                    viTri = bdsHoaDon.Position;

                    /*Cap nhat lai do ben tren can tao cau truy van nen da dat dangThemMoi = true*/
                    //dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.cthdTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cthdTableAdapter.Fill(this.qLVTDataSet.CTHD);

                    this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hoaDonTableAdapter.Fill(this.qLVTDataSet.HOADON);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsHoaDon.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            else
            {
                // xoa cau truy van hoan tac di
                undoList.Pop();
            }
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            /*Neu combobox khong co so lieu thi ket thuc luon*/
            if (cmbCHINHANH.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbCHINHANH.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbCHINHANH.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.hangHoaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hangHoaTableAdapter.Fill(this.qLVTDataSet.HANGHOA);

                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.qLVTDataSet.KHO);

                this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hoaDonTableAdapter.Fill(this.qLVTDataSet.HOADON);

                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.qLVTDataSet.KHACHHANG);

                this.cthdTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cthdTableAdapter.Fill(this.qLVTDataSet.CTHD);
            }
        }
        private void checkDonHang()
        {
            if (isXem == false && (Program.role == "CHINHANH" || Program.role == "USER"))
            {
                isChinhSuaHang = false;
                isChinhSuaDon = true;

                txtMaHD.Enabled = false;
                txtMaKH.Enabled = true;
                cmbMAKHO.Enabled = true;
                btnChonKhach.Enabled = true;

                btnThem2.Enabled = true;

                if (bdsCTHD.Count > 0)
                {
                    //txtMaHD.Enabled = false;
                    txtMaKH.Enabled = false;
                    cmbMAKHO.Enabled = false;
                    //btnThem2.Enabled = true;
                    btnChonKhach.Enabled = false;
                }

                if(bdsHoaDon.Count == 0)
                {
                    btnThem2.Enabled = false;
                }

                txtMaHH.Enabled = false;
                txtSL.Enabled = false;
                //txtDonGia.Enabled = false;
                btnChonVatTu.Enabled = false;
            }
        }

        private void checkHangHoa()
        {
            if (isXem == false && (Program.role == "CHINHANH" || Program.role == "USER") && isChinhSuaDon == true && bdsCTHD.Count > 0)
            {
                txtMaHD.Enabled = false;
                txtMaKH.Enabled = false;
                cmbMAKHO.Enabled = false;
                btnChonKhach.Enabled = false;

                txtMaHH.Enabled = false;
                txtSL.Enabled = true;
                //txtDonGia.Enabled = true;
                btnChonVatTu.Enabled = false;
            }
        }

        private void gcPhieuNhap_Click(object sender, EventArgs e)
        {
            checkDonHang();
            isChinhSuaDon = true;
            isChinhSuaHang = false;
        }

        private void gcCTPN_Click(object sender, EventArgs e)
        {
            checkHangHoa();
            isChinhSuaHang = true;
            isChinhSuaDon = false;
        }

        private void btnXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isXem = !isXem;

            // chế độ xem, không cho chỉnh sửa
            if (isXem == true)
            {
                btnXem.Caption = "Chỉnh sửa";
                groupBox1.Enabled = false;
                groupBoxPhieuNhap.Enabled = false;

                bdsHoaDon.Filter = "1=1";

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = false;
                this.btnThem2.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = false;
            }
            // chế độ chỉnh sửa
            else
            {
                btnXem.Caption = "Xem toàn bộ";
                bdsHoaDon.Filter = "MANV = '" + Program.userName + "'";

                groupBox1.Enabled = true;
                groupBoxPhieuNhap.Enabled = true;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsHoaDon.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = true;
                this.btnThem2.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;

                this.txtMaHD.Enabled = false;
                this.txtMaKH.Enabled = false;
                this.btnChonKhach.Enabled = false;
                //isChinhSuaDon = true;
                checkDonHang();
            }


        }

        private void btnThem2_ItemClick(object sender, EventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsHoaDon.Position;

            //groupBoxPhieuNhap.Enabled = false;
            //groupBox1.Enabled = true;

            txtMaHD.Enabled = false;
            txtMaKH.Enabled = false;
            cmbMAKHO.Enabled = false;
            btnChonKhach.Enabled = false;

            gcCTPN.Enabled = false;
            gcPhieuNhap.Enabled = false;

            dangThemMoi = true;

            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsCTHD.AddNew();

            this.txtMaHH.Enabled = true;
            //this.txtDonGia.Enabled = true;
            this.txtSL.Enabled = true;
            this.btnChonVatTu.Enabled = true;
            this.btnThem2.Enabled = false;

            ((DataRowView)(bdsCTHD.Current))["MAHD"] = txtMaHD.Text;

            /*Step 3*/
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;
            this.btnXem.Enabled = false;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnMENU.Enabled = false;
            this.btnTHOAT.Enabled = false;

            isChinhSuaDon = false;
            isChinhSuaHang = true;
        }


        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            qLVTDataSet.EnforceConstraints = false;

            this.hangHoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hangHoaTableAdapter.Fill(this.qLVTDataSet.HANGHOA);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVTDataSet.KHO);

            this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoaDonTableAdapter.Fill(this.qLVTDataSet.HOADON);

            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.qLVTDataSet.KHACHHANG);

            this.cthdTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cthdTableAdapter.Fill(this.qLVTDataSet.CTHD);

            cmbCHINHANH.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            txtMaHD.Enabled = false;
            cmbMAKHO.Enabled = false;
            txtMaKH.Enabled = false;
            btnChonKhach.Enabled = false;

            txtMaHH.Enabled = false;
            btnChonVatTu.Enabled = false;
            txtSL.Enabled = false;
            //txtDonGia.Enabled = false;

            gcPhieuNhap.Enabled = true;
            gcCTPN.Enabled = true;
            cmbCHINHANH.Enabled = false;

            if (Program.role == "CONGTY")
            {
                btnXem.Enabled = false;
                cmbCHINHANH.Enabled = true;
                //btnThem2.Enabled = false;
            }

            groupBox1.Enabled = false;
            groupBoxPhieuNhap.Enabled = false;
        }
    }
}
