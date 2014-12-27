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
    public partial class frmThemChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmThemChiTietHoaDon()
        {
            InitializeComponent();
        }
        bool them;
        
        BASanPham basp = new BASanPham();
        BAHoaDon bahd = new BAHoaDon();
        BAChiTietHoaDon bacthd = new BAChiTietHoaDon();
        public frmThemChiTietHoaDon(BAChiTietHoaDon bacthd, BAHoaDon bahd, BASanPham basp)
        {
            InitializeComponent();
            them = true;
            Text = "Tạo hóa đơn mới";
            btnThem.Text = "Thêm";
            lookUpEditMaHD.Properties.DataSource = bahd.XemDanhMucHoaDon();
            lookUpEditMaHD.Properties.NullText = "Chọn Mã hóa đơn";
            lookUpEditMaHD.Properties.DisplayMember = "MaHD";
            lookUpEditMaHD.Properties.ValueMember = "MaHD";

            lookUpEditMaSP.Properties.DataSource = basp.XemDanhMucSanPham();
            lookUpEditMaSP.Properties.NullText = "Chọn Mã sản phẩm";
            lookUpEditMaSP.Properties.DisplayMember = "MaSP";
            lookUpEditMaSP.Properties.ValueMember = "MaSP";


            this.bacthd = bacthd;
            this.basp=basp;
            this.bahd=bahd;
        }
        public frmThemChiTietHoaDon(BAChiTietHoaDon bacthd, BAHoaDon bahd, BASanPham basp, DChiTietHoaDon dcthd)
        {
            InitializeComponent();
            them = false;
            Text = "Cập nhật chi tiết hóa đơn";
            lookUpEditMaHD.DataBindings.Add("EditValue", dcthd, "MaHD");
            lookUpEditMaHD.Properties.DataSource = bahd.XemDanhMucHoaDon();
            lookUpEditMaHD.Properties.DisplayMember = "MaHD";
            lookUpEditMaHD.Properties.ValueMember = "MaKH";

            lookUpEditMaSP.DataBindings.Add("EditValue", dcthd, "MaSP");
            lookUpEditMaSP.Properties.DataSource = basp.XemDanhMucSanPham();
            lookUpEditMaSP.Properties.DisplayMember = "TenSP";
            lookUpEditMaSP.Properties.ValueMember = "MaSP";
            this.bacthd = bacthd;
            this.basp = basp;
            this.bahd = bahd;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int soluong = int.Parse(txtSoLuong.Text);
            if (them == true)
            {
                if (lookUpEditMaHD.Text!= ""  && lookUpEditMaSP.Text!="" && txtSoLuong.Text !="")
                {
                    try
                    {
                        bacthd.ThemChiTietHoaDon(lookUpEditMaHD.Text, lookUpEditMaSP.Text, soluong);
                        MessageBox.Show("Thêm Chi tiết hóa đơn thành công!!",
                        "Kết quả",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại!!", "Lỗi: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                    MessageBox.Show("Chưa nhập đủ dữ liệu cần thêm", "Thông Báo", MessageBoxButtons.OK,  MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    bacthd.CapNhatChiTietHoaDon(lookUpEditMaHD.Text, lookUpEditMaSP.Text, soluong);
                    MessageBox.Show("Thêm Chi tiết hóa đơn thành công!!",
                    "Kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Cập Nhật thất bại!!", "Lỗi: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
