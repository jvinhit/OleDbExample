using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
namespace BussinessLayer
{
    public class BAHoaDon
    {
        QuanLyBanHangDataContext DBS = new QuanLyBanHangDataContext();
        public List<DHoaDon> XemDanhMucHoaDon()
        {
            var hoadon = from hd in DBS.HoaDons
                         select hd;
            List<DHoaDon> listhoadon = new List<DHoaDon>();
            foreach (var item in hoadon)
            {
                listhoadon.Add(new DHoaDon(item));

            }
            return listhoadon;
        }
        public List<DHoaDon> LayHoaDonTheoKhachHang(string makhach)
        {
            List<DHoaDon> lstHoaDon = new List<DHoaDon>();
            var hd =
                from x in DBS.HoaDons
                where x.MaKH == makhach
                select x;

            foreach (var item in hd)
            {
                lstHoaDon.Add(new DHoaDon(item));
            }

            return lstHoaDon;
        }

        public List<DHoaDon> LayHoaDonTheoNhanVien(string manv)
        {
            List<DHoaDon> lstHoaDon = new List<DHoaDon>();
            var hd =
                from x in DBS.HoaDons
                where x.MaNV == manv
                select x;

            foreach (var item in hd)
            {
                lstHoaDon.Add(new DHoaDon(item));
            }

            return lstHoaDon;
        }

        public void ThemHoaDon(string MaHD, string MaKH, string MaNV, DateTime NgayLapHD, DateTime NgayNhanHang)
        {
            HoaDon hd = new HoaDon()
            {
                MaHD = MaHD,
                MaKH = MaKH,
                MaNV = MaNV,
                NgayLapHD = NgayLapHD,
                NgayNhanHang = NgayNhanHang
            };
            DBS.Entry(hd).State = EntityState.Added;
            DBS.SaveChanges();
        }

        public void CapNhatHoaDon(string MaHD, string MaKH, string MaNV, DateTime NgayLapHD, DateTime NgayNhanHang)
        {
            HoaDon hd_sua = DBS.HoaDons.Single(tp => tp.MaHD == MaHD);

            hd_sua.MaHD = MaHD;
            hd_sua.MaKH = MaKH;
            hd_sua.MaNV = MaNV;
            hd_sua.NgayLapHD = NgayLapHD;
            hd_sua.NgayNhanHang = NgayNhanHang;
            DBS.SaveChanges();
        }


        public void XoaHD(string ma_hd)
        {
            HoaDon hd_xoa = DBS.HoaDons.Single(tp => tp.MaHD == ma_hd);

            DBS.Entry(hd_xoa).State = EntityState.Modified;
            DBS.SaveChanges();
        }


    }
}
