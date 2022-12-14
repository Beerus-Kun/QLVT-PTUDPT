
namespace QLTVT.SubForm
{
    partial class FormChonVatTu
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
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new QLTVT.QLVTDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vattuTableAdapter = new QLTVT.QLVTDataSetTableAdapters.HANGHOATableAdapter();
            this.tableAdapterManager = new QLTVT.QLVTDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.bdsVatTu;
            this.vattuGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.vattuGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.vattuGridControl.Location = new System.Drawing.Point(0, 0);
            this.vattuGridControl.MainView = this.gridView1;
            this.vattuGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(593, 200);
            this.vattuGridControl.TabIndex = 1;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH,
            this.colTEN,
            this.colMALHH,
            this.colDONVI,
            this.colDONGIA});
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.vattuGridControl;
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
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(109, 219);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "CHỌN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(343, 219);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CTDDTableAdapter = null;
            this.tableAdapterManager.CTHDTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.DONDATTableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = this.vattuTableAdapter;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormChonVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 280);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vattuGridControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormChonVatTu";
            this.Text = "Chọn Vật Tư";
            this.Load += new System.EventHandler(this.FormChonVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private QLVTDataSetTableAdapters.HANGHOATableAdapter vattuTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMALHH;
        private DevExpress.XtraGrid.Columns.GridColumn colDONVI;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
    }
}