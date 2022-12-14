using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormLoaiHang : Form
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

        Stack undoList = new Stack();
        public FormLoaiHang()
        {
            InitializeComponent();
        }

        private void lOAIHANGHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLHH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDataSet);

        }

        private void FormLoaiHang_Load(object sender, EventArgs e)
        {
            qLVTDataSet.EnforceConstraints = false;

            this.lOAIHANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOAIHANGHOATableAdapter.Fill(this.qLVTDataSet.LOAIHANGHOA);

            this.hANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.hANGHOATableAdapter.Fill(this.qLVTDataSet.HANGHOA);

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
                this.txtMALHH.Enabled = false;
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCHINHANH.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbCHINHANH.SelectedValue.ToString();

            Program.loginName = Program.currentLogin;
            Program.loginPassword = Program.currentPassword;

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.lOAIHANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOAIHANGHOATableAdapter.Fill(this.qLVTDataSet.LOAIHANGHOA);

                this.hANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.hANGHOATableAdapter.Fill(this.qLVTDataSet.HANGHOA);
            }
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsLHH.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;


            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsLHH.AddNew();

            /*Step 3*/
            this.txtMALHH.Enabled = true;
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;


            this.gcLHH.Enabled = false;
            this.panelNhapLieu.Enabled = true;
        }

        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                this.txtMALHH.Enabled = false;
                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnTHOAT.Enabled = true;


                this.gcLHH.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                bdsLHH.CancelEdit();
                /*xoa dong hien tai*/
                //bdsLHH.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsLHH.Position = viTri;
                this.lOAIHANGHOATableAdapter.Fill(this.qLVTDataSet.LOAIHANGHOA);
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
            bdsLHH.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            this.lOAIHANGHOATableAdapter.Fill(this.qLVTDataSet.LOAIHANGHOA);
        }

        private bool kiemTraDuLieuDauVao()
        {
            txtMALHH.Text = txtMALHH.Text.Trim();
            txtTEN.Text = txtTEN.Text.Trim();
            /*Kiem tra txtMAVT*/
            if (txtMALHH.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống mã loại hàng hóa", "Thông báo", MessageBoxButtons.OK);
                txtMALHH.Focus();
                return false;
            }

            if (Regex.IsMatch(txtMALHH.Text.Trim(), @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã vật tư chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMALHH.Focus();
                return false;
            }

            if (txtMALHH.Text.Trim().Length > 20)
            {
                MessageBox.Show("Mã loại hàng hóa không quá 20 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMALHH.Focus();
                return false;
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống tên loại", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            if (Regex.IsMatch(txtTEN.Text.Trim(), @"^[a-zA-Z0-9 ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$") == false)
            {
                MessageBox.Show("Tên loại chỉ chấp nhận chữ, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            if (txtTEN.Text.Trim().Length > 50)
            {
                MessageBox.Show("Tên vật tư không quá 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
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
            String ma = txtMALHH.Text.Trim();// Trim() de loai bo khoang trang thua
            DataRowView drv = ((DataRowView)bdsLHH[bdsLHH.Position]);
            String ten = drv["TEN"].ToString();


            /*declare @returnedResult int
              exec @returnedResult = sp_KiemTraMaVatTu '20'
              select @returnedResult*/


            /*Step 2*/
            int viTriConTro = bdsLHH.Position;
            int viTriMaVatTu = bdsLHH.Find("MALHH", txtMALHH.Text);

            if (viTriMaVatTu >= 0 && viTriConTro != viTriMaVatTu)
            {
                MessageBox.Show("Mã Loại hàng hóa đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn ghi vào cơ sở dữ liệu ?", "Thông báo",
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

                        this.txtMALHH.Enabled = false;
                        this.gcLHH.Enabled = true;

                        /*lưu 1 câu truy vấn để hoàn tác yêu cầu*/
                        String cauTruyVanHoanTac = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE DBO.LOAIHANGHOA " +
                                "WHERE MALHH = '" + txtMALHH.Text.Trim() + "'";
                        }
                        /*trước khi ấn btnGHI là sửa thông tin nhân viên*/
                        else
                        {
                            cauTruyVanHoanTac =
                                "UPDATE DBO.LOAIHANGHOA " +
                                "SET " +
                                "TEN = '" + ten + "'" +
                                "WHERE MALHH = '" + ma + "'";
                        }
                        //Console.WriteLine("CAU TRUY VAN HOAN TAC");
                        //Console.WriteLine(cauTruyVanHoanTac);

                        /*Đưa câu truy vấn hoàn tác vào undoList 
                         * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/
                        undoList.Push(cauTruyVanHoanTac);

                        this.bdsLHH.EndEdit();
                        this.lOAIHANGHOATableAdapter.Update(this.qLVTDataSet.LOAIHANGHOA);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bdsLHH.RemoveCurrent();
                        MessageBox.Show("Tên loại hàng có thể đã được dùng !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.lOAIHANGHOATableAdapter.Fill(this.qLVTDataSet.LOAIHANGHOA);
                //this.gcVATTU.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            if (bdsLHH.Count == 0)
            {
                btnXOA.Enabled = false;
            }

            if (bdsHH.Count > 0)
            {
                MessageBox.Show("Không thể xóa loại hàng này vì đã có sản phẩm", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            /* Phần này phục vụ tính năng hoàn tác
            * Đưa câu truy vấn hoàn tác vào undoList 
            * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/

            DataRowView drv = ((DataRowView)bdsLHH[bdsLHH.Position]);
            
            string cauTruyVanHoanTac =
            "INSERT INTO DBO.LOAIHANGHOA( MALHH,TEN) " +
            " VALUES( '" + drv["MALHH"].ToString() + "','" +
                        drv["TEN"].ToString() + "' ) ";

            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);

            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bdsLHH.Position;
                    bdsLHH.RemoveCurrent();

                    this.lOAIHANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOAIHANGHOATableAdapter.Update(this.qLVTDataSet.LOAIHANGHOA);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa hàng hóa. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.lOAIHANGHOATableAdapter.Fill(this.qLVTDataSet.LOAIHANGHOA);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsLHH.Position = viTri;
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
    }
}
