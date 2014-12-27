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
    public partial class frmThemThanhPho : DevExpress.XtraEditors.XtraForm
    {
        bool them;
        public frmThemThanhPho()
        {
            InitializeComponent();

        }
        BAThanhPho batp = new BAThanhPho();
        public frmThemThanhPho(BAThanhPho batp)
        {
            InitializeComponent();
            them= true;
            txtMaTP.Focus();
            Text = "Thêm Thành Phố";
            this.batp = batp;
        }
         public frmThemThanhPho(BAThanhPho batp, DThanhPho dtp)
        {
            InitializeComponent();
            them = false;
            Text = "Cập nhật thành phố";
            txtMaTP.Enabled = false;
            btnThem.Text = "CẬP NHẬT";

            txtMaTP.Text = dtp.MaTP;
            txtTenTP.Text = dtp.TenTP;
            this.batp= batp;
        }

         private void btnThem_Click(object sender, EventArgs e)
         {

             if (them)
             {
                 if (txtMaTP.Text != "" && txtTenTP.Text != "")
                 {
                     try
                     {
                         batp.ThemThanhPho(txtMaTP.Text, txtTenTP.Text);
                         MessageBox.Show("Thêm thành phố thành công!!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         this.Close();
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Thêm thành phố thất bại!!", "Lỗi: " + ex.Message, MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                         txtMaTP.Focus();
                     }
                 }
                 else
                     MessageBox.Show("Chưa nhập!", "Không Thể Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 try
                 {
                     batp.SuaThanhPho(txtMaTP.Text, txtTenTP.Text);
                     MessageBox.Show("Cập nhật Thành phố thành công!!",
                         "Kết quả",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                     this.Close();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Cập nhật Thành phố thất bại!!",
                     "Lỗi: " + ex.Message,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                     txtMaTP.Focus();
                 }
             }
         }

         private void btnHuy_Click(object sender, EventArgs e)
         {
             this.Hide();
         }



    }
}
