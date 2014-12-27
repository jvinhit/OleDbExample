using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;


namespace BussinessLayer
{
    public class BANhanVien
    {
        QuanLyBanHangDataContext DBS = new QuanLyBanHangDataContext();

        public List<DNhanVien> XemDanhMucNhanVien()
        {
            var nhanvien =
                from nv in DBS.NhanViens
                select nv;
            List<DNhanVien> lstNhanVien = new List<DNhanVien>();

            foreach (var item in nhanvien)
            {
                lstNhanVien.Add(new DNhanVien(item));
            }

            return lstNhanVien;

        }
        public void ThemNhanVien(string MaNV, string Ho, string Ten, bool gt, DateTime nnv, string DiaChi, string Dienthoai, Image Hinh)
        {
            MemoryStream ms = new MemoryStream();
            if (Hinh != null)
            {
                Hinh.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            }
            NhanVien nv = new NhanVien()
            {
                MaNV = MaNV,
                Ho = Ho,
                Ten = Ten,
                Nu = gt,
                DiaChi = DiaChi,
                NgayNV = nnv,
                DienThoai = Dienthoai,
                //Hinh = Hinh == null ? null : new System.Data.Linq.Binary(ms.GetBuffer()),
                Hinh = Hinh == null ? null : ms.ToArray()
            };
            DBS.Entry(nv).State = EntityState.Added;
            DBS.SaveChanges();
        }

        public void CapNhatNhanVien(string MaNV, string Ho, string Ten, bool gt, DateTime nnv, string DiaChi, string Dienthoai, Image Hinh)
        {
            NhanVien nv_sua = DBS.NhanViens.Single(tp => tp.MaNV == MaNV);
            MemoryStream ms = new MemoryStream();
            if (Hinh != null)
            {
                Hinh.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            }
            nv_sua.MaNV = MaNV;
            nv_sua.Ho = Ho;
            nv_sua.Ten = Ten;
            nv_sua.Nu = gt;
            nv_sua.NgayNV = nnv;
            nv_sua.DiaChi = DiaChi;
            nv_sua.DienThoai = Dienthoai;
            //nv_sua.Hinh = Hinh == null ? null : new System.Data.Linq.Binary(ms.GetBuffer());

            nv_sua.Hinh = Hinh == null ? null : ms.ToArray();
            DBS.Entry(nv_sua).State = EntityState.Modified;
            DBS.SaveChanges();
        }

        public void XoaNhanVien(string ma_nv)
        {
            NhanVien nv_xoa = DBS.NhanViens.Single(tp => tp.MaNV == ma_nv);

            DBS.Entry(nv_xoa).State = EntityState.Deleted;
            DBS.SaveChanges();
        }
    }
}
