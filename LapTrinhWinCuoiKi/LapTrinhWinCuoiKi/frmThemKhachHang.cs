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
    public partial class frmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        bool them;
        public frmThemKhachHang()
        {
            InitializeComponent();
        }
        BAKhachHang bakh = new BAKhachHang();
        BAThanhPho batp = new BAThanhPho();
        private BAThanhPho thanh_pho;
        /// <summary>
        /// Hàm tạo để thêm dữ liệu thành phớ gồm 2 biến tạo ban đầu là danh sách kh va ds tp theo kh
        /// 
        /// </summary>
        /// <param name="bakh"></param>
        /// <param name="batp"></param>
        public frmThemKhachHang(BAKhachHang bakh, BAThanhPho batp)
        {
            InitializeComponent();
            this.bakh = bakh;
            this.batp = batp;
            them = true;
            Text = "Tạo khách hàng mới";
            btnThem.Text = "Thêm KH";

            lookUpThanhPho.Properties.DataSource = batp.XemDanhMucThanhPho();
            lookUpThanhPho.Properties.DisplayMember = "TenTP";
            lookUpThanhPho.Properties.ValueMember = "MaTP";
            lookUpThanhPho.Properties.NullText = "Chọn thành phố";

           
        }
        public frmThemKhachHang(BAKhachHang bakh, BAThanhPho batp, DKhachHang dkh)
        {
            InitializeComponent();
            this.bakh = bakh;
            this.batp = batp;
            them = false;
            Text = "Cập nhật khách hàng";
            txtMaKH.Enabled = false;
            btnThem.Text = "Sua KH";

            txtMaKH.Text = dkh.MaKH;
            txtTenCty.Text = dkh.TenCty;
            txtDiaChi.Text = dkh.TenCty;
            txtDienThoai.Text = dkh.DienThoai;
            txtDiaChi.Text = dkh.DiaChi;

            lookUpThanhPho.DataBindings.Add("EditValue", dkh, "MaTP");
            lookUpThanhPho.Properties.DataSource = batp.XemDanhMucThanhPho();
            lookUpThanhPho.Properties.DisplayMember = "TenTP";
            lookUpThanhPho.Properties.ValueMember = "MaTP";
        }

        public frmThemKhachHang(BAThanhPho thanh_pho)
        {
            // TODO: Complete member initialization
            this.thanh_pho = thanh_pho;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (them)
            {
                if (txtMaKH.Text != "" && txtDiaChi.Text != "" && txtDienThoai.Text != "" && txtTenCty.Text != "")
                {
                    try
                    {
                        bakh.ThemKhachHang(txtMaKH.Text, txtTenCty.Text, txtDiaChi.Text, lookUpThanhPho.GetColumnValue("MaTP").ToString(), txtDienThoai.Text);
                        MessageBox.Show("Thêm khách hàng thành công!!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm khách hàng thất bại!!",
                        "Lỗi: " + ex.Message,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        txtMaKH.Focus();
                    }
                }
                else
                    MessageBox.Show("Chưa nhập đủ thông tin cần thêm", "Vui lòng nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                try
                {
                    bakh.CapNhatKhachHang(txtMaKH.Text, txtTenCty.Text, txtDiaChi.Text, lookUpThanhPho.GetColumnValue("MaTP").ToString(), txtDienThoai.Text);
                    MessageBox.Show("Cập nhật khách hàng thành công!!",
                        "Kết quả",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại!!",
                    "Lỗi: " + ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtMaKH.Focus();
                }
            }
        }

    }
}
