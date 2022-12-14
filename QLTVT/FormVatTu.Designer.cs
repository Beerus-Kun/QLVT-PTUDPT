
namespace QLTVT
{
    partial class FormVatTu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label txtDONGIA;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVatTu));
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new QLTVT.QLVTDataSet();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            this.mALHHLabel = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcVATTU = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNhapLieu = new DevExpress.XtraEditors.GroupControl();
            this.txtMAVT = new System.Windows.Forms.TextBox();
            this.txtTIEN = new DevExpress.XtraEditors.TextEdit();
            this.txtDONVIVATTU = new DevExpress.XtraEditors.TextEdit();
            this.cmbMALHH = new System.Windows.Forms.ComboBox();
            this.lOAIHANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTENVT = new DevExpress.XtraEditors.TextEdit();
            this.hangHoaTableAdapter = new QLTVT.QLVTDataSetTableAdapters.HANGHOATableAdapter();
            this.tableAdapterManager = new QLTVT.QLVTDataSetTableAdapters.TableAdapterManager();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.ctpnTableAdapter = new QLTVT.QLVTDataSetTableAdapters.CTPNTableAdapter();
            this.bdsCTHD = new System.Windows.Forms.BindingSource(this.components);
            this.cthdTableAdapter = new QLTVT.QLVTDataSetTableAdapters.CTHDTableAdapter();
            this.bdsCTDD = new System.Windows.Forms.BindingSource(this.components);
            this.ctddTableAdapter = new QLTVT.QLVTDataSetTableAdapters.CTDDTableAdapter();
            this.lOAIHANGHOATableAdapter = new QLTVT.QLVTDataSetTableAdapters.LOAIHANGHOATableAdapter();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            txtDONGIA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVATTU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTIEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDONVIVATTU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(9, 49);
            mAVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(73, 13);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã hàng hóa:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(236, 49);
            tENVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(56, 13);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên hàng:";
            tENVTLabel.Click += new System.EventHandler(this.tENVTLabel_Click);
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(9, 90);
            dVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(59, 13);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tính";
            // 
            // txtDONGIA
            // 
            txtDONGIA.AutoSize = true;
            txtDONGIA.Location = new System.Drawing.Point(241, 90);
            txtDONGIA.Name = "txtDONGIA";
            txtDONGIA.Size = new System.Drawing.Size(48, 13);
            txtDONGIA.TabIndex = 13;
            txtDONGIA.Text = "Đơn giá:";
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "HANGHOA";
            this.bdsVatTu.DataSource = this.qLVTDataSet;
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnCHUYENCHINHANH,
            this.btnTHOAT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Thoát";
            this.btnTHOAT.Id = 6;
            this.btnTHOAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHOAT.ImageOptions.SvgImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(810, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 458);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(810, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 434);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(810, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 434);
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 5;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            // 
            // mALHHLabel
            // 
            this.mALHHLabel.AutoSize = true;
            this.mALHHLabel.Location = new System.Drawing.Point(494, 49);
            this.mALHHLabel.Name = "mALHHLabel";
            this.mALHHLabel.Size = new System.Drawing.Size(57, 13);
            this.mALHHLabel.TabIndex = 10;
            this.mALHHLabel.Text = "Loại hàng:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcVATTU);
            this.panelControl1.Controls.Add(this.cmbCHINHANH);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(810, 308);
            this.panelControl1.TabIndex = 5;
            // 
            // gcVATTU
            // 
            this.gcVATTU.DataSource = this.bdsVatTu;
            this.gcVATTU.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcVATTU.Location = new System.Drawing.Point(2, 7);
            this.gcVATTU.MainView = this.gridView1;
            this.gcVATTU.MenuManager = this.barManager1;
            this.gcVATTU.Name = "gcVATTU";
            this.gcVATTU.Size = new System.Drawing.Size(806, 299);
            this.gcVATTU.TabIndex = 2;
            this.gcVATTU.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH,
            this.colTEN,
            this.colMALHH,
            this.colDONVI,
            this.colDONGIA});
            this.gridView1.GridControl = this.gcVATTU;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 100;
            // 
            // colMAHH
            // 
            this.colMAHH.Caption = "Mã hàng";
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 0;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên sản phẩm";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            // 
            // colMALHH
            // 
            this.colMALHH.Caption = "Mã loại";
            this.colMALHH.FieldName = "MALHH";
            this.colMALHH.Name = "colMALHH";
            this.colMALHH.Visible = true;
            this.colMALHH.VisibleIndex = 2;
            // 
            // colDONVI
            // 
            this.colDONVI.Caption = "Đơn vị";
            this.colDONVI.FieldName = "DONVI";
            this.colDONVI.Name = "colDONVI";
            this.colDONVI.Visible = true;
            this.colDONVI.VisibleIndex = 3;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.DisplayFormat.FormatString = "N0";
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 4;
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.Enabled = false;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(239, 22);
            this.cmbCHINHANH.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(238, 21);
            this.cmbCHINHANH.TabIndex = 1;
            this.cmbCHINHANH.Visible = false;
            this.cmbCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            this.label1.Visible = false;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.txtMAVT);
            this.panelNhapLieu.Controls.Add(txtDONGIA);
            this.panelNhapLieu.Controls.Add(this.txtTIEN);
            this.panelNhapLieu.Controls.Add(this.txtDONVIVATTU);
            this.panelNhapLieu.Controls.Add(this.cmbMALHH);
            this.panelNhapLieu.Controls.Add(this.mALHHLabel);
            this.panelNhapLieu.Controls.Add(this.txtTENVT);
            this.panelNhapLieu.Controls.Add(dVTLabel);
            this.panelNhapLieu.Controls.Add(tENVTLabel);
            this.panelNhapLieu.Controls.Add(mAVTLabel);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 332);
            this.panelNhapLieu.Margin = new System.Windows.Forms.Padding(2);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(810, 126);
            this.panelNhapLieu.TabIndex = 21;
            this.panelNhapLieu.Text = "Thông tin";
            this.panelNhapLieu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNhapLieu_Paint);
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "MAHH", true));
            this.txtMAVT.Location = new System.Drawing.Point(83, 45);
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(100, 21);
            this.txtMAVT.TabIndex = 15;
            // 
            // txtTIEN
            // 
            this.txtTIEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "DONGIA", true));
            this.txtTIEN.Location = new System.Drawing.Point(311, 87);
            this.txtTIEN.MenuManager = this.barManager1;
            this.txtTIEN.Name = "txtTIEN";
            this.txtTIEN.Properties.DisplayFormat.FormatString = "n0";
            this.txtTIEN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTIEN.Properties.Mask.EditMask = "N0";
            this.txtTIEN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTIEN.Size = new System.Drawing.Size(137, 20);
            this.txtTIEN.TabIndex = 14;
            // 
            // txtDONVIVATTU
            // 
            this.txtDONVIVATTU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "DONVI", true));
            this.txtDONVIVATTU.Location = new System.Drawing.Point(83, 87);
            this.txtDONVIVATTU.MenuManager = this.barManager1;
            this.txtDONVIVATTU.Name = "txtDONVIVATTU";
            this.txtDONVIVATTU.Size = new System.Drawing.Size(100, 20);
            this.txtDONVIVATTU.TabIndex = 13;
            // 
            // cmbMALHH
            // 
            this.cmbMALHH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsVatTu, "MALHH", true));
            this.cmbMALHH.DataSource = this.lOAIHANGHOABindingSource;
            this.cmbMALHH.DisplayMember = "TEN";
            this.cmbMALHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMALHH.FormattingEnabled = true;
            this.cmbMALHH.Location = new System.Drawing.Point(557, 46);
            this.cmbMALHH.Name = "cmbMALHH";
            this.cmbMALHH.Size = new System.Drawing.Size(125, 21);
            this.cmbMALHH.TabIndex = 12;
            this.cmbMALHH.ValueMember = "MALHH";
            // 
            // lOAIHANGHOABindingSource
            // 
            this.lOAIHANGHOABindingSource.DataMember = "LOAIHANGHOA";
            this.lOAIHANGHOABindingSource.DataSource = this.qLVTDataSet;
            // 
            // txtTENVT
            // 
            this.txtTENVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "TEN", true));
            this.txtTENVT.Location = new System.Drawing.Point(311, 46);
            this.txtTENVT.MenuManager = this.barManager1;
            this.txtTENVT.Name = "txtTENVT";
            this.txtTENVT.Size = new System.Drawing.Size(137, 20);
            this.txtTENVT.TabIndex = 10;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CTDDTableAdapter = null;
            this.tableAdapterManager.CTHDTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.DONDATTableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = this.hangHoaTableAdapter;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_HANGHOA";
            this.bdsCTPN.DataSource = this.bdsVatTu;
            // 
            // ctpnTableAdapter
            // 
            this.ctpnTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTHD
            // 
            this.bdsCTHD.DataMember = "FK_CTHD_HANGHOA";
            this.bdsCTHD.DataSource = this.bdsVatTu;
            // 
            // cthdTableAdapter
            // 
            this.cthdTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDD
            // 
            this.bdsCTDD.DataMember = "FK__CTDD__MAHH__46E78A0C";
            this.bdsCTDD.DataSource = this.bdsVatTu;
            // 
            // ctddTableAdapter
            // 
            this.ctddTableAdapter.ClearBeforeFill = true;
            // 
            // lOAIHANGHOATableAdapter
            // 
            this.lOAIHANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this.qLVTDataSet;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 478);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVatTu";
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVATTU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTIEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDONVIVATTU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl panelNhapLieu;
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private QLVTDataSetTableAdapters.HANGHOATableAdapter hangHoaTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtTENVT;
        private DevExpress.XtraEditors.TextEdit txtTIEN;
        private DevExpress.XtraEditors.TextEdit txtDONVIVATTU;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private QLVTDataSetTableAdapters.CTPNTableAdapter ctpnTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTHD;
        private QLVTDataSetTableAdapters.CTHDTableAdapter cthdTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDD;
        private QLVTDataSetTableAdapters.CTDDTableAdapter ctddTableAdapter;
        private System.Windows.Forms.BindingSource lOAIHANGHOABindingSource;
        private QLVTDataSetTableAdapters.LOAIHANGHOATableAdapter lOAIHANGHOATableAdapter;
        private System.Windows.Forms.ComboBox cmbMALHH;
        private System.Windows.Forms.Label mALHHLabel;
        private System.Windows.Forms.TextBox txtMAVT;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private DevExpress.XtraGrid.GridControl gcVATTU;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMALHH;
        private DevExpress.XtraGrid.Columns.GridColumn colDONVI;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
    }
}