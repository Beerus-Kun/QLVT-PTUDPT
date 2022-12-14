
namespace QLTVT.SubForm
{
    partial class FormChonChiTietDonHang
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
            this.cTDDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsChiTietDonHang = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new QLTVT.QLVTDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLDAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMADD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCHON = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.tableAdapterManager = new QLTVT.QLVTDataSetTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLTVT.QLVTDataSetTableAdapters.view_ChonChiTietDonDatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cTDDHGridControl
            // 
            this.cTDDHGridControl.DataSource = this.bdsChiTietDonHang;
            this.cTDDHGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cTDDHGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.cTDDHGridControl.Location = new System.Drawing.Point(0, 0);
            this.cTDDHGridControl.MainView = this.gridView1;
            this.cTDDHGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(584, 214);
            this.cTDDHGridControl.TabIndex = 1;
            this.cTDDHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsChiTietDonHang
            // 
            this.bdsChiTietDonHang.DataMember = "view_ChonChiTietDonDat";
            this.bdsChiTietDonHang.DataSource = this.qLVTDataSet;
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH,
            this.colTEN,
            this.colSLDAT,
            this.colSLNHAP,
            this.colMADD});
            this.gridView1.DetailHeight = 284;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.GridControl = this.cTDDHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHH
            // 
            this.colMAHH.Caption = "Mã hàng hóa";
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 0;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên hàng hóa";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colSLDAT
            // 
            this.colSLDAT.Caption = "Số lượng đặt";
            this.colSLDAT.FieldName = "SLDAT";
            this.colSLDAT.Name = "colSLDAT";
            this.colSLDAT.Visible = true;
            this.colSLDAT.VisibleIndex = 3;
            // 
            // colSLNHAP
            // 
            this.colSLNHAP.Caption = "Số lượng đã nhập";
            this.colSLNHAP.FieldName = "SLNHAP";
            this.colSLNHAP.Name = "colSLNHAP";
            this.colSLNHAP.Visible = true;
            this.colSLNHAP.VisibleIndex = 4;
            // 
            // colMADD
            // 
            this.colMADD.Caption = "Mã đơn đặt";
            this.colMADD.FieldName = "MADD";
            this.colMADD.Name = "colMADD";
            this.colMADD.Visible = true;
            this.colMADD.VisibleIndex = 1;
            // 
            // btnCHON
            // 
            this.btnCHON.BackColor = System.Drawing.Color.Blue;
            this.btnCHON.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCHON.ForeColor = System.Drawing.Color.White;
            this.btnCHON.Location = new System.Drawing.Point(80, 268);
            this.btnCHON.Margin = new System.Windows.Forms.Padding(2);
            this.btnCHON.Name = "btnCHON";
            this.btnCHON.Size = new System.Drawing.Size(138, 35);
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
            this.btnTHOAT.Location = new System.Drawing.Point(335, 268);
            this.btnTHOAT.Margin = new System.Windows.Forms.Padding(2);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(138, 35);
            this.btnTHOAT.TabIndex = 3;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
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
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // FormChonChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 342);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnCHON);
            this.Controls.Add(this.cTDDHGridControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormChonChiTietDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Đơn Đặt Hàng";
            this.Load += new System.EventHandler(this.FormChonChiTietDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl cTDDHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnCHON;
        private System.Windows.Forms.Button btnTHOAT;
        private QLVTDataSet qLVTDataSet;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsChiTietDonHang;
        private QLVTDataSetTableAdapters.view_ChonChiTietDonDatTableAdapter cTDDHTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMADD;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSLDAT;
        private DevExpress.XtraGrid.Columns.GridColumn colSLNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
    }
}