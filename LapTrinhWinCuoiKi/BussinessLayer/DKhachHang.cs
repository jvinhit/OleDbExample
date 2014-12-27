using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLayer
{
    public class DKhachHang
    {
        private string maKH;
        public string  MaKH 
        {
            get { return maKH; }
            set { maKH = value; } 
        }
        private string tenCty;
        public string  TenCty 
        {
            get { return tenCty; }
            set { tenCty = value; }
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
        private string maTP;
        public string MaTP
        {
            get { return maTP; }
            set { maTP = value; }

        }
        public DKhachHang()
        {

        }
        public DKhachHang(KhachHang kh)
        {
            this.MaKH = kh.MaKH;
            this.TenCty = kh.TenCty;
            this.DiaChi = kh.DiaChi;
            this.DienThoai = kh.DienThoai;
            this.MaTP = kh.MaTP;
        }
    }
}
