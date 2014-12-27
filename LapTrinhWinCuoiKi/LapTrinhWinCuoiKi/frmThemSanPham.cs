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
    public partial class frmThemSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmThemSanPham()
        {
            InitializeComponent();
        }
        bool them;
        BASanPham basp = new BASanPham();
        DSanPham dasp= new DSanPham();
        public frmThemSanPham(BASanPham basp)
        {
            InitializeComponent();
            them = true;
            btnThem.Text = "Thêm";
            this.basp = basp;
        }
        public frmThemSanPham(BASanPham basp, DSanPham dasp)
        {
            InitializeComponent();
            this.basp = basp;
            them = false;
            Text = "Cập nhật sản phẩm";
            txtMaSP.Enabled = false;
            btnThem.Text = "Cập Nhật";

            txtMaSP.Text = dasp.MaSP;
            txtTenSP.Text = dasp.TenSP;
            txtDonViTinh.Text = dasp.DonViTinh;
            txtMaLoaiSP.Text = dasp.MaLoaiSP;
            txtDonGia.Text = dasp.DonGia.ToString();
            picHinh.Image = dasp.Hinh;
            picHinh2.Image = dasp.Hinh2;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                if (txtMaSP.Text != "" && txtTenSP.Text != "" && txtDonGia.Text != "" && txtDonViTinh.Text != "")
                {
                    try
                    {
                        double dongia = Convert.ToDouble(txtDonGia.Text);
                        basp.ThemSanPham(txtMaSP.Text, txtTenSP.Text, txtDonViTinh.Text, dongia, txtMaLoaiSP.Text, picHinh.Image, picHinh2.Image);
                        MessageBox.Show("Thêm Sản Phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Thêm không thành công", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin cần thêm");
            }
            else
            {
                try
                {
                    double dongia = Convert.ToDouble(txtDonGia.Text);
                    basp.CapNhatSanPham(txtMaSP.Text, txtTenSP.Text, txtDonViTinh.Text, dongia, txtMaLoaiSP.Text, picHinh.Image, picHinh2.Image);
                    MessageBox.Show("Thêm Sản Phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Thêm không thành công", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

    }
}
