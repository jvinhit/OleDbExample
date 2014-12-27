/*
- Đồ án chương trình quản lý sinh viên. 
- Trường đại học Sư Phạm kĩ thuật thành phố Hồ Chí Minh
- Sinh Viên làm bài : 
 * Nguyễn Văn Vĩnh
 * Hoàng Tuấn Anh
    
 */
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
    public partial class Form1 : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Kiểm tra tồn tại form chưa

        Boolean kiemtratontai(string Frmname)
        {
            foreach (Form Frm in this.MdiChildren)
            {
                if (Frm.Name.Equals(Frmname))
                {
                    Frm.Activate();
                    return true;
                }
            }
            return false;
        }
        #endregion

        private void buttonItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Đóng chương trình? ", "OK- Đóng ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.Exit();
            }
            else
                e.Cancel = true;
	
      
        }
        
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Dangnhap();
            frm.Text = "Đăng Nhập Lại";
            frm.ShowDialog();
        }

        private void btnXemdanhsach_Click(object sender, EventArgs e)
        {
            Form frm = new frmDanhSachSinhVien();
            frm.Text = " Danh Sách Sinh Viên";
            frm.ShowDialog();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frm = new frmThem();
            frm.Text = "Thêm Sinh Viên";
            frm.ShowDialog();
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            Form frm = new frmSua();
            frm.Text = "Sửa thông tin Sinh Viên";
            frm.ShowDialog();
        }

        private void buttonItem1_Click_2(object sender, EventArgs e)
        {
            Form frm = new frmXoa();
            frm.Text = "Xóa Sinh Viên";
            frm.ShowDialog();
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            Form frm = new KetQuaHocTap();
            frm.Text = "Kết Quả Học Tập";
            frm.ShowDialog();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            Form frm = new DiemRenLuyen();
            frm.Text = "Điểm Rèn Luyện Cho Sinh Viên";
            frm.ShowDialog();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            Form frm = new frmBuocThoiHoc();
            frm.Text = "Danh Sách Sinh Viên Bị Buộc Thôi Học";
            frm.ShowDialog();
        }

        private void buttonItem3_Click_1(object sender, EventArgs e)
        {
            Form frm = new KhenThuong();
            frm.Text = "Thông tin Sinh Viên Khen Thưởng";
            frm.ShowDialog();
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
           /* Application.Restart();*/
            this.Hide();
            Form frm = new Dangnhap();
            frm.Text = "Đăng Nhập Lại Hệ Thống - Quản Lý";
            frm.ShowDialog();

        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lien He XXX", "Waring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnInThongTin_Click(object sender, EventArgs e)
        {
            Form frm = new frmDanhSachSinhVien();
            frm.Text = "Dùng Để IN ra";
            frm.ShowDialog();
            PrintDialog printDialog = new PrintDialog();
          

        }

        private void ribbonTabIn_Click(object sender, EventArgs e)
        {

        }

        
    }
}
