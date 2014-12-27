using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoANLTQL10110139
{
    public partial class Dangnhap : DevComponents.DotNetBar.Office2007Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtuser.Text== "admin" && txtpass.Text=="admin")
                {
                    this.Hide();
                    Form frm = new Form1();
                    frm.ShowDialog();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((this.txtuser.Text == "admin") && (this.txtpass.Text == "admin"))
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng/pass", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                this.txtuser.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
