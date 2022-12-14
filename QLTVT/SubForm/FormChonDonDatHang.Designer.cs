
namespace QLTVT.SubForm
{
    partial class FormChonDonDatHang
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
            this.datHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsDonDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new QLTVT.QLVTDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCHON = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.datHangTableAdapter = new QLTVT.QLVTDataSetTableAdapters.DONDATTableAdapter();
            this.tableAdapterManager = new QLTVT.QLVTDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datHangGridControl
            // 
            this.datHangGridControl.DataSource = this.bdsDonDatHang;
            this.datHangGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.datHangGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.datHangGridControl.Location = new System.Drawing.Point(0, 0);
            this.datHangGridControl.MainView = this.gridView1;
            this.datHangGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.datHangGridControl.Name = "datHangGridControl";
            this.datHangGridControl.Size = new System.Drawing.Size(600, 243);
            this.datHangGridControl.TabIndex = 1;
            this.datHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsDonDatHang
            // 
            this.bdsDonDatHang.DataMember = "view_ChonChiTietHoaDon";
            this.bdsDonDatHang.DataSource = this.qLVTDataSet;
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADD,
            this.colMANCC,
            this.colTHOIGIAN,
            this.colMANV});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.datHangGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMADD
            // 
            this.colMADD.Caption = "Mã Đơn Đặt";
            this.colMADD.FieldName = "MADD";
            this.colMADD.Name = "colMADD";
            this.colMADD.Visible = true;
            this.colMADD.VisibleIndex = 0;
            // 
            // colMANCC
            // 
            this.colMANCC.Caption = "Mã Nhà Cung Cấp";
            this.colMANCC.FieldName = "MANCC";
            this.colMANCC.Name = "colMANCC";
            this.colMANCC.Visible = true;
            this.colMANCC.VisibleIndex = 1;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.Caption = "Thời Gian";
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Nhân Viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // btnCHON
            // 
            this.btnCHON.BackColor = System.Drawing.Color.Blue;
            this.btnCHON.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCHON.ForeColor = System.Drawing.Color.White;
            this.btnCHON.Location = new System.Drawing.Point(70, 277);
            this.btnCHON.Margin = new System.Windows.Forms.Padding(2);
            this.btnCHON.Name = "btnCHON";
            this.btnCHON.Size = new System.Drawing.Size(134, 33);
            this.btnCHON.TabIndex = 2;
            this.btnCHON.Text = "CHỌN";
            this.btnCHON.UseVisualStyleBackColor = false;
            this.btnCHON.Click += new System.EventHandler(this.btnCHON_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.BackColor = System.Drawing.Color.Red;
            this.btnTHOAT.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.ForeColor = System.Drawing.Color.White;
            this.btnTHOAT.Location = new System.Drawing.Point(355, 277);
            this.btnTHOAT.Margin = new System.Windows.Forms.Padding(2);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(134, 33);
            this.btnTHOAT.TabIndex = 3;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CTDDTableAdapter = null;
            this.tableAdapterManager.CTHDTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.DONDATTableAdapter = this.datHangTableAdapter;
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
            // FormChonDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 340);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnCHON);
            this.Controls.Add(this.datHangGridControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormChonDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Đơn Đặt Hàng";
            this.Load += new System.EventHandler(this.FormChonDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl datHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnCHON;
        private System.Windows.Forms.Button btnTHOAT;
        private QLVTDataSet qLVTDataSet;
        private QLVTDataSetTableAdapters.DONDATTableAdapter datHangTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMADD;
        private DevExpress.XtraGrid.Columns.GridColumn colMANCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.BindingSource bdsDonDatHang;
    }
}