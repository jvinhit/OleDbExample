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
using DataAccessLayer;
using BussinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;


using DevExpress.XtraBars.Ribbon;


namespace LapTrinhWinCuoiKi
{
    public partial class Form1 : RibbonForm/*DevExpress.XtraEditors.XtraForm*/
    {
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
            LoadCSDL load = new LoadCSDL();
            load.InitialData();
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbSkins, true);
        }
        #region FormLoad Skin and CSDL
        private void Form1_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            Nhinvacamnhan.LookAndFeel.SetSkinStyle("Office 2007 Pink");
        }
        #endregion
        
        #region btnThoat
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
#endregion
        
        BAThanhPho thanh_pho = new BAThanhPho();
        DThanhPho tp { get; set; }
        BAKhachHang khach_hang = new BAKhachHang();
        DKhachHang kh { get; set; }
        BANhanVien nhan_vien = new BANhanVien();
        DNhanVien nv { get; set; }
        BASanPham san_pham = new BASanPham();
        DSanPham sp { get; set; }
        BAHoaDon hoa_don = new BAHoaDon();
        DHoaDon hd { get; set; }
        BAChiTietHoaDon chi_tiet_hoa_don = new BAChiTietHoaDon();
        DChiTietHoaDon cthd { get; set; }


        public void LoadCSDLThanhPho()
        {

            grControl.DataSource = thanh_pho.XemDanhMucThanhPho();
            View.PopulateColumns();
            View.RefreshData();
            grControl.RefreshDataSource();

        }
        public void LoadCSDLKhachHang()
        {

            grControl.DataSource = khach_hang.XemDanhMucKhachHang();
            View.PopulateColumns();
            View.RefreshData();
            grControl.RefreshDataSource();
        }
        public void LoadCSDLNhanVien()
        {

            grControl.DataSource = nhan_vien.XemDanhMucNhanVien();
            View.PopulateColumns();
            View.Columns["Hinh"].ColumnEdit = new RepositoryItemPictureEdit()
            {
                SizeMode = PictureSizeMode.Squeeze
            };
        }
        public void LoadCSDLSanPham()
        {
            grControl.DataSource = san_pham.XemDanhMucSanPham();
            View.PopulateColumns();
            View.Columns["Hinh"].ColumnEdit = new RepositoryItemPictureEdit()
            {
                SizeMode = PictureSizeMode.Squeeze
            };
            View.Columns["Hinh2"].ColumnEdit = new RepositoryItemPictureEdit()
            {
                SizeMode = PictureSizeMode.Squeeze
            };       
        }
        public void LoadCSDLChiTietHoaDon()
        {
            
            grControl.DataSource = chi_tiet_hoa_don.XemDanhMucChiTietHoaDon();
            View.PopulateColumns();
        }
        void ColumnEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            RepositoryItemLookUpEdit props;
            if (sender is LookUpEdit)
                props = (sender as LookUpEdit).Properties;
            else
                props = sender as RepositoryItemLookUpEdit;

            if (props != null && (e.Value != null))
            {
                props.ForceInitialize();
                DNhanVien nvien = props.GetDataSourceRowByKeyValue(e.Value) as DNhanVien;
                e.DisplayText = String.Format("{0} {1}", nvien.Ho, nvien.Ten);
            }
        }
        public void LoadCSDLHoaDon()
        {
            grControl.DataSource = hoa_don.XemDanhMucHoaDon();
            View.PopulateColumns();
            View.Columns["MaKH"].ColumnEdit = new RepositoryItemLookUpEdit()
            {
                DataSource = khach_hang.XemDanhMucKhachHang(),
                DisplayMember = "TenCty",
                ValueMember = "MaKH"
            };
            View.Columns["MaNV"].ColumnEdit = new RepositoryItemLookUpEdit()
            {
                DataSource = nhan_vien.XemDanhMucNhanVien(),
                DisplayMember = "Ten",
                ValueMember = "MaNV"
            };

            View.Columns["MaNV"].ColumnEdit.CustomDisplayText += ColumnEdit_CustomDisplayText;

            View.Columns["MaNV"].Caption = "Họ và tên NV";
            View.Columns["MaKH"].Caption = "Tên Công ty";
            View.Columns["NgayLapHD"].Caption = "Ngày lập hóa đơn";
            View.Columns["NgayNhanHang"].Caption = "Ngày nhận hàng";
            grControl.DataSource = hoa_don.XemDanhMucHoaDon();
            View.PopulateColumns();
        }
        private void btnDanhMucThanhPho_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadCSDLThanhPho();
        }
        private void btnDanhMucKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadCSDLKhachHang();
        }
        private void btnXemDanhMucNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadCSDLNhanVien();
        }
        private void btnXemDanhMucSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadCSDLSanPham();
        }
        #region Xủ lý thành phố
        private void btnThemThanhPho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new frmThemThanhPho(thanh_pho);
            frm.ShowDialog();
            LoadCSDLThanhPho();
        }

        private void btnCapNhatThanhPho_ItemClick(object sender, ItemClickEventArgs e)
        {
            tp = (DThanhPho)View.Columns[0].View.GetFocusedRow();
            frmThemThanhPho frm = new frmThemThanhPho(thanh_pho, tp);
            frm.ShowDialog();
            LoadCSDLThanhPho();

        }

        private void btnXoaThanhPho_ItemClick(object sender, ItemClickEventArgs e)
        {
            tp = (DThanhPho)View.Columns[0].View.GetFocusedRow();
            DialogResult tl = MessageBox.Show("Bạn có muốn xóa thành phố \"" + tp.TenTP + "\" không?",
                    "Xóa Thành Phố", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {

                    thanh_pho.XoaThanhPho(tp.MaTP);
                    MessageBox.Show("Xóa Thành phố thành công!!",
                       "Kết quả",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    LoadCSDLThanhPho();
                }
                catch
                {
                    MessageBox.Show("Xóa thành phố thất bại !!",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }
        #endregion       
        #region Xử Lý Khách Hàng
        private void btnThemKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new frmThemKhachHang(khach_hang, thanh_pho);
            frm.Text = "Thêm Khách Hàng";
            frm.ShowDialog();
            LoadCSDLKhachHang();
        }
        private void btnXoaKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            kh = (DKhachHang)View.Columns[0].View.GetFocusedRow();
            DialogResult thongbaokq = MessageBox.Show("Bạn có muốn xóa khách hàng \"" + kh.MaKH + "\" không?",
                    "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbaokq == DialogResult.Yes)
            {
                try
                {

                    khach_hang.XoaKhachHang(kh.MaKH);
                    MessageBox.Show("Xóa thành công!!",
                       "Kết quả",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    LoadCSDLKhachHang();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại !!",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }
        private void btnCapNhatKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            kh = (DKhachHang)View.Columns[0].View.GetFocusedRow();
            frmThemKhachHang frm = new frmThemKhachHang(khach_hang, thanh_pho, kh);
            frm.ShowDialog();
            LoadCSDLThanhPho();
        }
#endregion
        #region btnThoát
        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Đăng nhập
        private void btnItemDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            Form frm = new frmDangNhap();
            frm.Text = "Đăng nhập lại hệ thống";
            frm.ShowDialog();
        }
        #endregion
        #region ConnectoDatabse
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new frmConnectDatabase();
            frm.Text = "Connect to Database Server!";
            frm.ShowDialog();

        }
        #endregion

        private void btnThemNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new frmThemNhanVien(nhan_vien);
            frm.ShowDialog();
            LoadCSDLNhanVien();

        }

        private void btnXoaNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            nv = (DNhanVien)View.Columns[0].View.GetFocusedRow();
            DialogResult thongbaokq = MessageBox.Show("Xóa Nhân Viên\"" + nv.MaNV+ "\" không?","OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbaokq == DialogResult.Yes)
            {
                try
                {

                    nhan_vien.XoaNhanVien(nv.MaNV);
                    MessageBox.Show("Xóa thành công!!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadCSDLNhanVien();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại !!","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCapNhatNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            nv = (DNhanVien)View.Columns[0].View.GetFocusedRow();
            frmThemNhanVien frm = new frmThemNhanVien(nhan_vien, nv);
            frm.ShowDialog();
            LoadCSDLNhanVien();
        }

        private void btnThemSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new frmThemSanPham(san_pham);
            frm.ShowDialog();
            LoadCSDLSanPham();
        }

        private void btnXoaSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            sp = (DSanPham)View.Columns[0].View.GetFocusedRow();
            DialogResult thongbaokq = MessageBox.Show("Xóa Sản Phẩm\"" + sp.MaSP + "\"không?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbaokq == DialogResult.Yes)
            {
                try
                {
                    san_pham.XoaSanPham(sp.MaSP);
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCSDLSanPham();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCapNhatSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            sp = (DSanPham)View.Columns[0].View.GetFocusedRow();
            frmThemSanPham frm = new frmThemSanPham(san_pham, sp);
            frm.ShowDialog();
            LoadCSDLSanPham();
        }

        private void btnDanhMucHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadCSDLHoaDon();
        }

        private void btnThemHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new frmThemHoaDon(hoa_don,khach_hang,nhan_vien);
            frm.ShowDialog();
            LoadCSDLHoaDon();
        }

        private void btnXoaHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            hd = (DHoaDon)View.Columns[0].View.GetFocusedRow();
            DialogResult tl = MessageBox.Show("Bạn có muốn xóa sản phẩm \"" + hd.MaHD + "\" không?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {

                    hoa_don.XoaHD(hd.MaHD);
                    MessageBox.Show("Xóa thành công!!",
                       "Kết quả",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    LoadCSDLHoaDon();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại !!",
                       "Lỗi",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                }
            }
        }

        private void btnCapNhatHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
             hd = (DHoaDon)View.Columns[0].View.GetFocusedRow();
             frmThemHoaDon frm = new frmThemHoaDon(hoa_don, khach_hang, nhan_vien, hd);
            frm.ShowDialog();
            LoadCSDLHoaDon();
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            LoadCSDLChiTietHoaDon();
        }

        private void btnThemChiTietHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new frmThemChiTietHoaDon(chi_tiet_hoa_don,hoa_don,san_pham);
            frm.ShowDialog();
            LoadCSDLChiTietHoaDon();
        }

        private void btnXoaChiTietHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            cthd = (DChiTietHoaDon)View.Columns[0].View.GetFocusedRow();
            DialogResult tl = MessageBox.Show("Bạn có muốn xóa hoa don  \"" + cthd.MaHD + "\" không?", "Xóa Chi Tiết Hóa Đơn?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {

                    hoa_don.XoaHD(cthd.MaHD);
                    MessageBox.Show("Xóa thành công!!",
                       "Kết quả",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                   LoadCSDLChiTietHoaDon();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại !!",
                       "Lỗi",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                }
            }
        }

        private void btnCapNhatChiTietHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            cthd = (DChiTietHoaDon)View.Columns[0].View.GetFocusedRow();
            frmThemChiTietHoaDon frm = new frmThemChiTietHoaDon(chi_tiet_hoa_don, hoa_don, san_pham, cthd);
            frm.ShowDialog();
            LoadCSDLChiTietHoaDon(); 
        } 
    }
}
