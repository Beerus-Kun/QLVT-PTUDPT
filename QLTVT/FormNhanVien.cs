using QLTVT.SubForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormNhanVien : Form
    {
        /* vị trí của con trỏ trên grid view*/
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
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            // this.tableAdapterManager.UpdateAll(this.dataSet);
            this.tableAdapterManager1.UpdateAll(this.qLVTDataSet);

        }
        /*
         *Step 1: tat kiem tra khoa ngoai & do du lieu vao form
         *Step 2: lay du lieu dang nhap tu form dang nhap
         *Step 3: bat nut chuc nang theo vai tro khi dang nhap
         */
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            qLVTDataSet.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NHANVIEN);

            this.donDatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.donDatTableAdapter.Fill(this.qLVTDataSet.DONDAT);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);

            this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoaDonTableAdapter.Fill(this.qLVTDataSet.HOADON);

            /*van con ton tai loi chua sua duoc*/
            maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();
            /*Step 2*/
            cmbCHINHANH.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            this.btnCHUYENCHINHANH.Enabled = false;
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
                if (Program.role == "CHINHANH")
                {
                    this.btnCHUYENCHINHANH.Enabled = true;
                }
                this.btnTHOAT.Enabled = true;

                this.panelNhapLieu.Enabled = true;
                this.txtMANV.Enabled = false;
            }
            //bdsNhanVien.Filter = "MANV='NV2'";
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }



        /*********************************************************************
         * bdsNhanVien.Position - vitri phuc vu cho btnHOANTAC. Gia su, co 5 nhan vien, con tro chuot
         * dang dung o vi tri nhan vien thu 2 thi chung ta an nut THEM
         * nhung neu chon btnHOANTAC, con tro chuot phai quay lai vi 
         * tri nhan vien thu 2, thay vi o vi tri duoi cung - tuc nhan vien so 5
         * 
         * neu nhap chu cho txtMANV thi se khong chuyen sang cac o khac duoc nua - bat buoc ghi so
         * 
         * Step 1: Kich hoat panel Nhap lieu & lay vi tri cua nhan vien hien tai
         * dat dangThemMoi = true
         * Step 2: gui lenh them moi toi bdsNHANVIEN - tu dong lay maChiNhanh - bo trong dteNGAYSINH
         * Step 3: vo hieu hoa cac nut chuc nang & gridControl - chi btnGHI & btnHOANTAC moi duoc hoat dong
         *********************************************************************/
        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsNhanVien.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;


            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsNhanVien.AddNew();
            txtMACN.Text = maChiNhanh;
            
            dteNGAYSINH.EditValue = "1995-6-9";
            chbPhai.Checked = true;

            Random rnd = new Random();
            txtSDT.Text = "0" + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString();
            txtDIACHI.Text = "97 Man Thiện";
            //dteNGAYSINH.EditValue = "2000-05-01";
            //txtLUONG.Value = 4000000;// dat san muc luong toi thieu


            /*Step 3*/
            this.txtMANV.Enabled = true;
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnCHUYENCHINHANH.Enabled = false;
            this.btnTHOAT.Enabled = false;
            this.chbDanhDauDaXoa.Checked = false;

            //gridView1.HideFindPanel();

            this.gcNhanVien.Enabled = false;
            this.panelNhapLieu.Enabled = true;
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
            /* Step 0 - */
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                this.txtMANV.Enabled = false;
                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                if(Program.role == "CHINHANH")
                {
                    this.btnCHUYENCHINHANH.Enabled = true;
                }
                //
                this.btnTHOAT.Enabled = true;
                this.chbDanhDauDaXoa.Checked = false;

                gridView1.ShowFindPanel();

                this.gcNhanVien.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                bdsNhanVien.CancelEdit();
                /*xoa dong hien tai*/
                //bdsNhanVien.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsNhanVien.Position = viTri;
                this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NHANVIEN);
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
            bdsNhanVien.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            //Console.WriteLine(cauTruyVanHoanTac);

            if (Program.KetNoi() == 0)
            {
                return;
            }
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NHANVIEN);

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
                this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NHANVIEN);
                this.gcNhanVien.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }



        /***************************************************************************
         * Step 1: tu biding source kiem tra xem nhan vien nay da lap don hang - 
         * phieu nhap - phieu xuat chua ?
         *          Neu co thi thong bao la khong the xoa va ket thuc
         *          Neu khong thi bat dau xoa
         * Step 2: Neu chon OK thi tien hanh xoa
         * Step 3: Lay ma nhan vien bi xoa roi luu lai trong manv
         * Step 4: Truong hop xoa nhan vien bi loi thi quay lai dung vi tri manv bi loi
         ***************************************************************************/
        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String tenNV = ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString();
            /*Step 1*/

            // khong cho xoa nguoi dang dang nhap ke ca nguoi do khong co don hang - phieu nhap - phieu xuat
            if (tenNV == Program.userName)
            {
                MessageBox.Show("Không thể xóa chính tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsNhanVien.Count == 0)
            {
                btnXOA.Enabled = false;
            }

            if (bdsDonDat.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsHoaDon.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập hóa đơn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            /* Phần này phục vụ tính năng hoàn tác
                    * Đưa câu truy vấn hoàn tác vào undoList 
                    * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/
            //int trangThai = (chbDanhDauDaXoa.Checked == true) ? 1 : 0;
            /*Lấy ngày sinh trong grid view*/
            DateTime NGAYSINH = (DateTime)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["NGAYSINH"];
            DataRowView drv = (DataRowView)(bdsNhanVien[bdsNhanVien.Position]); 

            string cauTruyVanHoanTac =
                string.Format("INSERT INTO DBO.NHANVIEN( MANV,HO,TEN,DIACHI,NGAYSINH,SDT, PHAI, MACN, DANHDAUDAXOA)" +
            "VALUES('{0}',N'{1}',N'{2}',N'{3}',CAST({4} AS DATETIME), '{5}','{6}', '{7}', '{8}')", 
            drv["MANV"].ToString(), 
            drv["HO"].ToString(), 
            drv["TEN"].ToString(), 
            drv["DIACHI"].ToString(), 
            NGAYSINH.ToString("yyyy-MM-dd"), 
            drv["SDT"].ToString(), 
            drv["PHAI"].ToString(), 
            drv["MACN"].ToString(), 
            drv["DANHDAUDAXOA"].ToString());

            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);


            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                viTri = bdsNhanVien.Position;
                try
                {
                    /*Step 3*/
                    bdsNhanVien.RemoveCurrent();

                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.qLVTDataSet.NHANVIEN);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NHANVIEN);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsNhanVien.Position = viTri;
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


            if( Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại","Thông báo",MessageBoxButtons.OK);
            }
            else
            {

                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NHANVIEN);

                this.donDatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.donDatTableAdapter.Fill(this.qLVTDataSet.DONDAT);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qLVTDataSet.PHIEUNHAP);

                this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hoaDonTableAdapter.Fill(this.qLVTDataSet.HOADON);

            }
        }

        private void bdsPhieuNhap_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dteNGAYSINH_EditValueChanged(object sender, EventArgs e)
        {
            //dteNGAYSINH.ShowPopup();
        }

        private void trangThaiXoaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool kiemTraDuLieuDauVao()
        {
            txtMANV.Text = txtMANV.Text.Trim();
            txtHO.Text = txtHO.Text.Trim();
            txtTEN.Text = txtTEN.Text.Trim();
            txtDIACHI.Text = txtDIACHI.Text.Trim();
            txtSDT.Text = txtSDT.Text.Trim();

            /*kiem tra txtMANV*/
            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                txtMANV.Focus();
                return false;
            }

            if (Regex.IsMatch(txtMANV.Text.Trim(), @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã nhân viên chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtMANV.Focus();
                return false;
            }

            if (txtMANV.Text.Trim().Length > 20)
            {
                MessageBox.Show("Mã nhân viên không được quá 20 ký tự", "Thông báo", MessageBoxButtons.OK);
                txtMANV.Focus();
                return false;
            }

            /*kiem tra txtHO*/
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }
            //"^[0-9A-Za-z ]+$"
            if ( Regex.IsMatch(txtHO.Text.Trim(), @"^[A-Za-z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Họ của người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }
            if (txtHO.Text.Trim().Length > 40)
            {
                MessageBox.Show("Họ không thể lớn hơn 40 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }
            /*kiem tra txtTEN*/
            if (txtTEN.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            if (Regex.IsMatch(txtTEN.Text, @"^[a-zA-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Tên người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            if (txtTEN.Text.Length > 10)
            {
                MessageBox.Show("Tên không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }
            /*kiem tra txtDIACHI*/
            if (txtDIACHI.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return false;
            }

            if (Regex.IsMatch(txtDIACHI.Text, @"^[a-zA-Z0-9, ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ/-]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return false;
            }

            if (txtDIACHI.Text.Length > 100)
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return false;
            }
            /*kiem tra dteNGAYSINH*/
            if (CalculateAge(dteNGAYSINH.DateTime) < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                dteNGAYSINH.Focus();
                return false;
            }
            /*kiem tra so dien thoai*/
            if (Regex.IsMatch(txtSDT.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số điện thoại chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
                return false;
            }

            if (txtSDT.Text.Length <7)
            {
                MessageBox.Show("Số điện thoại phải từ 7 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
                return false;
            }

            if (txtSDT.Text.Length >11)
            {
                MessageBox.Show("Số điện thoại không quá 11 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
                return false;
            }
            return true;
        }



        /**
         * viTriConTro: vi tri con tro chuot dang dung
         * viTriMaNhanVien: vi tri cua ma nhan vien voi btnTHEM or hanh dong sua du lieu
         * sp_TRACUU_KIEMTRAMANHANVIEN tra ve 0 neu khong ton tai
         *                                    1 neu ton tai
         *                                    
         * Step 0 : Kiem tra du lieu dau vao
         * Step 1 : Dung stored procedure sp_TRACUU_KIEMTRAMANHANVIEN de kiem tra txtMANV
         * Step 2 : Ket hop ket qua tu Step 1 & vi tri cua txtMANV co 2 truong hop xay ra
         * + TH0: ketQua = 1 && viTriConTro != viTriMaNhanVien -> them moi nhung MANV da ton tai
         * + TH1: ketQua = 1 && viTriConTro == viTriMaNhanVien -> sua nhan vien cu
         * + TH2: ketQua = 0 && viTriConTro == viTriMaNhanVien -> co the them moi nhan vien
         * + TH3: ketQua = 0 && viTriConTro != viTriMaNhanVien -> co the them moi nhan vien
         *          
         * Step 3 : Neu khong phai TH0 thi cac TH1 - TH2 - TH3 deu hop le 
         */
        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            /*Step 1*/
            /*Lay du lieu truoc khi chon btnGHI - phuc vu btnHOANTAC - sau khi OK thi da la du lieu moi*/
            String maNhanVien = txtMANV.Text.Trim();// Trim() de loai bo khoang trang thua


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



            /*Step 2*/
            int viTriConTro = bdsNhanVien.Position;
            int viTriMaNhanVien = bdsNhanVien.Find("MANV", txtMANV.Text);
            
            if ( result == 1 && viTriConTro != viTriMaNhanVien)
            {
                MessageBox.Show("Mã nhân viên này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return; 
            }
            else/*them moi | sua nhan vien*/
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if ( dr == DialogResult.OK)
                {
                    try
                    {
                        /*bật các nút về ban đầu*/
                        this.btnTHEM.Enabled = true;
                        this.btnXOA.Enabled = true;
                        this.btnGHI.Enabled = true;
                        this.btnHOANTAC.Enabled = true;

                        this.btnLAMMOI.Enabled = true;
                        if(Program.role == "CHINHANH")
                        {
                            this.btnCHUYENCHINHANH.Enabled = true;
                        }
                        // btnCHUYENCHINHANH.Enabled = true;
                        this.btnTHOAT.Enabled = true;

                        this.txtMANV.Enabled = false;
                        this.bdsNhanVien.EndEdit();
                        //this.bdsNhanVien.ResetCurrentItem();
                        this.nhanVienTableAdapter.Update(this.qLVTDataSet.NHANVIEN);
                        this.gcNhanVien.Enabled = true;

                        /*lưu 1 câu truy vấn để hoàn tác yêu cầu*/
                        String cauTruyVanHoanTac = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if( dangThemMoi == true)
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE DBO.NHANVIEN " +
                                "WHERE MANV = '" + txtMANV.Text.Trim() + "'";
                        }
                        /*trước khi ấn btnGHI là sửa thông tin nhân viên*/
                        else
                        {
                            
                            DataRowView drv = ((DataRowView)bdsNhanVien[bdsNhanVien.Position]);
                            String ho = drv["HO"].ToString();
                            String ten = drv["TEN"].ToString();
                            String sdt = drv["SDT"].ToString();
                            String diaChi = drv["DIACHI"].ToString();

                            DateTime ngaySinh = ((DateTime)drv["NGAYSINH"]);
                            //DateTime ngaySinh = DateTime.ParseExact(drv["NGAYSINH"].ToString(), "yyyy-MM-dd",
                            //                    System.Globalization.CultureInfo.InvariantCulture);


                            //int luong = int.Parse(drv["LUONG"].ToString());
                            String maChiNhanh = drv["MACN"].ToString();
                            int trangThai = (chbDanhDauDaXoa.Checked == true) ? 1 : 0;
                            int phai = (chbPhai.Checked == true) ? 1 : 0;

                            cauTruyVanHoanTac = 
                                "UPDATE DBO.NhanVien "+
                                "SET " +
                                "HO = N'" + ho + "'," +
                                "TEN = N'" + ten + "'," +
                                "DIACHI = N'" + diaChi + "'," +
                                "NGAYSINH = CAST('" + ngaySinh.ToString("yyyy-MM-dd") + "' AS DATETIME)," +
                                "SDT = '" + sdt + "',"+
                                "PHAI = '" + phai + "'," +
                                "DANHDAUDAXOA = '" + trangThai + "' " +
                                "WHERE MANV = '" + maNhanVien + "'";
                        }
                        Console.WriteLine(cauTruyVanHoanTac);

                        /*Đưa câu truy vấn hoàn tác vào undoList 
                         * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/
                        undoList.Push(cauTruyVanHoanTac);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch(Exception ex)
                    {

                        bdsNhanVien.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void dteNGAYSINH_Validating(object sender, CancelEventArgs e)
        {
            
        }


        /**************************************************************
         * Step 1: kiêm tra xem có nằm trên cùng chi nhánh không
         * Step 2: chuẩn bị các biến để lưu tên chi nhánh hiện tại và chi nhánh chuyển tới, tên nhân viên được chuyển
         * Step 3: trước khi thực hiện, lưu sẵn câu lệnh hoàn tác vào undoList + tên chi nhánh tới
         * Step 4: thực hiện chuyển chi nhánh với sp_ChuyenChiNhanh
         **************************************************************/
        public void chuyenChiNhanh(String chiNhanh, String maNVMoi )
        {
            //Console.WriteLine("Chi nhánh được chọn là " + chiNhanh);
            
            /*Step 1*/
            
            
            /*Step 2*/
            String maChiNhanhHienTai = "";
            String maChiNhanhMoi = "";
            int viTriHienTai = bdsNhanVien.Position;
            String maNhanVien = ((DataRowView)bdsNhanVien[viTriHienTai])["MANV"].ToString();

            if (chiNhanh.Contains("1"))
            {
                maChiNhanhHienTai = "CN2";
                maChiNhanhMoi = "CN1";
            }
            else if( chiNhanh.Contains("2"))
            {
                maChiNhanhHienTai = "CN1";
                maChiNhanhMoi = "CN2";
            }
            else
            {
                MessageBox.Show("Mã chi nhánh không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Console.WriteLine("Ma chi nhanh hien tai : " + maChiNhanhHienTai);
            Console.WriteLine("Ma chi nhanh Moi : " + maChiNhanhMoi);



            /*Step 3*/
            String cauTruyVanHoanTac = "EXEC sp_ChuyenChiNhanh '"+maNVMoi+"','"+maChiNhanhHienTai+"', '" + maNhanVien + "'";
            undoList.Push(cauTruyVanHoanTac);
           
            Program.serverNameLeft = chiNhanh; /*Lấy tên chi nhánh tới để làm tính năng hoàn tác*/
            Console.WriteLine("Ten server con lai" + Program.serverNameLeft);

            /*Step 4*/
            String cauTruyVan = "EXEC sp_ChuyenChiNhanh '" + maNhanVien + "','" + maChiNhanhMoi + "', '" + maNVMoi + "'"; ;
            Console.WriteLine("Cau Truy Van: " + cauTruyVan);
            Console.WriteLine("Cau Truy Van Hoan Tac: " + cauTruyVanHoanTac);

            SqlCommand sqlcommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                MessageBox.Show("Chuyển chi nhánh thành công", "thông báo", MessageBoxButtons.OK);

                if (Program.myReader == null)
                {
                    return;/*khong co ket qua tra ve thi ket thuc luon*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("thực thi database thất bại!\n\n" + ex.Message, "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            //this.nhanVienTableAdapter.Update(this.qLVTDataSet.NHANVIEN);
            this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NHANVIEN);

        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {

            //this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NHANVIEN.);
        }

        private void btnCHUYENCHINHANH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            int viTriHienTai = bdsNhanVien.Position;
            bool trangThaiXoa = bool.Parse(((DataRowView)(bdsNhanVien[viTriHienTai]))["DANHDAUDAXOA"].ToString());
            string maNhanVien = ((DataRowView)(bdsNhanVien[viTriHienTai]))["MANV"].ToString();

            if (maNhanVien == Program.userName)
            {
                MessageBox.Show("Không thể chuyển chính người đang đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /*Step 1 - Kiem tra trang thai xoa*/
            if (trangThaiXoa == true)
            {
                MessageBox.Show("Nhân viên này không có ở chi nhánh này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            /*Step 2 Kiem tra xem form da co trong bo nho chua*/
            Form f = this.CheckExists(typeof(FormChuyenChiNhanh));
            if (f != null)
            {
                f.Activate();
            }
            FormChuyenChiNhanh form = new FormChuyenChiNhanh();
            form.Show();

            /*Step 3*/
            /*đóng gói hàm chuyenChiNhanh từ formNHANVIEN đem về formChuyenChiNhanh để làm việc*/
            form.branchTransfer = new FormChuyenChiNhanh.MyDelegate(chuyenChiNhanh);

            /*Step 4*/
            this.btnHOANTAC.Enabled = true;
        }
    }
}
