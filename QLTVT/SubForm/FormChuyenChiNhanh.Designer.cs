
namespace QLTVT.SubForm
{
    partial class FormChuyenChiNhanh
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
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.btnXACNHAN = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMANVCU = new System.Windows.Forms.TextBox();
            this.txtMANVMOI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(204, 107);
            this.cmbCHINHANH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(163, 21);
            this.cmbCHINHANH.TabIndex = 4;
            // 
            // btnXACNHAN
            // 
            this.btnXACNHAN.BackColor = System.Drawing.Color.Blue;
            this.btnXACNHAN.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnXACNHAN.ForeColor = System.Drawing.Color.White;
            this.btnXACNHAN.Location = new System.Drawing.Point(91, 154);
            this.btnXACNHAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXACNHAN.Name = "btnXACNHAN";
            this.btnXACNHAN.Size = new System.Drawing.Size(117, 28);
            this.btnXACNHAN.TabIndex = 5;
            this.btnXACNHAN.Text = "XÁC NHẬN";
            this.btnXACNHAN.UseVisualStyleBackColor = false;
            this.btnXACNHAN.Click += new System.EventHandler(this.btnXACNHAN_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.BackColor = System.Drawing.Color.Red;
            this.btnTHOAT.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnTHOAT.ForeColor = System.Drawing.Color.White;
            this.btnTHOAT.Location = new System.Drawing.Point(226, 154);
            this.btnTHOAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(117, 28);
            this.btnTHOAT.TabIndex = 6;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã nhân viên cũ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã nhân viên mới:";
            // 
            // txtMANVCU
            // 
            this.txtMANVCU.Enabled = false;
            this.txtMANVCU.Location = new System.Drawing.Point(204, 28);
            this.txtMANVCU.Name = "txtMANVCU";
            this.txtMANVCU.Size = new System.Drawing.Size(163, 21);
            this.txtMANVCU.TabIndex = 9;
            // 
            // txtMANVMOI
            // 
            this.txtMANVMOI.Location = new System.Drawing.Point(204, 69);
            this.txtMANVMOI.Name = "txtMANVMOI";
            this.txtMANVMOI.Size = new System.Drawing.Size(163, 21);
            this.txtMANVMOI.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chi nhánh mới:";
            // 
            // FormChuyenChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMANVMOI);
            this.Controls.Add(this.txtMANVCU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnXACNHAN);
            this.Controls.Add(this.cmbCHINHANH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChuyenChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển Chi Nhánh";
            this.Load += new System.EventHandler(this.FormChuyenChiNhanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.Button btnXACNHAN;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMANVCU;
        private System.Windows.Forms.TextBox txtMANVMOI;
        private System.Windows.Forms.Label label3;
    }
}