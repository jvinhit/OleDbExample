using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
namespace BussinessLayer
{
    public class BAKhachHang
    {
        QuanLyBanHangDataContext DBS = new QuanLyBanHangDataContext();
        public List<DKhachHang> XemDanhMucKhachHang()
        {
            var khachhang= from kh in DBS.KhachHangs
                           select kh;
            List<DKhachHang> listkh = new List<DKhachHang>();
            foreach (var khang in khachhang)
            {
                listkh.Add(new DKhachHang(khang));
            }
            return listkh;
        }
        public List<DKhachHang> LayKhachHangTheoThanhPho(string tp)
        {
            List<DKhachHang> lstKH = new List<DKhachHang>();
            var khachhang = from kh in DBS.KhachHangs
                        where kh.MaTP == tp
                        select kh;

            foreach (var item in khachhang)
            {
                lstKH.Add(new DKhachHang(item));
            }
            return lstKH;
        }
        public void ThemKhachHang(string makh, string tencty, string diachi ,string thanhpho , string dienthoai)
        {
            KhachHang kh = new KhachHang()
            {
                MaKH = makh,
                TenCty = tencty,
                DiaChi = diachi,
                MaTP = thanhpho,
                DienThoai = dienthoai
            };

            DBS.Entry(kh).State = EntityState.Added;
            DBS.SaveChanges();
        }
        public void CapNhatKhachHang(string makh, string tencty, string diachi, string thanhpho, string dienthoai)
        {
            KhachHang khachhangupdate = DBS.KhachHangs.Single(kh => kh.MaKH == makh);

            khachhangupdate.MaKH = makh;
            khachhangupdate.TenCty = tencty;
            khachhangupdate.DiaChi = diachi;
            khachhangupdate.MaTP = thanhpho;
            khachhangupdate.DienThoai = dienthoai;
            DBS.Entry(khachhangupdate).State = EntityState.Modified;
            DBS.SaveChanges();
        }

        public void XoaKhachHang(string MaKH)
        {
            KhachHang kh_xoa = DBS.KhachHangs.Single(kh => kh.MaKH == MaKH);
            DBS.Entry(kh_xoa).State = EntityState.Deleted;
            DBS.SaveChanges();
        }
    }
}
