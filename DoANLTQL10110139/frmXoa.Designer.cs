namespace DoANLTQL10110139
{
    partial class frmXoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnReload = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.ThaoTac = new DevComponents.DotNetBar.ButtonX();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMakhoa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGioiTinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtHoDem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvSinhVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hodem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaSinhVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx2.Controls.Add(this.btnHuy);
            this.panelEx2.Controls.Add(this.btnReload);
            this.panelEx2.Controls.Add(this.btnThem);
            this.panelEx2.Controls.Add(this.btnSua);
            this.panelEx2.Controls.Add(this.btnXoa);
            this.panelEx2.Controls.Add(this.ThaoTac);
            this.panelEx2.Location = new System.Drawing.Point(0, 116);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(790, 45);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.Honeydew;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 5;
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnHuy.Image = global::DoANLTQL10110139.Properties.Resources.Cancel_32x32;
            this.btnHuy.Location = new System.Drawing.Point(589, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 38);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 4;
            // 
            // btnReload
            // 
            this.btnReload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReload.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnReload.Image = global::DoANLTQL10110139.Properties.Resources.Refresh_32x32;
            this.btnReload.Location = new System.Drawing.Point(680, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(85, 37);
            this.btnReload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReload.TabIndex = 3;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThem.Image = global::DoANLTQL10110139.Properties.Resources.Add_24x24;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 37);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSua.Image = global::DoANLTQL10110139.Properties.Resources.Edit_32x32;
            this.btnSua.Location = new System.Drawing.Point(275, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 37);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnXoa.Image = global::DoANLTQL10110139.Properties.Resources.Delete_32x32;
            this.btnXoa.Location = new System.Drawing.Point(184, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 37);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // ThaoTac
            // 
            this.ThaoTac.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ThaoTac.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.ThaoTac.Image = global::DoANLTQL10110139.Properties.Resources.Properties_32x32;
            this.ThaoTac.Location = new System.Drawing.Point(93, 3);
            this.ThaoTac.Name = "ThaoTac";
            this.ThaoTac.Size = new System.Drawing.Size(85, 37);
            this.ThaoTac.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ThaoTac.TabIndex = 0;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(315, 15);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(144, 20);
            this.dtpNgay.TabIndex = 2;
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTen.Location = new System.Drawing.Point(81, 73);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(136, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMakhoa
            // 
            // 
            // 
            // 
            this.txtMakhoa.Border.Class = "TextBoxBorder";
            this.txtMakhoa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMakhoa.Location = new System.Drawing.Point(562, 16);
            this.txtMakhoa.Name = "txtMakhoa";
            this.txtMakhoa.Size = new System.Drawing.Size(144, 20);
            this.txtMakhoa.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.Location = new System.Drawing.Point(315, 73);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(144, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtGioiTinh
            // 
            // 
            // 
            // 
            this.txtGioiTinh.Border.Class = "TextBoxBorder";
            this.txtGioiTinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGioiTinh.Location = new System.Drawing.Point(315, 44);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(144, 20);
            this.txtGioiTinh.TabIndex = 1;
            // 
            // txtHoDem
            // 
            // 
            // 
            // 
            this.txtHoDem.Border.Class = "TextBoxBorder";
            this.txtHoDem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoDem.Location = new System.Drawing.Point(81, 44);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(136, 20);
            this.txtHoDem.TabIndex = 1;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masv,
            this.Hodem,
            this.Ten,
            this.Ngaysinh,
            this.Gioitinh,
            this.Diachi,
            this.Makhoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSinhVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 162);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(790, 255);
            this.dgvSinhVien.TabIndex = 3;
            // 
            // Masv
            // 
            this.Masv.DataPropertyName = "Masv";
            this.Masv.HeaderText = "Mã SV";
            this.Masv.Name = "Masv";
            // 
            // Hodem
            // 
            this.Hodem.DataPropertyName = "Hodem";
            this.Hodem.HeaderText = "Họ Đệm";
            this.Hodem.Name = "Hodem";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày Sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới Tính";
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa Chỉ";
            this.Diachi.Name = "Diachi";
            // 
            // Makhoa
            // 
            this.Makhoa.DataPropertyName = "Makhoa";
            this.Makhoa.HeaderText = "Mã Khoa";
            this.Makhoa.Name = "Makhoa";
            // 
            // txtMaSinhVien
            // 
            // 
            // 
            // 
            this.txtMaSinhVien.Border.Class = "TextBoxBorder";
            this.txtMaSinhVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaSinhVien.Location = new System.Drawing.Point(81, 15);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(136, 20);
            this.txtMaSinhVien.TabIndex = 1;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(494, 15);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(62, 20);
            this.labelX8.TabIndex = 0;
            this.labelX8.Text = "Mã khoa :";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(250, 70);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Địa chỉ :";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(250, 41);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Giới Tính :";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(250, 12);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Ngày Sinh: ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 70);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Tên:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Họ Đệm:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã SV:";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dtpNgay);
            this.panelEx1.Controls.Add(this.txtTen);
            this.panelEx1.Controls.Add(this.txtMakhoa);
            this.panelEx1.Controls.Add(this.txtDiaChi);
            this.panelEx1.Controls.Add(this.txtGioiTinh);
            this.panelEx1.Controls.Add(this.txtHoDem);
            this.panelEx1.Controls.Add(this.txtMaSinhVien);
            this.panelEx1.Controls.Add(this.labelX8);
            this.panelEx1.Controls.Add(this.labelX6);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(790, 114);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.Honeydew;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // frmXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 417);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "frmXoa";
            this.Text = "frmXoa";
            this.Load += new System.EventHandler(this.frmXoa_Load);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnReload;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX ThaoTac;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMakhoa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGioiTinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoDem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hodem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhoa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaSinhVien;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
    }
}