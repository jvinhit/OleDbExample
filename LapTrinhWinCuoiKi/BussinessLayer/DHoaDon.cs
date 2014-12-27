using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BussinessLayer
{
    public class DHoaDon
    {
        private string mahd;
        public string  MaHD
        {
            get { return mahd; }
            set { mahd = value; } 
        }
        private string makh;
        public string MaKH
        {
            get { return makh; }
            set { makh = value; } 
        }
        private string manv;
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        private DateTime ngaylapHD;
        public DateTime NgayLapHD
        {
            get { return ngaylapHD; }
            set { ngaylapHD = value; }
        }
        private DateTime ngaynhanhang;
        public DateTime NgayNhanHang
        {
            get { return ngaynhanhang; }
            set { ngaynhanhang = value; }
        }
        public DHoaDon()
        {

        }
        public DHoaDon(HoaDon hd)
        {
            this.mahd = hd.MaHD;
            this.makh = hd.MaKH;
            this.manv = hd.MaNV;
            this.ngaylapHD = hd.NgayLapHD;
            this.ngaynhanhang = hd.NgayNhanHang;
        }

    }
}
