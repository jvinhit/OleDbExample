using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using BussinessLayer;
using DevExpress.XtraEditors;
namespace LapTrinhWinCuoiKi
{
    public partial class frmThemHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmThemHoaDon()
        {
            InitializeComponent();
        }
        bool them;
       
        BAHoaDon bahd = new BAHoaDon();
        BANhanVien banv = new BANhanVien();
        BAKhachHang bakh = new BAKhachHang();
        public frmThemHoaDon(BAHoaDon bahd, BAKhachHang bakh, BANhanVien banv)
        {
            InitializeComponent();
            them = true;
            Text = "Tạo hóa đơn mới";
            btnThem.Text = "Thêm";

            lookUpEditMaNV.Properties.DataSource = banv.XemDanhMucNhanVien();
            lookUpEditMaNV.Properties.DisplayMember = "Ten";
            lookUpEditMaNV.Properties.ValueMember = "MaNV";
            lookUpEditMaNV.Properties.NullText = "Chọn nhân viên";

            lookUpEditMaKH.Properties.DataSource = bakh.XemDanhMucKhachHang();
            lookUpEditMaKH.Properties.DisplayMember = "TenCty";
            lookUpEditMaKH.Properties.ValueMember = "MaKH";
            lookUpEditMaKH.Properties.NullText = "Chọn khách hàng";

            this.bahd = bahd;
            this.bakh = bakh;
            this.banv = banv;
        }
        public frmThemHoaDon(BAHoaDon bahd, BAKhachHang bakh, BANhanVien banv, DHoaDon dhd)
        {
            InitializeComponent();
            this.bahd = bahd;
            this.banv = banv;
            this.bakh = bakh;

            them = false;
            Text = "Cập nhật hóa đơn";
            txtMaHoaDon.Enabled = false;
            btnThem.Text = "Cập Nhật";

            txtMaHoaDon.Text = dhd.MaHD.ToString();
            txtNgayLapHD.Text = dhd.NgayLapHD.ToString();
            txtNgayNhanHang.Text = dhd.NgayNhanHang.ToString();


            lookUpEditMaKH.DataBindings.Add("EditValue", dhd, "MaKH");
            lookUpEditMaKH.Properties.DataSource = bakh.XemDanhMucKhachHang();
            lookUpEditMaKH.Properties.DisplayMember = "TenCty";
            lookUpEditMaKH.Properties.ValueMember = "MaKH";

            lookUpEditMaNV.DataBindings.Add("EditValue", dhd, "MaNV");
            lookUpEditMaNV.Properties.DataSource = banv.XemDanhMucNhanVien();
            lookUpEditMaNV.Properties.DisplayMember = "Ten";
            lookUpEditMaNV.Properties.ValueMember = "MaNV";


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    DateTime ngaylaphd = Convert.ToDateTime(txtNgayLapHD.Text);
                    DateTime ngaynhanhang = Convert.ToDateTime(txtNgayNhanHang.Text);
                    bahd.ThemHoaDon(txtMaHoaDon.Text, lookUpEditMaKH.GetColumnValue("MaKH").ToString(), lookUpEditMaNV.GetColumnValue("MaNV").ToString(), ngaylaphd, ngaynhanhang);
                    MessageBox.Show("Thêm thành công!!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại!!", "Lỗi: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaHoaDon.Focus();
                }

            }
            else
            {
                    try
                    {
                        DateTime ngaylaphd = Convert.ToDateTime(txtNgayLapHD.Text);
                        DateTime ngaynhanhang = Convert.ToDateTime(txtNgayNhanHang.Text);
                        bahd.CapNhatHoaDon(txtMaHoaDon.Text, lookUpEditMaKH.GetColumnValue("MaKH").ToString(), lookUpEditMaNV.GetColumnValue("MaNV").ToString(), ngaylaphd, ngaynhanhang);
                        MessageBox.Show("Thêm thành công!!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại!!", "Lỗi: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaHoaDon.Focus();
                    }
                }
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

