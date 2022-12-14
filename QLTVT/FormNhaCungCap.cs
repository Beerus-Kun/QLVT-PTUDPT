using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLTVT
{
    public partial class FormNhaCungCap : Form
    {
        /* vị trí của con trỏ trên grid view*/
        int viTri = 0;
        /********************************************
         * đang thêm mới -> true -> đang dùng btnTHEM
         *              -> false -> có thể là btnGHI( chỉnh sửa) hoặc btnXOA
         *              
         * Mục đích: dùng biến này để phân biệt giữa btnTHEM - thêm mới hoàn toàn
         * và việc chỉnh sửa nhân viên( do mình ko dùng thêm btnXOA )
         * Trạng thái true or false sẽ được sử dụng 
         * trong btnGHI - việc này để phục vụ cho btnHOANTAC
         ********************************************/
        bool dangThemMoi = false;

        String maChiNhanh = "";
        /**********************************************************
         * undoList - phục vụ cho btnHOANTAC -  chứa các thông tin của đối tượng bị tác động 
         * 
         * nó là nơi lưu trữ các đối tượng cần thiết để hoàn tác các thao tác
         * 
         * nếu btnGHI sẽ ứng với INSERT
         * nếu btnXOA sẽ ứng với DELETE
         * nếu btnCHUYENCHINHANH sẽ ứng với CHANGEBRAND
         **********************************************************/
        Stack undoList = new Stack();

        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void nHACUNGCAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhaCungCap.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            qLVTDataSet.EnforceConstraints = false;

            this.nhaCungCapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhaCungCapTableAdapter.Fill(this.qLVTDataSet.NHACUNGCAP);

            this.donDatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.donDatTableAdapter.Fill(this.qLVTDataSet.DONDAT);

            /*van con ton tai loi chua sua duoc*/
            //maChiNhanh = ((DataRowView)bdsNhaCungCap[0])["MACN"].ToString();

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
                this.btnCHUYENCHINHANH.Enabled = true;
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
                this.btnTHOAT.Enabled = true;

                this.panelNhapLieu.Enabled = true;
                this.txtMANCC.Enabled = false;
            }
        }

        private void tENTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tENLabel_Click(object sender, EventArgs e)
        {

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
                this.nhaCungCapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhaCungCapTableAdapter.Fill(this.qLVTDataSet.NHACUNGCAP);

                this.donDatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.donDatTableAdapter.Fill(this.qLVTDataSet.DONDAT);
            }
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsNhaCungCap.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;


            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsNhaCungCap.AddNew();

            Random rnd = new Random();
            txtSDT.Text = "0" + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString();
            txtDIACHI.Text = "97 Man Thiện";

            /*Step 3*/
            this.txtMANCC.Enabled = true;
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;


            this.gcNhaCungCap.Enabled = false;
            this.panelNhapLieu.Enabled = true;
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhaCungCapTableAdapter.Fill(this.qLVTDataSet.NHACUNGCAP);
                this.gcNhaCungCap.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private bool kiemTraDuLieuDauVao()
        {
            txtMANCC.Text = txtMANCC.Text.Trim();
            txtTEN.Text = txtTEN.Text.Trim();
            txtDIACHI.Text = txtDIACHI.Text.Trim();
            txtSDT.Text = txtSDT.Text.Trim();

            if (txtMANCC.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                txtMANCC.Focus();
                return false;
            }

            if (Regex.IsMatch(txtMANCC.Text.Trim(), @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                txtMANCC.Focus();
                return false;
            }

            if (txtMANCC.Text.Trim().Length > 20)
            {
                MessageBox.Show("Mã kho không thể lớn hơn 20 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMANCC.Focus();
                return false;
            }

            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống tên kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            if (Regex.IsMatch(txtTEN.Text.Trim(), @"^[a-zA-Z0-9 ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            if (txtTEN.Text.Trim().Length > 50)
            {
                MessageBox.Show("Tên kho không thể quá 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            if (txtDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return false;
            }

            if (Regex.IsMatch(txtDIACHI.Text.Trim(), @"^[a-zA-Z0-9 ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ/-]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ chấp nhận chữ cái, số, khoảng trắng, dấu '-', '/", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return false;
            }

            if (txtDIACHI.Text.Trim().Length > 100)
            {
                MessageBox.Show("Tên kho không thể quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return false;
            }

            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống số điện thoại", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
                return false;
            }

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

            /*Step 1*/
            /*Lay du lieu truoc khi chon btnGHI - phuc vu btnHOANTAC*/
            String maKhoHang = txtMANCC.Text.Trim();// Trim() de loai bo khoang trang thua
            DataRowView drv = ((DataRowView)bdsNhaCungCap[bdsNhaCungCap.Position]);
            String tenKhoHang = drv["TEN"].ToString();
            String diaChi = drv["DIACHI"].ToString();
            String sdt = drv["SDT"].ToString();

            /*Step 2*/
            int viTriConTro = bdsNhaCungCap.Position;
            int viTriMaKhoHang = bdsNhaCungCap.Find("MANCC", txtMANCC.Text);

            if (viTriMaKhoHang >= 0 && viTriConTro != viTriMaKhoHang)
            {
                MessageBox.Show("Mã kho hàng này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        /*bật các nút về ban đầu*/
                        btnTHEM.Enabled = true;
                        btnXOA.Enabled = true;
                        btnGHI.Enabled = true;
                        btnHOANTAC.Enabled = true;

                        btnLAMMOI.Enabled = true;
                        btnCHUYENCHINHANH.Enabled = true;
                        btnTHOAT.Enabled = true;

                        this.txtMANCC.Enabled = false;
                        this.gcNhaCungCap.Enabled = true;

                        /*lưu 1 câu truy vấn để hoàn tác yêu cầu*/
                        String cauTruyVanHoanTac = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE DBO.NHACUNGCAP " +
                                "WHERE MANCC = '" + txtMANCC.Text.Trim() + "'";
                        }
                        /*trước khi ấn btnGHI là sửa thông tin kho*/
                        else
                        {
                            cauTruyVanHoanTac =
                                "UPDATE DBO.NHACUNGCAP " +
                                "SET " +
                                "TEN = '" + tenKhoHang + "' ," +
                                "DIACHI = '" + diaChi + "' ," +
                                "SDT = '" + sdt + "'" +
                                "WHERE MANCC = '" + maKhoHang + "'";
                        }
                        //Console.WriteLine("CAU TRUY VAN HOAN TAC");
                        //Console.WriteLine(cauTruyVanHoanTac);

                        /*Đưa câu truy vấn hoàn tác vào undoList 
                         * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/
                        undoList.Push(cauTruyVanHoanTac);

                        this.bdsNhaCungCap.EndEdit();
                        this.nhaCungCapTableAdapter.Update(this.qLVTDataSet.NHACUNGCAP);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bdsNhaCungCap.RemoveCurrent();
                        MessageBox.Show("Tên nhà cung cấp có thể đã được dùng !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                this.txtMANCC.Enabled = false;
                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnTHOAT.Enabled = true;


                this.gcNhaCungCap.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                bdsNhaCungCap.CancelEdit();
                /*xoa dong hien tai*/
                //bdsNhaCungCap.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsNhaCungCap.Position = viTri;
                this.nhaCungCapTableAdapter.Fill(this.qLVTDataSet.NHACUNGCAP);
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
            bdsNhaCungCap.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            bdsNhaCungCap.Position = viTri;
            this.nhaCungCapTableAdapter.Fill(this.qLVTDataSet.NHACUNGCAP);
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            if (bdsNhaCungCap.Count == 0)
            {
                btnXOA.Enabled = false;
            }

            if (bdsDonDat.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho hàng này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            /* Phần này phục vụ tính năng hoàn tác
                    * Đưa câu truy vấn hoàn tác vào undoList 
                    * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/
            DataRowView drv = ((DataRowView)bdsNhaCungCap[bdsNhaCungCap.Position]);

            string cauTruyVanHoanTac =
            "INSERT INTO DBO.NHACUNGCAP( MANCC,TEN, DIACHI, SDT) " +
            " VALUES( '" + drv["MANCC"].ToString() + "','" +
                        drv["TEN"].ToString() + "','" +
                        drv["DIACHI"].ToString() + "','" +
                        drv["SDT"].ToString() + "' ) ";

            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);

            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bdsNhaCungCap.Position;
                    bdsNhaCungCap.RemoveCurrent();

                    this.nhaCungCapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhaCungCapTableAdapter.Update(this.qLVTDataSet.NHACUNGCAP);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.nhaCungCapTableAdapter.Fill(this.qLVTDataSet.NHACUNGCAP);
                    bdsNhaCungCap.Position = viTri;
                    return;
                }
            }
            else
            {
                // xoa cau truy van hoan tac di
                undoList.Pop();
            }
        }

    }
}
