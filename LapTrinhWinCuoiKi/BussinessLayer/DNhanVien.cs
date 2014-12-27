using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.IO;
using System.Drawing;


namespace BussinessLayer
{
    public class DNhanVien
    {
        private string manv;
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        private string ho;
        public string Ho
        {
            get { return ho; }
            set { ho = value; }
        }
        private string ten;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private bool nu;
        public bool Nu
        {
            get { return nu; }
            set { nu = value; }
        }
        private DateTime ngaynv;
        public DateTime NgayNV
        {
            get { return ngaynv; }
            set { ngaynv = value; }
        }
        private string diachi;
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private string dienthoai;
        public string DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        private Image hinh;
        public Image Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }
        public DNhanVien()
        {

        }

        public DNhanVien(NhanVien nv)
        {
            this.manv = nv.MaNV;
            this.ho = nv.Ho;
            this.ten = nv.Ten;
            this.nu = nv.Nu;
            this.diachi = nv.DiaChi;
            this.dienthoai = nv.DienThoai;
            this.hinh = nv.Hinh == null ? null : Image.FromStream(new MemoryStream(nv.Hinh.ToArray()));
            this.ngaynv = nv.NgayNV;
        }
       
    }
}
