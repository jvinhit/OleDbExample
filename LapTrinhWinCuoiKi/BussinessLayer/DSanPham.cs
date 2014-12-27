using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Drawing;
using System.IO;

namespace BussinessLayer
{
    public class DSanPham
    {
        private string masp;
        public string MaSP
        {
            get { return masp; }
            set { masp = value; }
        }
        private string tensp;
        public string TenSP
        {
            get { return tensp; }
            set { tensp = value; }
        }
        private string donvitinh;
        public string DonViTinh
        {
            get { return donvitinh; }
            set { donvitinh = value; }
        }
        private double dongia;
        public double DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        private Image hinh;
        public Image Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }
        private string maloaisp;
        public string MaLoaiSP
        {
            get { return maloaisp; }
            set { maloaisp = value; }
        }
        private Image hinh2;
        public Image Hinh2
        {
            get { return hinh2; }
            set { hinh2 = value; }
        }
        
        public DSanPham()
        {

        }
        public DSanPham(SanPham sp)
        {
            this.masp = sp.MaSP;
            this.tensp = sp.TenSP;
            this.donvitinh = sp.DonViTinh;
            this.dongia = sp.DonGia;
            this.hinh = sp.Hinh == null ? null : Image.FromStream(new MemoryStream(sp.Hinh.ToArray()));
            this.hinh2 = sp.Hinh2 == null ? null : Image.FromStream(new MemoryStream(sp.Hinh2.ToArray()));
            this.maloaisp = sp.MaLoaiSP;

        }
    }
}
