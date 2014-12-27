namespace DoANLTQL10110139
{
    partial class KetQuaHocTap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMasv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTimKiemMSSV = new DevComponents.DotNetBar.ButtonX();
            this.dgvKetQua = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMasv
            // 
            // 
            // 
            // 
            this.txtMasv.Border.Class = "TextBoxBorder";
            this.txtMasv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMasv.Location = new System.Drawing.Point(94, 10);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(143, 20);
            this.txtMasv.TabIndex = 0;
            // 
            // btnTimKiemMSSV
            // 
            this.btnTimKiemMSSV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiemMSSV.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnTimKiemMSSV.Location = new System.Drawing.Point(255, 7);
            this.btnTimKiemMSSV.Name = "btnTimKiemMSSV";
            this.btnTimKiemMSSV.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemMSSV.TabIndex = 1;
            this.btnTimKiemMSSV.Text = "Tìm Kiếm";
            this.btnTimKiemMSSV.Click += new System.EventHandler(this.btnTimKiemMSSV_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masv,
            this.Mamon,
            this.Tenmon,
            this.Diem});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetQua.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKetQua.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvKetQua.Location = new System.Drawing.Point(0, 76);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(442, 209);
            this.dgvKetQua.TabIndex = 2;
            // 
            // Masv
            // 
            this.Masv.DataPropertyName = "Masv";
            this.Masv.HeaderText = "Mã Sinh Viên";
            this.Masv.Name = "Masv";
            // 
            // Mamon
            // 
            this.Mamon.DataPropertyName = "Mamon";
            this.Mamon.HeaderText = "Mã Môn Học";
            this.Mamon.Name = "Mamon";
            // 
            // Tenmon
            // 
            this.Tenmon.DataPropertyName = "Tenmon";
            this.Tenmon.HeaderText = "Tên Môn Học";
            this.Tenmon.Name = "Tenmon";
            // 
            // Diem
            // 
            this.Diem.DataPropertyName = "Diem";
            this.Diem.HeaderText = "Điểm";
            this.Diem.Name = "Diem";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(50, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(38, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "MSSV:";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.buttonX1);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.btnTimKiemMSSV);
            this.panelEx1.Controls.Add(this.txtMasv);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(442, 79);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleName = "btnXem";
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX1.Location = new System.Drawing.Point(255, 36);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "Xem";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(50, 36);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(136, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Xem cho tất cả Sinh Viên";
            // 
            // KetQuaHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 285);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.dgvKetQua);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KetQuaHocTap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KetQuaHocTap";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtMasv;
        private DevComponents.DotNetBar.ButtonX btnTimKiemMSSV;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}