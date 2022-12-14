
namespace QLTVT.SubForm
{
    partial class FormChonHangHoaTheoKho
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
            this.qLVTDataSet = new QLTVT.QLVTDataSet();
            this.bdsChiTietHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.cthdTableAdapter = new QLTVT.QLVTDataSetTableAdapters.view_ChonChiTietHoaDonTableAdapter();
            this.tableAdapterManager = new QLTVT.QLVTDataSetTableAdapters.TableAdapterManager();
            this.view_ChonChiTietHoaDonGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnCHON = new System.Windows.Forms.Button();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ChonChiTietHoaDonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsChiTietHoaDon
            // 
            this.bdsChiTietHoaDon.DataMember = "view_ChonChiTietHoaDon";
            this.bdsChiTietHoaDon.DataSource = this.qLVTDataSet;
            // 
            // cthdTableAdapter
            // 
            this.cthdTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDTableAdapter = null;
            this.tableAdapterManager.CTHDTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.DONDATTableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_ChonChiTietHoaDonGridControl
            // 
            this.view_ChonChiTietHoaDonGridControl.DataSource = this.bdsChiTietHoaDon;
            this.view_ChonChiTietHoaDonGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_ChonChiTietHoaDonGridControl.Location = new System.Drawing.Point(0, 0);
            this.view_ChonChiTietHoaDonGridControl.MainView = this.gridView1;
            this.view_ChonChiTietHoaDonGridControl.Name = "view_ChonChiTietHoaDonGridControl";
            this.view_ChonChiTietHoaDonGridControl.Size = new System.Drawing.Size(800, 220);
            this.view_ChonChiTietHoaDonGridControl.TabIndex = 1;
            this.view_ChonChiTietHoaDonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH,
            this.colTENHH,
            this.colSL,
            this.colDONGIA,
            this.colMAKHO,
            this.colTENKHO});
            this.gridView1.GridControl = this.view_ChonChiTietHoaDonGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAHH
            // 
            this.colMAHH.Caption = "Mã Hàng Hóa";
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 0;
            // 
            // colTENHH
            // 
            this.colTENHH.Caption = "Tên Hàng Hóa";
            this.colTENHH.FieldName = "TENHH";
            this.colTENHH.Name = "colTENHH";
            this.colTENHH.Visible = true;
            this.colTENHH.VisibleIndex = 1;
            // 
            // colSL
            // 
            this.colSL.Caption = "Số lượng";
            this.colSL.FieldName = "SL";
            this.colSL.Name = "colSL";
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 2;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên Kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 5;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.BackColor = System.Drawing.Color.Red;
            this.btnTHOAT.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.ForeColor = System.Drawing.Color.White;
            this.btnTHOAT.Location = new System.Drawing.Point(489, 326);
            this.btnTHOAT.Margin = new System.Windows.Forms.Padding(2);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(138, 35);
            this.btnTHOAT.TabIndex = 5;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btnCHON
            // 
            this.btnCHON.BackColor = System.Drawing.Color.Blue;
            this.btnCHON.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCHON.ForeColor = System.Drawing.Color.White;
            this.btnCHON.Location = new System.Drawing.Point(234, 326);
            this.btnCHON.Margin = new System.Windows.Forms.Padding(2);
            this.btnCHON.Name = "btnCHON";
            this.btnCHON.Size = new System.Drawing.Size(138, 35);
            this.btnCHON.TabIndex = 4;
            this.btnCHON.Text = "CHỌN";
            this.btnCHON.UseVisualStyleBackColor = false;
            this.btnCHON.Click += new System.EventHandler(this.btnCHON_Click);
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn Giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // FormChonHangHoaTheoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnCHON);
            this.Controls.Add(this.view_ChonChiTietHoaDonGridControl);
            this.Name = "FormChonHangHoaTheoKho";
            this.Text = "Hàng Hóa Trong Kho";
            this.Load += new System.EventHandler(this.FormChonHangHoaTheoKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ChonChiTietHoaDonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource bdsChiTietHoaDon;
        private QLVTDataSetTableAdapters.view_ChonChiTietHoaDonTableAdapter cthdTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl view_ChonChiTietHoaDonGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnCHON;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
    }
}