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
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }
        bool them;
        BANhanVien banv = new BANhanVien();
        public frmThemNhanVien(BANhanVien banv)
        {
            InitializeComponent();
            them = true;
            Text = "Thêm Nhân Viên";
            btnThemNhanVien.Text = "Thêm";
            this.banv = banv;
        }
        public frmThemNhanVien(BANhanVien banv, DNhanVien dnv)
        {
            InitializeComponent();
            this.banv = banv;
            them = false;
            Text = "Cập nhật nhân viên";
            txtMaNV.Enabled = false;
            btnThemNhanVien.Text = "CẬP NHẬT";

            txtMaNV.Text = dnv.MaNV;
            txtHo.Text = dnv.Ho;
            txtTen.Text = dnv.Ten;
            if (dnv.Nu == true)
            {
                cbNu.Checked = true;
            }
            txtDiaChi.Text = dnv.DiaChi;
            txtNgayNhanViec.Text = dnv.NgayNV.ToString();
            txtDienThoai.Text = dnv.DienThoai;
            picNhanVien.Image = dnv.Hinh;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (them)
            {
                if (txtMaNV.Text != "" && txtHo.Text != "" && txtTen.Text != "" && txtDiaChi.Text != "" && txtDienThoai.Text != "")
                {
                    try
                    {
                        bool cNu = true;
                        if (cbNu.Checked == true)
                        {
                            cNu = true;
                        }
                        else if (cbNu.Checked == false)
                        {
                            cNu = false;
                        }
                        DateTime ngaynhapviec = Convert.ToDateTime(txtNgayNhanViec.Text);
                        banv.ThemNhanVien(txtMaNV.Text, txtHo.Text, txtTen.Text, cNu, ngaynhapviec, txtDiaChi.Text, txtDienThoai.Text, picNhanVien.Image);
                        MessageBox.Show("Thêm Nhân Viên Thành Công!", "Bla bla ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Thêm Nhân Viên Thất Bại! ", "Check Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Chưa điền đủ thông tin cần thêm", "Xem lại dữ liệu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bool cNu = true;
                    if (cbNu.Checked == true)
                    {
                        cNu = true;

                    }
                    else if (cbNu.Checked == false)
                    {
                        cNu = false;
                    }
                    DateTime ngaynhapviec = Convert.ToDateTime(txtNgayNhanViec.Text);
                    banv.CapNhatNhanVien(txtMaNV.Text, txtHo.Text, txtTen.Text, cNu, ngaynhapviec, txtDiaChi.Text, txtDienThoai.Text, picNhanVien.Image);
                    MessageBox.Show("Cập nhật thành công!!",
                        "Kết quả",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Cập Nhật Nhân Viên Thất Bại! ", "Check Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
