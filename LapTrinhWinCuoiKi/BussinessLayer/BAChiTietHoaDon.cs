using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BussinessLayer
{
    public class BAChiTietHoaDon
    {
        QuanLyBanHangDataContext DBS = new QuanLyBanHangDataContext();
        public List<DChiTietHoaDon> XemDanhMucChiTietHoaDon()
        {
            var cthoadon = from cthd in DBS.ChiTietHoaDons
                         select cthd;
            List<DChiTietHoaDon> listcthoadon = new List<DChiTietHoaDon>();
            foreach (var item in cthoadon)
            {
                listcthoadon.Add(new DChiTietHoaDon(item));
            }
            return listcthoadon;
        }
        public void ThemChiTietHoaDon(string maHD, string maSP, int soLuong)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon()
            {
                MaHD = maHD,
                MaSP = maSP,
                SoLuong = soLuong
            };
            DBS.Entry(cthd).State = EntityState.Added;
            DBS.SaveChanges();
        }
        public void CapNhatChiTietHoaDon(string maHD, string maSP, int soLuong)
        {
            ChiTietHoaDon cthd_capnhat= DBS.ChiTietHoaDons.Single(tp => tp.MaHD==maHD);
            cthd_capnhat.MaHD = maHD;
            cthd_capnhat.MaSP = maSP;
            cthd_capnhat.SoLuong = soLuong;
            DBS.SaveChanges();
        }
        public void XoaChiTietHoaDon(string maHD)
        {
            ChiTietHoaDon cthd_xoa = DBS.ChiTietHoaDons.Single(tp => tp.MaHD == maHD);
            DBS.Entry(cthd_xoa).State = EntityState.Modified;
            DBS.SaveChanges();
        }
    }
}
