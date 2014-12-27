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
using System.Threading;

namespace LapTrinhWinCuoiKi
{
    public partial class frmDangNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
           
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text == "admin") && (this.txtpass.Text == "admin"))
            {
                this.Hide();
                Form frm = new Form1();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng/pass", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                this.txtUser.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form1();
            frm.ShowDialog();
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUser.Text == "admin" && txtpass.Text == "admin")
                {
                    this.Hide();
                    Form frm = new Form1();
                    frm.ShowDialog();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            LookAndFeel.SetSkinStyle("Office 2007 Pink");
            Thread.Sleep(4000);
        }
    }
}
