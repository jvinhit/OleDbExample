namespace LapTrinhWinCuoiKi
{
    partial class frmThemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemHoaDon));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaHoaDon = new DevExpress.XtraEditors.TextEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditMaKH = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditMaNV = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNgayLapHD = new DevExpress.XtraEditors.DateEdit();
            this.txtNgayNhanHang = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHoaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHD.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNhanHang.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNhanHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Hóa Đơn: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(12, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã Khách Hàng : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl3.Location = new System.Drawing.Point(12, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mã Nhân Viên :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl4.Location = new System.Drawing.Point(12, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(104, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ngày Lập HĐ :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl5.Location = new System.Drawing.Point(12, 168);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(131, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Ngày Nhận Hàng :";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(149, 14);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(167, 20);
            this.txtMaHoaDon.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(149, 209);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(241, 209);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lookUpEditMaKH
            // 
            this.lookUpEditMaKH.Location = new System.Drawing.Point(149, 53);
            this.lookUpEditMaKH.Name = "lookUpEditMaKH";
            this.lookUpEditMaKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMaKH.Size = new System.Drawing.Size(167, 20);
            this.lookUpEditMaKH.TabIndex = 3;
            // 
            // lookUpEditMaNV
            // 
            this.lookUpEditMaNV.Location = new System.Drawing.Point(149, 92);
            this.lookUpEditMaNV.Name = "lookUpEditMaNV";
            this.lookUpEditMaNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMaNV.Size = new System.Drawing.Size(167, 20);
            this.lookUpEditMaNV.TabIndex = 3;
            // 
            // txtNgayLapHD
            // 
            this.txtNgayLapHD.EditValue = null;
            this.txtNgayLapHD.Location = new System.Drawing.Point(149, 131);
            this.txtNgayLapHD.Name = "txtNgayLapHD";
            this.txtNgayLapHD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLapHD.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtNgayLapHD.Size = new System.Drawing.Size(165, 20);
            this.txtNgayLapHD.TabIndex = 4;
            // 
            // txtNgayNhanHang
            // 
            this.txtNgayNhanHang.EditValue = null;
            this.txtNgayNhanHang.Location = new System.Drawing.Point(149, 170);
            this.txtNgayNhanHang.Name = "txtNgayNhanHang";
            this.txtNgayNhanHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayNhanHang.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtNgayNhanHang.Size = new System.Drawing.Size(167, 20);
            this.txtNgayNhanHang.TabIndex = 5;
            // 
            // frmThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 241);
            this.Controls.Add(this.txtNgayNhanHang);
            this.Controls.Add(this.txtNgayLapHD);
            this.Controls.Add(this.lookUpEditMaNV);
            this.Controls.Add(this.lookUpEditMaKH);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHoaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHD.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNhanHang.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNhanHang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMaHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMaKH;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMaNV;
        private DevExpress.XtraEditors.DateEdit txtNgayLapHD;
        private DevExpress.XtraEditors.DateEdit txtNgayNhanHang;
    }
}