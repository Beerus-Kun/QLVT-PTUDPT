
namespace QLTVT
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label mANVLabel1;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label dANHDAUDAXOALabel;
            System.Windows.Forms.Label pHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.txtMACN = new DevExpress.XtraEditors.TextEdit();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new QLTVT.QLVTDataSet();
            this.dteNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
            this.chbPhai = new DevExpress.XtraEditors.CheckEdit();
            this.chbDanhDauDaXoa = new System.Windows.Forms.CheckBox();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANHDAUDAXOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.nhanVienTableAdapter = new QLTVT.QLVTDataSetTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager1 = new QLTVT.QLVTDataSetTableAdapters.TableAdapterManager();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLTVT.QLVTDataSetTableAdapters.PHIEUNHAPTableAdapter();
            this.bdsHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new QLTVT.QLVTDataSetTableAdapters.HOADONTableAdapter();
            this.bdsDonDat = new System.Windows.Forms.BindingSource(this.components);
            this.donDatTableAdapter = new QLTVT.QLVTDataSetTableAdapters.DONDATTableAdapter();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            mANVLabel1 = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            dANHDAUDAXOALabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYSINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(304, 45);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(552, 47);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(956, 48);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(40, 13);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "MACN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(77, 126);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(304, 126);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(62, 13);
            nGAYSINHLabel.TabIndex = 15;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // mANVLabel1
            // 
            mANVLabel1.AutoSize = true;
            mANVLabel1.Location = new System.Drawing.Point(77, 45);
            mANVLabel1.Name = "mANVLabel1";
            mANVLabel1.Size = new System.Drawing.Size(39, 13);
            mANVLabel1.TabIndex = 16;
            mANVLabel1.Text = "MANV:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(552, 126);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(30, 13);
            sDTLabel.TabIndex = 20;
            sDTLabel.Text = "SDT:";
            // 
            // dANHDAUDAXOALabel
            // 
            dANHDAUDAXOALabel.AutoSize = true;
            dANHDAUDAXOALabel.Location = new System.Drawing.Point(773, 126);
            dANHDAUDAXOALabel.Name = "dANHDAUDAXOALabel";
            dANHDAUDAXOALabel.Size = new System.Drawing.Size(104, 13);
            dANHDAUDAXOALabel.TabIndex = 21;
            dANHDAUDAXOALabel.Text = "DANH DAU DA XOA:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(773, 48);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(68, 13);
            pHAILabel.TabIndex = 22;
            pHAILabel.Text = "PHAI (NAM):";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTHEM,
            this.btnXOA,
            this.btnGHI,
            this.btnHOANTAC,
            this.btnLAMMOI,
            this.btnTHOAT,
            this.btnCHUYENCHINHANH});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHOANTAC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCHUYENCHINHANH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "Thêm";
            this.btnTHEM.Id = 0;
            this.btnTHEM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHEM.ImageOptions.SvgImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(80, 0);
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Caption = "Xoá";
            this.btnXOA.Id = 1;
            this.btnXOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXOA.ImageOptions.SvgImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(70, 0);
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnGHI
            // 
            this.btnGHI.Caption = "Ghi";
            this.btnGHI.Id = 2;
            this.btnGHI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGHI.ImageOptions.SvgImage")));
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(70, 0);
            this.btnGHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.Caption = "Hoàn Tác";
            this.btnHOANTAC.Id = 3;
            this.btnHOANTAC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHOANTAC.ImageOptions.SvgImage")));
            this.btnHOANTAC.Name = "btnHOANTAC";
            this.btnHOANTAC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHOANTAC_ItemClick);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Caption = "Làm Mới";
            this.btnLAMMOI.Id = 4;
            this.btnLAMMOI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI.ImageOptions.SvgImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_ItemClick);
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 8;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            this.btnCHUYENCHINHANH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCHUYENCHINHANH_ItemClick);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Thoát";
            this.btnTHOAT.Id = 6;
            this.btnTHOAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHOAT.ImageOptions.SvgImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1195, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 475);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1195, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 451);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1195, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 451);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbCHINHANH);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1195, 17);
            this.panelControl1.TabIndex = 4;
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.Enabled = false;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(319, 27);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(316, 21);
            this.cmbCHINHANH.TabIndex = 1;
            this.cmbCHINHANH.Visible = false;
            this.cmbCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            this.label1.Visible = false;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.txtMACN);
            this.panelNhapLieu.Controls.Add(this.dteNGAYSINH);
            this.panelNhapLieu.Controls.Add(this.txtDIACHI);
            this.panelNhapLieu.Controls.Add(pHAILabel);
            this.panelNhapLieu.Controls.Add(this.chbPhai);
            this.panelNhapLieu.Controls.Add(dANHDAUDAXOALabel);
            this.panelNhapLieu.Controls.Add(this.chbDanhDauDaXoa);
            this.panelNhapLieu.Controls.Add(sDTLabel);
            this.panelNhapLieu.Controls.Add(this.txtSDT);
            this.panelNhapLieu.Controls.Add(this.txtTEN);
            this.panelNhapLieu.Controls.Add(this.txtHO);
            this.panelNhapLieu.Controls.Add(this.txtMANV);
            this.panelNhapLieu.Controls.Add(mANVLabel1);
            this.panelNhapLieu.Controls.Add(nGAYSINHLabel);
            this.panelNhapLieu.Controls.Add(dIACHILabel);
            this.panelNhapLieu.Controls.Add(mACNLabel);
            this.panelNhapLieu.Controls.Add(tENLabel);
            this.panelNhapLieu.Controls.Add(hOLabel);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 214);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(1195, 261);
            this.panelNhapLieu.TabIndex = 9;
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "MACN", true));
            this.txtMACN.Location = new System.Drawing.Point(1012, 45);
            this.txtMACN.MenuManager = this.barManager1;
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(68, 20);
            this.txtMACN.TabIndex = 26;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NHANVIEN";
            this.bdsNhanVien.DataSource = this.qLVTDataSet;
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dteNGAYSINH
            // 
            this.dteNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "NGAYSINH", true));
            this.dteNGAYSINH.EditValue = null;
            this.dteNGAYSINH.Location = new System.Drawing.Point(387, 123);
            this.dteNGAYSINH.MenuManager = this.barManager1;
            this.dteNGAYSINH.Name = "dteNGAYSINH";
            this.dteNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYSINH.Size = new System.Drawing.Size(125, 20);
            this.dteNGAYSINH.TabIndex = 25;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(139, 123);
            this.txtDIACHI.MenuManager = this.barManager1;
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(115, 20);
            this.txtDIACHI.TabIndex = 24;
            // 
            // chbPhai
            // 
            this.chbPhai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "PHAI", true));
            this.chbPhai.Location = new System.Drawing.Point(913, 44);
            this.chbPhai.MenuManager = this.barManager1;
            this.chbPhai.Name = "chbPhai";
            this.chbPhai.Properties.Caption = "";
            this.chbPhai.Size = new System.Drawing.Size(18, 20);
            this.chbPhai.TabIndex = 23;
            // 
            // chbDanhDauDaXoa
            // 
            this.chbDanhDauDaXoa.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsNhanVien, "DANHDAUDAXOA", true));
            this.chbDanhDauDaXoa.Location = new System.Drawing.Point(913, 121);
            this.chbDanhDauDaXoa.Name = "chbDanhDauDaXoa";
            this.chbDanhDauDaXoa.Size = new System.Drawing.Size(104, 24);
            this.chbDanhDauDaXoa.TabIndex = 22;
            this.chbDanhDauDaXoa.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(615, 119);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(125, 20);
            this.txtSDT.TabIndex = 21;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(615, 45);
            this.txtTEN.MenuManager = this.barManager1;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(125, 20);
            this.txtTEN.TabIndex = 20;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(387, 45);
            this.txtHO.MenuManager = this.barManager1;
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(125, 20);
            this.txtHO.TabIndex = 19;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(139, 42);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(116, 21);
            this.txtMANV.TabIndex = 18;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colSDT,
            this.colMACN,
            this.colDANHDAUDAXOA});
            this.gridView1.GridControl = this.gcNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 100;
            this.gridView1.OptionsFind.FindFilterColumns = "MANV";
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái (nam)";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 5;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số điện thoại";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 6;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            // 
            // colDANHDAUDAXOA
            // 
            this.colDANHDAUDAXOA.Caption = "Đã xóa";
            this.colDANHDAUDAXOA.FieldName = "DANHDAUDAXOA";
            this.colDANHDAUDAXOA.Name = "colDANHDAUDAXOA";
            this.colDANHDAUDAXOA.Visible = true;
            this.colDANHDAUDAXOA.VisibleIndex = 8;
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.bdsNhanVien;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanVien.EmbeddedNavigator.Enabled = false;
            this.gcNhanVien.Location = new System.Drawing.Point(0, 41);
            this.gcNhanVien.MainView = this.gridView1;
            this.gcNhanVien.MenuManager = this.barManager1;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1195, 173);
            this.gcNhanVien.TabIndex = 8;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CHINHANHTableAdapter = null;
            this.tableAdapterManager1.CTDDTableAdapter = null;
            this.tableAdapterManager1.CTHDTableAdapter = null;
            this.tableAdapterManager1.CTPNTableAdapter = null;
            this.tableAdapterManager1.DONDATTableAdapter = null;
            this.tableAdapterManager1.HANGHOATableAdapter = null;
            this.tableAdapterManager1.HOADONTableAdapter = null;
            this.tableAdapterManager1.KHACHHANGTableAdapter = null;
            this.tableAdapterManager1.KHOTableAdapter = null;
            this.tableAdapterManager1.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager1.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager1.NHANVIENTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager1.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLTVT.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "FK_PHIEUNHAP_NHANVIEN";
            this.bdsPhieuNhap.DataSource = this.bdsNhanVien;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // bdsHoaDon
            // 
            this.bdsHoaDon.DataMember = "FK_HOADON_NHANVIEN";
            this.bdsHoaDon.DataSource = this.bdsNhanVien;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDonDat
            // 
            this.bdsDonDat.DataMember = "FK__DONDAT__MANV__4316F928";
            this.bdsDonDat.DataSource = this.bdsNhanVien;
            // 
            // donDatTableAdapter
            // 
            this.donDatTableAdapter.ClearBeforeFill = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 495);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormNhanVien";
            this.Text = "Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYSINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        //private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelNhapLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private QLVTDataSetTableAdapters.NHANVIENTableAdapter nhanVienTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colDANHDAUDAXOA;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.CheckBox chbDanhDauDaXoa;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private QLVTDataSetTableAdapters.PHIEUNHAPTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsHoaDon;
        private QLVTDataSetTableAdapters.HOADONTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.BindingSource bdsDonDat;
        private QLVTDataSetTableAdapters.DONDATTableAdapter donDatTableAdapter;
        private DevExpress.XtraEditors.CheckEdit chbPhai;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraEditors.DateEdit dteNGAYSINH;
        private DevExpress.XtraEditors.TextEdit txtDIACHI;
        private DevExpress.XtraEditors.TextEdit txtMACN;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
    }
}