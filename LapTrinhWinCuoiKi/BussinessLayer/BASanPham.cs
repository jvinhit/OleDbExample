using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using DataAccessLayer;
using System.Data;

namespace BussinessLayer
{
    public class BASanPham
    {
        QuanLyBanHangDataContext DBS = new QuanLyBanHangDataContext();
        public List<DSanPham> XemDanhMucSanPham()
        {
            var sanpham = from sp in DBS.SanPhams
                          select sp;
            List<DSanPham> listsanpham = new List<DSanPham>();
            foreach (var item in sanpham)
            {
                listsanpham.Add(new DSanPham(item));
            }

            return listsanpham;
        }
        public void ThemSanPham(string MaSP, string TenSP, string DonViTinh, double DonGia, string MaLoaiSP, Image Hinh, Image Hinh2)
        {
            MemoryStream ms = new MemoryStream();
            if (Hinh != null && Hinh2 != null)
            {
                Hinh.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Hinh2.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            }
            SanPham sp = new SanPham()
            {
                MaSP = MaSP,
                TenSP = TenSP,
                DonViTinh = DonViTinh,
                DonGia = DonGia,
                MaLoaiSP = MaLoaiSP,
                Hinh = Hinh == null ? null : ms.ToArray(),
                Hinh2 = Hinh2 == null ? null : ms.ToArray()
            };
            DBS.Entry(sp).State = EntityState.Added;
            DBS.SaveChanges();
        }
        public void XoaSanPham(string ma_sp)
        {
            
            SanPham sp_xoa = DBS.SanPhams.Single(tp => tp.MaSP == ma_sp);
            DBS.Entry(sp_xoa).State = EntityState.Deleted;
            DBS.SaveChanges();
        }
        public void CapNhatSanPham(string MaSP, string TenSP, string DonViTinh, double DonGia, string MaLoaiSP, Image Hinh, Image Hinh2)
        {
            SanPham sp_sua = DBS.SanPhams.Single(tp => tp.MaSP == MaSP);
            MemoryStream ms = new MemoryStream();
            if (Hinh != null && Hinh2 != null)
            {
                Hinh.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Hinh2.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            }
            sp_sua.MaSP = MaSP;
            sp_sua.TenSP = TenSP;
            sp_sua.DonViTinh = DonViTinh;
            sp_sua.DonGia = DonGia;
            sp_sua.MaLoaiSP = MaLoaiSP;
            sp_sua.Hinh = Hinh == null ? null : ms.ToArray();
            sp_sua.Hinh2 = Hinh2 == null ? null : ms.ToArray();
            DBS.Entry(sp_sua).State = EntityState.Modified;
            DBS.SaveChanges();
        }
    }
}
