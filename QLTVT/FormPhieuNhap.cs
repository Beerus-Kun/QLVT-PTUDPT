using System;
using System.Collections;
using System.Collections.Generic;
using QLTVT.SubForm;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormPhieuNhap : Form
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

        public FormPhieuNhap()
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
            viTri = bdsPhieuNhap.Position;

            //groupBoxPhieuNhap.Enabled = true;
            //groupBox1.Enabled = false;

            txtMaHH.Enabled = false;
            txtSL.Enabled = false;
            txtDonGia.Enabled = false;
            btnChonVatTu.Enabled = false;
            //cmbMAKHO.Enabled = true;

            dangThemMoi = true;

            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsPhieuNhap.AddNew();

            this.txtMAPN.Enabled = true;
            this.txtMADD.Enabled = true;
            this.cmbMAKHO.Enabled = true;
            this.cmbMAKHO.SelectedIndex = 0;

            ((DataRowView)(bdsPhieuNhap.Current))["MANV"] = Program.userName;
            ((DataRowView)(bdsPhieuNhap.Current))["NGAYLAP"] = DateTime.Now;

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
            this.btnChonDonDat.Enabled = true;

            isChinhSuaDon = true;
            isChinhSuaHang = false;
        }

        private bool kiemTraDon()
        {
            txtMAPN.Text = txtMAPN.Text.Trim();
            txtMADD.Text = txtMADD.Text.Trim();

            if (txtMAPN.Text.Trim() == "")
            {
                MessageBox.Show("Không thể bỏ trống mã phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                txtMAPN.Focus();
                return false;
            }
            if (txtMAPN.Text.Trim().Length > 20)
            {
                MessageBox.Show("Mã phiếu nhập không quá 20 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMAPN.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMAPN.Text.Trim(), @"^[A-Za-z0-9-]+$") == false)
            {
                MessageBox.Show("Mã phiếu nhập chỉ có chữ cái, số và dấu '-'", "Thông báo", MessageBoxButtons.OK);
                txtMAPN.Focus();
                return false;
            }

            if (txtMADD.Text.Trim() == "")
            {
                MessageBox.Show("Không thể bỏ trống mã đơn đặt", "Thông báo", MessageBoxButtons.OK);
                txtMADD.Focus();
                return false;
            }
            if (txtMADD.Text.Trim().Length > 20)
            {
                MessageBox.Show("Mã đơn đặt không quá 20 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMADD.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMADD.Text.Trim(), @"^[A-Za-z0-9-]+$") == false)
            {
                MessageBox.Show("Mã đơn đặt chỉ có chữ cái, số và dấu '-'", "Thông báo", MessageBoxButtons.OK);
                txtMADD.Focus();
                return false;
            }
            if (bdsDonDat.Find("MADD", txtMADD.Text) == -1)
            {
                MessageBox.Show("Mã đơn đặt không tồn tại", "Thông báo", MessageBoxButtons.OK);
                txtMADD.Focus();
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

            //if (txtSL.Text.Trim() == "")
            //{
            //    MessageBox.Show("Không thể bỏ trống số lượng", "Thông báo", MessageBoxButtons.OK);
            //    txtSL.Focus();
            //    return false;
            //}
            if (sl <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
                txtSL.Focus();
                return false;
            }

            if (dongia <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return false;
            }
            return true;
        }

        private String taoCauTruyVanHoanTac()
        {
            String cauTruyVan = "";
            DataRowView drv;

            /*Dang chinh sua don dat hang*/
            if (isChinhSuaDon == true && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);

                cauTruyVan = "UPDATE DBO.PHIEUNHAP " +
                    "SET " +
                    "NGAYLAP = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATETIME), " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MADD = '" + drv["MADD"].ToString().Trim() + "' " +
                    "WHERE MAPN = '" + drv["MAPN"].ToString().Trim() + "'";
            }
            /*Dang xoa don dat hang*/
            if (isChinhSuaDon == true && dangThemMoi == true)
            {
                //drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                cauTruyVan = "DELETE FROM DBO.PHIEUNHAP " +
                "WHERE MAPN = '" + txtMAPN.Text.Trim() + "'";
            }

            /*Dang chinh sua chi tiet don dat hang*/
            if (isChinhSuaHang == true && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsCTPN[bdsCTPN.Position]);

                cauTruyVan = "UPDATE DBO.CTPN " +
                    "SET " +
                    "SL = " + drv["SL"].ToString() + " , " +
                    "DONGIA = " + drv["DONGIA"].ToString() + " " +
                    "WHERE MAPN = '" + drv["MAPN"].ToString().Trim() + "'" +
                    " AND MAHH = '" + drv["MAHH"].ToString().Trim() + "'";

            }

            if (isChinhSuaHang == true && dangThemMoi == true)
            {
                //drv = ((DataRowView)bdsCTPN[bdsCTPN.Position]);
                cauTruyVan = "DELETE FROM DBO.CTPN " +
                                "WHERE MAPN = '" + txtMAPN.Text.Trim() + "' " +
                                "AND MAHH = '" + txtMaHH.Text.Trim() + "'";

            }
            return cauTruyVan;
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPhieuNhap.Position;
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
                    txtDonGia.Focus();
                    return;
                }

                try
                {
                    dongia = int.Parse(txtDonGia.Text = txtDonGia.Text.Trim().Replace(",", ""));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đơn giá chỉ nhận số nguyên dương", "Thông báo", MessageBoxButtons.OK);
                    txtDonGia.Focus();
                    return;
                }

                ketQua = kiemTraHang() && kiemTraHopLeHang(sl);
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
                String maDonDatHangMoi = txtMAPN.Text.Trim();
                String cauTruyVan =
                        "DECLARE	@result int " +
                        "EXEC @result = sp_KiemTraMaPhieuNhap '" +
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
                    MessageBox.Show("Mã phiếu nhập đã được sử dụng!\n\n", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (dangThemMoi && isChinhSuaHang)
            {
                String maDonDatHangMoi = txtMAPN.Text.Trim();

                String cauTruyVan =
                        "DECLARE	@result int " +
                        "EXEC @result = sp_KiemTraMaChiTietPhieuNhap '" +
                        maDonDatHangMoi + "', '" + txtMaHH.Text.Trim() + "' " +
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
                    MessageBox.Show("Hàng hóa này đã có trong phiếu nhập !\n\n", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (result == 0)
                {
                    MessageBox.Show("Hàng hóa này không có trong đơn đặt !\n\n", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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

                    this.bdsPhieuNhap.EndEdit();
                    this.bdsCTPN.EndEdit();
                    this.phieuNhapTableAdapter.Update(this.qLVTDataSet.PHIEUNHAP);
                    this.ctpnTableAdapter.Update(this.qLVTDataSet.CTPN);

                    this.btnTHEM.Enabled = true;
                    this.btnThem2.Enabled = true;
                    this.btnXOA.Enabled = true;
                    this.btnGHI.Enabled = true;

                    this.btnHOANTAC.Enabled = true;
                    this.btnLAMMOI.Enabled = true;
                    this.btnMENU.Enabled = true;
                    this.btnTHOAT.Enabled = true;

                    this.btnChonDonDat.Enabled = false;
                    this.txtMAPN.Enabled = false;
                    this.txtMADD.Enabled = false;
                    this.cmbMAKHO.Enabled = false;
                    this.txtMaHH.Enabled = false;

                    gcCTPN.Enabled = true;
                    gcPhieuNhap.Enabled = true;

                    /*cập nhật lại trạng thái thêm mới cho chắc*/
                    dangThemMoi = false;
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    if (isChinhSuaDon)
                    {
                        bdsPhieuNhap.RemoveCurrent();
                    }
                    if (isChinhSuaHang)
                    {
                        bdsCTPN.RemoveCurrent();
                    }
                    MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


        }
        
        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPhieuNhap.Position = viTri;
            /* Step 0 */
            if (dangThemMoi == true)
            {
                dangThemMoi = false;
                /*dang o che do Don Dat Hang*/
                if (isChinhSuaDon == true)
                {
                    this.txtMAPN.Enabled = false;

                    bdsPhieuNhap.CancelEdit();
                    
                    checkDonHang();
                }
                /*dang o che do Chi Tiet Don Dat Hang*/
                if (isChinhSuaHang == true)
                {
                    txtMaHH.Enabled = false;
                    txtSL.Enabled = false;
                    txtDonGia.Enabled = false;
                    btnChonVatTu.Enabled = false;

                    bdsCTPN.CancelEdit();

                    checkHangHoa();
                }

                this.btnTHEM.Enabled = true;
                this.btnThem2.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                //this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);
                this.ctpnTableAdapter.Fill(this.qLVTDataSet.CTPN);

                gcCTPN.Enabled = true;
                gcPhieuNhap.Enabled = true;

                bdsPhieuNhap.Position = viTri;
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
                bdsPhieuNhap.CancelEdit();
            }
            if (isChinhSuaHang)
            {
                bdsCTPN.CancelEdit();
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

            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);
            this.ctpnTableAdapter.Fill(this.qLVTDataSet.CTPN);

            bdsPhieuNhap.Position = viTri;

            //if (isChinhSuaDon)
            //{
                
            //}

            //if (isChinhSuaHang)
            //{
            //    bdsCTPN.Position = viTri;
            //}
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);
                this.ctpnTableAdapter.Fill(this.qLVTDataSet.CTPN);

                //this.gcPhieuNhap.Enabled = true;
                //this.gcCTPN.Enabled = true;

                bdsPhieuNhap.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnChonVatTu_Click(object sender, EventArgs e)
        {
            Program.maDonDatHangDuocChonChiTiet = txtMADD.Text.Trim();
            FormChonChiTietDonHang form = new FormChonChiTietDonHang();
            form.ShowDialog();
            this.txtMaHH.Text = Program.maVatTuDuocChon;
            Program.maDonDatHangDuocChonChiTiet = "";
            Program.maVatTuDuocChon = "";
        }

        private void btnChonDonDat_Click(object sender, EventArgs e)
        {
            FormChonDonDatHang form = new FormChonDonDatHang();
            form.ShowDialog();
            this.txtMADD.Text = Program.maDonDatHangDuocChon;
            Program.maDonDatHangDuocChon = "";
        }

        private bool kiemTraHopLeHang(int sl)
        {
            //sl = int.Parse(txtSL.Text.Trim().Replace(",", ""));
            String cauTruyVan =
                        "DECLARE	@result int " +
                        "EXEC @result = sp_KiemTraHopLeHangNhap '" +
                        txtMAPN.Text.Trim() + "', '" + 
                        txtMaHH.Text.Trim() + "', " +
                        sl +
                        " SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    MessageBox.Show("Thực thi database thất bại!\n\n", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            if (result < 0)
            {
                MessageBox.Show("Hàng hóa này cần tối thiểu "+ result * -1  + " sản phẩm trong phiếu nhập!\nVì đã bán cho khách hàng\n", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataRowView drv = ((DataRowView)bdsCTPN[bdsCTPN.Position]);
                txtSL.Text = drv["SL"].ToString().Trim();
                return false;
            }

            return true;
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cauTruyVan = "";
            //string cheDo = (btnMENU.Links[0].Caption == "Đơn Đặt Hàng") ? "Đơn Đặt Hàng" : "Chi Tiết Đơn Đặt Hàng";

            dangThemMoi = true;// bat cai nay len de ung voi dieu kien tao cau truy van

            if (isChinhSuaDon)
            {
                /*Cái bdsChiTietDonHangHang là đại diện cho binding source riêng biệt của CTDDH
                 *Còn cTDDHBindingSource là lấy ngay từ trong data source DATHANG
                 */
                if (bdsCTPN.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);

                cauTruyVan = "INSERT INTO DBO.PHIEUNHAP(MADD, MAKHO, MAPN, NGAYLAP, MANV) " +
                    "VALUES('" + drv["MADD"].ToString() + "', '" +
                    drv["MAKHO"].ToString() + "', '" +
                    drv["MAPN"].ToString() + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["MANV"].ToString() + "' )";
            }
            if (isChinhSuaHang)
            {
                if (!kiemTraHopLeHang(0))
                {
                    return;
                }

                DataRowView drv = ((DataRowView)bdsCTPN[bdsCTPN.Position]);

                cauTruyVan = "INSERT INTO DBO.CTPN(MAPN, MAHH, DONGIA, SL) " +
                    "VALUES('" + drv["MAPN"] + "', '" +
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
                    viTri = 0;

                    viTri = bdsPhieuNhap.Position;

                    if (isChinhSuaDon)
                    {
                        
                        bdsPhieuNhap.RemoveCurrent();
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuNhapTableAdapter.Update(this.qLVTDataSet.PHIEUNHAP);
                    }
                    if (isChinhSuaHang)
                    {
                        //viTri = bdsCTPN.Position;
                        bdsCTPN.RemoveCurrent();
                        this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.ctpnTableAdapter.Update(this.qLVTDataSet.CTPN);
                    }


                    this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctpnTableAdapter.Fill(this.qLVTDataSet.CTPN);

                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);

                    bdsPhieuNhap.Position = viTri;

                    /*Cap nhat lai do ben tren can tao cau truy van nen da dat dangThemMoi = true*/
                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctpnTableAdapter.Fill(this.qLVTDataSet.CTPN);

                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);
                    // tro ve vi tri cua nhan vien dang bi loi
                    //if (isChinhSuaHang)
                    //{
                    //    bdsCTPN.Position = viTri;
                    //}

                    //if (isChinhSuaDon)
                    //{
                        
                    //}
                    bdsPhieuNhap.Position = viTri;
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
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.qLVTDataSet.KHO);

                this.hangHoaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hangHoaTableAdapter.Fill(this.qLVTDataSet.HANGHOA);

                this.donDatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.donDatTableAdapter.Fill(this.qLVTDataSet.DONDAT);

                this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ctpnTableAdapter.Fill(this.qLVTDataSet.CTPN);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);
            }
        }

        private void checkDonHang()
        {
            if (isXem == false && (Program.role == "CHINHANH" || Program.role == "USER"))
            {
                isChinhSuaHang = false;
                isChinhSuaDon = true;

                txtMAPN.Enabled = false;
                txtMADD.Enabled = true;
                cmbMAKHO.Enabled = true;
                btnChonDonDat.Enabled = true;
                //btnThem2.Enabled = true;

                if (bdsCTPN.Count > 0)
                {
                    cmbMAKHO.Enabled = false;
                    txtMADD.Enabled = false;
                    btnChonDonDat.Enabled = false;
                }

                txtMaHH.Enabled = false;
                txtSL.Enabled = false;
                txtDonGia.Enabled = false;
                btnChonVatTu.Enabled = false;
            }
        }

        private void checkHangHoa()
        {
            if (isXem == false && (Program.role == "CHINHANH" || Program.role == "USER") && isChinhSuaDon == true && bdsCTPN.Count > 0)
            {
                txtMAPN.Enabled = false;
                txtMADD.Enabled = false;
                cmbMAKHO.Enabled = false;
                btnChonDonDat.Enabled = false;

                txtMaHH.Enabled = false;
                txtSL.Enabled = true;
                txtDonGia.Enabled = true;
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

                bdsPhieuNhap.Filter = "1=1";

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
                bdsPhieuNhap.Filter = "MANV = '" + Program.userName + "'";

                groupBox1.Enabled = true;
                groupBoxPhieuNhap.Enabled = true;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsPhieuNhap.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = true;
                this.btnThem2.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;

                this.txtMAPN.Enabled = false;
                this.txtMADD.Enabled = false;
                this.btnChonDonDat.Enabled = false;
                //isChinhSuaDon = true;
                checkDonHang();
            }


        }

        private void btnThem2_ItemClick(object sender, EventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsPhieuNhap.Position;

            //groupBoxPhieuNhap.Enabled = false;
            //groupBox1.Enabled = true;

            txtMAPN.Enabled = false;
            txtMADD.Enabled = false;
            cmbMAKHO.Enabled = false;
            btnChonDonDat.Enabled = false;

            gcCTPN.Enabled = false;
            gcPhieuNhap.Enabled = false;

            dangThemMoi = true;

            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsCTPN.AddNew();

            this.txtMaHH.Enabled = true;
            this.txtDonGia.Enabled = true;
            this.txtSL.Enabled = true;
            this.btnChonVatTu.Enabled = true;
            this.btnThem2.Enabled = false;

            ((DataRowView)(bdsCTPN.Current))["MAPN"] = txtMAPN.Text;

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


        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.HOADON' table. You can move, or remove it, as needed.
            //this.hOADONTableAdapter.Fill(this.qLVTDataSet.HOADON);
            qLVTDataSet.EnforceConstraints = false;

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVTDataSet.KHO);

            this.hangHoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hangHoaTableAdapter.Fill(this.qLVTDataSet.HANGHOA);

            this.donDatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.donDatTableAdapter.Fill(this.qLVTDataSet.DONDAT);

            this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpnTableAdapter.Fill(this.qLVTDataSet.CTPN);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);

            cmbCHINHANH.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            txtMAPN.Enabled = false;
            cmbMAKHO.Enabled = false;
            txtMADD.Enabled = false;
            btnChonDonDat.Enabled = false;

            txtMaHH.Enabled = false;
            btnChonVatTu.Enabled = false;
            txtSL.Enabled = false;
            txtDonGia.Enabled = false;

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
