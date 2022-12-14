using DevExpress.XtraGrid;
using QLTVT.SubForm;
using System;
using System.Collections;
using System.Collections.Generic;
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

    public partial class FormDonDatHang : Form
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
        //string type = "";



        /************************************************************
         * CheckExists:
         * Để tránh việc người dùng ấn vào 1 form đến 2 lần chúng ta 
         * cần sử dụng hàm này để kiểm tra xem cái form hiện tại đã 
         * có trong bộ nhớ chưa
         * Nếu có trả về "f"
         * Nếu không trả về "null"
         ************************************************************/
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormDonDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDonDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {

            /*Step 1*/
            qLVTDataSet.EnforceConstraints = false;

            this.nhaCungCapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhaCungCapTableAdapter.Fill(this.qLVTDataSet.NHACUNGCAP);

            this.hangHoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hangHoaTableAdapter.Fill(this.qLVTDataSet.HANGHOA);

            this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.donDatHangTableAdapter.Fill(this.qLVTDataSet.DONDAT);

            this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietDonDatHangTableAdapter.Fill(this.qLVTDataSet.CTDD);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);
            /*van con ton tai loi chua sua duoc*/
            //maChiNhanh = ((DataRowView)bdsVatTu[0])["MACN"].ToString();

            /*Step 2*/
            cmbCHINHANH.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            txtMaDonDatHang.Enabled = false;
            cmbMANCC.Enabled = false;

            txtMaHH.Enabled = false;
            btnChonVatTu.Enabled = false;
            txtSL.Enabled = false;
            txtDonGia.Enabled = false;

            gcDonDatHang.Enabled = true;
            gcChiTietDonDatHang.Enabled = true;
            cmbCHINHANH.Enabled = false;

            //txtMaHH.Enabled = false;
            //txtSL.Enabled = false;
            //txtDonGia.Enabled = false;
            //btnChonVatTu.Enabled = false;
            //btnThem2.Enabled = false;

            if (Program.role == "CONGTY")
            {
                btnXem.Enabled = false;
                cmbCHINHANH.Enabled = true;
                //btnThem2.Enabled = false;
            }

            //groupBox1.Enabled = false;
            //groupBoxDonDatHang.Enabled = false;
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsDonDatHang.Position;

            //groupBoxDonDatHang.Enabled = true;
            //groupBox1.Enabled = false;

            gcDonDatHang.Enabled = false;
            gcChiTietDonDatHang.Enabled = false;

            dangThemMoi = true;

            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsDonDatHang.AddNew();

            this.txtMaDonDatHang.Enabled = true;
            this.cmbMANCC.Enabled = true;
            this.cmbMANCC.SelectedIndex = 0;

            ((DataRowView)(bdsDonDatHang.Current))["MANV"] = Program.userName;
            ((DataRowView)(bdsDonDatHang.Current))["THOIGIAN"] = DateTime.Now;

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

            this.txtDonGia.Enabled = false;
            this.txtSL.Enabled = false;
            this.txtMaHH.Enabled = false;

            isChinhSuaDon = true;
            isChinhSuaHang = false;
        }


        /**************************************************
         * ham nay kiem tra du lieu dau vao
         * true là qua hết
         * false là thiếu một dữ liệu nào đó
         **************************************************/

        private bool kiemTraDonDat()
        {
            txtMaDonDatHang.Text = txtMaDonDatHang.Text.Trim();
            if (txtMaDonDatHang.Text.Trim() == "")
            {
                MessageBox.Show("Không thể bỏ trống mã đơn hàng", "Thông báo", MessageBoxButtons.OK);
                txtMaDonDatHang.Focus();
                return false;
            }
            if (txtMaDonDatHang.Text.Trim().Length > 20)
            {
                MessageBox.Show("Mã đơn đặt hàng không quá 20 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaDonDatHang.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMaDonDatHang.Text.Trim(), @"^[A-Za-z0-9-]+$") == false)
            {
                MessageBox.Show("Mã đơn đặt hàng chỉ có chữ cái, số và dấu '-'", "Thông báo", MessageBoxButtons.OK);
                txtMaDonDatHang.Focus();
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
            if (bdsHangHoa.Find("MAHH", txtMaHH.Text.Trim()) == -1)
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

        /**************************************************
         * tra ve 1 cau truy van de phuc hoi du lieu
         * 
         * ket qua tra ve dua theo che do dang su dung
         **************************************************/
        private String taoCauTruyVanHoanTac()
        {
            String cauTruyVan = "";
            DataRowView drv;

            /*Dang chinh sua don dat hang*/
            if (isChinhSuaDon == true && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["THOIGIAN"]);

                cauTruyVan = "UPDATE DBO.DONDAT " +
                    "SET " +
                    "THOIGIAN = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATETIME), " +
                    "MANCC = '" + drv["MANCC"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "' " +
                    "WHERE MADD = '" + drv["MADD"].ToString().Trim() + "'";
            }
            /*Dang xoa don dat hang*/
            if (isChinhSuaDon == true && dangThemMoi == true)
            {
                //drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                cauTruyVan = "DELETE FROM DBO.DONDAT " +
                "WHERE MADD = '" + txtMaDonDatHang.Text.Trim() + "'";
            }

            /*Dang chinh sua chi tiet don dat hang*/
            if (isChinhSuaHang == true && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsChiTietDonDatHang[bdsChiTietDonDatHang.Position]);

                cauTruyVan = "UPDATE DBO.CTDD " +
                    "SET " +
                    "SL = " + drv["SL"].ToString() + " , " +
                    "DONGIA = " + drv["DONGIA"].ToString() + " " +
                    "WHERE MADD = '" + drv["MADD"].ToString().Trim() + "' " +
                    " AND MAHH = '" + drv["MAHH"].ToString().Trim() + "'";

            }

            if (isChinhSuaHang == true && dangThemMoi == true)
            {
                drv = ((DataRowView)bdsChiTietDonDatHang[bdsChiTietDonDatHang.Position]);
                cauTruyVan = "DELETE FROM DBO.CTDD " +
                                "WHERE MADD = '" + txtMaDonDatHang.Text.Trim() + "' " +
                                "AND MAHH = '" + txtMaHH.Text.Trim() + "'";

            }
            return cauTruyVan;
        }



        /**************************************************
         * Step 1: Kiem tra xem day co phai nguoi lap don hang hay không
         * Step 2: lay che do dang lam viec, kiem tra du lieu dau vao. Neu OK thi 
         * tiep tuc tao cau truy van hoan tac neu dangThemMoi = false
         * Step 3: kiem tra xem cai ma don hang nay da ton tai chua ?
         *          Neu co thi ket thuc luon
         *          Neu khong thi cho them moi
         **************************************************/
        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDonDatHang.Position;
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

                ketQua = kiemTraHang();
            }
            if (isChinhSuaDon == true)
            {

                ketQua = kiemTraDonDat();
            }
            if (ketQua == false) return;

            String cauTruyVanHoanTac;


            /*Step 3*/
            if (dangThemMoi && isChinhSuaDon)
            {
                String maDonDatHangMoi = txtMaDonDatHang.Text.Trim();
                String cauTruyVan =
                        "DECLARE	@result int " +
                        "EXEC @result = sp_KiemTraMaDonDatHang '" +
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

                /*Step 4*/
                //Console.WriteLine(txtMaNhanVien.Text);
                int viTriHienTai = bdsDonDatHang.Position;
                int viTriMaDonDatHang = bdsDonDatHang.Find("MADD", txtMaDonDatHang.Text);
                /******************************************************************
                 * truong hop them moi don dat hang moi quan tam xem no ton tai hay
                 * chua ?
                 ******************************************************************/
                if (result == 1 && viTriHienTai != viTriMaDonDatHang)
                {
                    MessageBox.Show("Mã đơn hàng này đã được sử dụng !\n\n", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if(dangThemMoi && isChinhSuaHang)
            {
                String maDonDatHangMoi = txtMaDonDatHang.Text;

                String cauTruyVan =
                        "DECLARE	@result int " +
                        "EXEC @result = sp_KiemTraMaChiTietDonDat '" +
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
                    MessageBox.Show("Hàng hóa này đã có trong đơn hàng !\n\n", "Thông báo",
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
                    Console.WriteLine("15649494");
                    Console.WriteLine(cauTruyVanHoanTac);
                    undoList.Push(cauTruyVanHoanTac);

                    this.bdsDonDatHang.EndEdit();
                    this.bdsChiTietDonDatHang.EndEdit();
                    this.donDatHangTableAdapter.Update(this.qLVTDataSet.DONDAT);

                    this.chiTietDonDatHangTableAdapter.Update(this.qLVTDataSet.CTDD);

                    this.btnTHEM.Enabled = true;
                    this.btnThem2.Enabled = true;
                    this.btnXOA.Enabled = true;
                    this.btnGHI.Enabled = true;

                    this.btnHOANTAC.Enabled = true;
                    this.btnLAMMOI.Enabled = true;
                    this.btnMENU.Enabled = true;
                    this.btnTHOAT.Enabled = true;

                    /*cập nhật lại trạng thái thêm mới cho chắc*/
                    dangThemMoi = false;

                    gcChiTietDonDatHang.Enabled = true;
                    gcDonDatHang.Enabled = true;

                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    if (isChinhSuaDon)
                    {
                        bdsDonDatHang.RemoveCurrent();
                    }
                    if (isChinhSuaHang)
                    {
                        bdsChiTietDonDatHang.RemoveCurrent();
                    }
                    MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        /**********************************************************************
         * moi lan nhan btnHOANTAC thi nen nhan them btnLAMMOI de 
         * tranh bi loi khi an btnTHEM lan nua
         * 
         * statement: chua cau y nghia chuc nang ngay truoc khi an btnHOANTAC.
         * Vi du: statement = INSERT | DELETE | CHANGEBRAND
         * 
         * bdsNhanVien.CancelEdit() - phuc hoi lai du lieu neu chua an btnGHI
         * Step 0: trường hợp đã ấn btnTHEM nhưng chưa ấn btnGHI
         * Step 1: kiểm tra undoList có trông hay không ?
         * Step 2: Neu undoList khong trống thì lấy ra khôi phục
         *********************************************************************/
        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true)
            {
                dangThemMoi = false;

                gcDonDatHang.Enabled = true;
                gcChiTietDonDatHang.Enabled = true;

                bdsDonDatHang.Position = viTri;

                /*dang o che do Don Dat Hang*/
                if (isChinhSuaDon == true)
                {
                    this.txtMaDonDatHang.Enabled = false;

                    bdsDonDatHang.CancelEdit();
                    /*xoa dong hien tai*/
                    //bdsDonDatHang.RemoveCurrent();
                    /* trở về lúc đầu con trỏ đang đứng*/
                    
                    checkDonHang();
                }
                /*dang o che do Chi Tiet Don Dat Hang*/
                if (isChinhSuaHang == true)
                {
                    txtMaHH.Enabled = false;
                    txtSL.Enabled = false;
                    txtDonGia.Enabled = false;
                    btnChonVatTu.Enabled = false;

                    bdsChiTietDonDatHang.CancelEdit();
                    /*xoa dong hien tai*/
                    //bdsChiTietDonDatHang.RemoveCurrent();
                    /* trở về lúc đầu con trỏ đang đứng*/
                    //bdsChiTietDonDatHang.Position = viTri;

                    if (isXem == false && (Program.role == "CHINHANH" || Program.role == "USER") && bdsPhieuNhap.Count == 0)
                    {
                        if (bdsChiTietDonDatHang.Count > 0)
                        {
                            txtMaDonDatHang.Enabled = false;
                            cmbMANCC.Enabled = false;

                            txtMaHH.Enabled = false;
                            txtSL.Enabled = true;
                            txtDonGia.Enabled = true;
                            //btnChonVatTu.Enabled = true;
                        }

                        btnThem2.Enabled = true;
                    }
                }

                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                //this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.donDatHangTableAdapter.Fill(this.qLVTDataSet.DONDAT);
                this.chiTietDonDatHangTableAdapter.Fill(this.qLVTDataSet.CTDD);

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
                bdsDonDatHang.CancelEdit();
            }
            if (isChinhSuaHang)
            {
                bdsChiTietDonDatHang.CancelEdit();
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

            this.donDatHangTableAdapter.Fill(this.qLVTDataSet.DONDAT);
            this.chiTietDonDatHangTableAdapter.Fill(this.qLVTDataSet.CTDD);

            if (isChinhSuaDon)
            {
                bdsDonDatHang.Position = viTri;
            }

            if (isChinhSuaHang)
            {
                bdsDonDatHang.Position = viTri;
            }


        }


        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.donDatHangTableAdapter.Fill(this.qLVTDataSet.DONDAT);
                this.chiTietDonDatHangTableAdapter.Fill(this.qLVTDataSet.CTDD);

                this.gcDonDatHang.Enabled = true;
                this.gcChiTietDonDatHang.Enabled = true;

                bdsDonDatHang.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        /***************************************************************
         * ShowDialog is useful when you want to present info to a user, or let him change it, or get info from him before you do anything else.
         * 
         * Show is useful when you want to show information to the user but it is not important that you wait fro him to be finished.
         ***************************************************************/
        private void btnChonKhoHang_Click(object sender, EventArgs e)
        {
            FormChonKhoHang form = new FormChonKhoHang();
            form.ShowDialog();


            //     this.txtMaKho.Text = Program.maKhoDuocChon;
        }

        private void btnChonVatTu_Click(object sender, EventArgs e)
        {
            FormChonVatTu form = new FormChonVatTu();
            form.ShowDialog();
            this.txtMaHH.Text = Program.maVatTuDuocChon;
            Program.maVatTuDuocChon = "";
        }



        /**
         * Step 1: lấy chế độ đang sử dụng và đặt dangThemMoi = true để phục vụ điều kiện tạo câu truy
         * vấn hoàn tác
         * Step 2: kiểm tra điều kiện theo chế độ đang sử dụng
         * Step 3: nạp câu truy vấn hoàn tác vào undolist
         * Step 4: Thực hiện xóa nếu OK
         */
        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cauTruyVan = "";
            //string cheDo = (btnMENU.Links[0].Caption == "Đơn Đặt Hàng") ? "Đơn Đặt Hàng" : "Chi Tiết Đơn Đặt Hàng";
            //viTri = bdsDonDatHang.Position;
            //dangThemMoi = true;// bat cai nay len de ung voi dieu kien tao cau truy van

            if (isChinhSuaDon)
            {
                /*Cái bdsChiTietDonHangHang là đại diện cho binding source riêng biệt của CTDDH
                 *Còn cTDDHBindingSource là lấy ngay từ trong data source DATHANG
                 */
                if (bdsChiTietDonDatHang.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                DataRowView drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["THOIGIAN"]);

                cauTruyVan = "INSERT INTO DBO.DONDAT(MADD, MANCC, THOIGIAN, MANV) " +
                    "VALUES('" + drv["MADD"] + "', '" +
                    drv["MANCC"].ToString() + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["MANV"].ToString() + "' )";
            }
            if (isChinhSuaHang)
            {
                if (bdsPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Không thể xóa hàng hóa này vì có phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                DataRowView drv = ((DataRowView)bdsChiTietDonDatHang[bdsChiTietDonDatHang.Position]);

                cauTruyVan = "INSERT INTO DBO.CTDD(MADD, MAHH, DONGIA, SL) " +
                    "VALUES('" + drv["MADD"] + "', '" +
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

                    viTri = bdsDonDatHang.Position;

                    if (isChinhSuaDon)
                    {
                        bdsDonDatHang.RemoveCurrent();
                        this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.donDatHangTableAdapter.Update(this.qLVTDataSet.DONDAT);
                    }
                    if (isChinhSuaHang)
                    {
                        //viTri = bdsChiTietDonDatHang.Position;
                        bdsChiTietDonDatHang.RemoveCurrent();
                        this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.chiTietDonDatHangTableAdapter.Update(this.qLVTDataSet.CTDD);
                    }


                    this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietDonDatHangTableAdapter.Fill(this.qLVTDataSet.CTDD);

                    this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.donDatHangTableAdapter.Fill(this.qLVTDataSet.DONDAT);

                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);

                    /*Cap nhat lai do ben tren can tao cau truy van nen da dat dangThemMoi = true*/
                    //dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;

                    bdsDonDatHang.Position = viTri;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietDonDatHangTableAdapter.Fill(this.qLVTDataSet.CTDD);

                    this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.donDatHangTableAdapter.Fill(this.qLVTDataSet.DONDAT);

                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);
                    // tro ve vi tri cua nhan vien dang bi loi

                    bdsDonDatHang.Position = viTri;

                    //if (isChinhSuaHang)
                    //{
                    //    bdsChiTietDonDatHang.Position = viTri;
                    //}

                    //if (isChinhSuaDon)
                    //{
                        
                    //}
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
                this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.chiTietDonDatHangTableAdapter.Fill(this.qLVTDataSet.CTDD);

                this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.donDatHangTableAdapter.Fill(this.qLVTDataSet.DONDAT);

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

                txtMaDonDatHang.Enabled = false;
                cmbMANCC.Enabled = true;
                btnThem2.Enabled = true;
                Console.Write(bdsPhieuNhap.Count);
                if (bdsPhieuNhap.Count > 0)
                {
                    
                    cmbMANCC.Enabled = false;
                    btnThem2.Enabled = false;
                }

                txtMaHH.Enabled = false;
                txtSL.Enabled = false;
                txtDonGia.Enabled = false;
                btnChonVatTu.Enabled = false;
            }
        }

        private void checkHangHoa()
        {
            if (isXem == false && (Program.role == "CHINHANH" || Program.role == "USER") && isChinhSuaDon == true && bdsPhieuNhap.Count == 0 && bdsChiTietDonDatHang.Count > 0)
            {
                txtMaDonDatHang.Enabled = false;
                cmbMANCC.Enabled = false;

                txtMaHH.Enabled = false;
                txtSL.Enabled = true;
                txtDonGia.Enabled = true;
                btnChonVatTu.Enabled = false;
            }
        }


        private void gcDonDatHang_Click(object sender, EventArgs e)
        {
            checkDonHang();
            isChinhSuaDon = true;
            isChinhSuaHang = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gcChiTietDonDatHang_Click(object sender, EventArgs e)
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
                groupBoxDonDatHang.Enabled = false;

                bdsDonDatHang.Filter = "1=1";

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
                bdsDonDatHang.Filter = "MANV = '" + Program.userName + "'";

                groupBox1.Enabled = true;
                groupBoxDonDatHang.Enabled = true;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsDonDatHang.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = true;
                this.btnThem2.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;

                this.txtMaDonDatHang.Enabled = false;
                //isChinhSuaDon = true;
                checkDonHang();
            }


        }

        private void btnThem2_ItemClick(object sender, EventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsDonDatHang.Position;

            //groupBoxDonDatHang.Enabled = false;
            //groupBox1.Enabled = true;

            gcDonDatHang.Enabled = false;
            gcChiTietDonDatHang.Enabled = false;

            dangThemMoi = true;

            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsChiTietDonDatHang.AddNew();

            cmbMANCC.Enabled = false;
            this.txtMaHH.Enabled = true;
            this.txtDonGia.Enabled = true;
            this.txtSL.Enabled = true;
            this.btnChonVatTu.Enabled = true;
            this.btnThem2.Enabled = false;

            ((DataRowView)(bdsChiTietDonDatHang.Current))["MADD"] = txtMaDonDatHang.Text;

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

        private void dONDATGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
