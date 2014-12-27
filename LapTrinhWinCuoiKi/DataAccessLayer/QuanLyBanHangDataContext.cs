using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataAccessLayer
{
    public class QuanLyBanHangDataContext :DbContext
    {
        public QuanLyBanHangDataContext()
            : base("QuanLyBanHangDataContext")
        {

        }
        public DbSet <ThanhPho> ThanhPhos { get; set; }
        public DbSet <KhachHang> KhachHangs { get; set; }
        public DbSet <NhanVien> NhanViens { get; set; }
        public DbSet <HoaDon> HoaDons { get; set; }
        public DbSet <SanPham> SanPhams { get; set; }
        public DbSet <ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>().HasKey(s => new { s.MaHD, s.MaSP });
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<QuanLyBanHangDataContext>());
        }
    }
    public class ThanhPho
    {
        [Key]
        public string MaTP { get; set; }
        public string TenTP { get; set; }
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
    public class KhachHang
    {
        [Key]
        public string MaKH { get; set; }
        public string TenCty { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string MaTP { get; set; }
        [ForeignKey("MaTP")]
        public ThanhPho ThanhPho { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
    public class NhanVien
    {
        [Key]
        public string MaNV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public bool Nu { get; set; }
        public DateTime NgayNV { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public Byte[] Hinh { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }

    public class HoaDon
    {
        [Key]
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayLapHD { get; set; }
        public DateTime NgayNhanHang { get; set; }
        [ForeignKey("MaKH")]
        public KhachHang KhachHang { get; set; }

        [ForeignKey("MaNV")]
        public NhanVien NhanVien { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }

    public class SanPham
    {
        [Key]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonViTinh { get; set; }
        public double DonGia { get; set; }
        public Byte[] Hinh { get; set; }
        public Byte[] Hinh2 { get; set; }
        public string MaLoaiSP { get; set; }
        [ForeignKey("MaLoaiSP")]
        public LoaiSanPham LoaiSanPham { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
    public class ChiTietHoaDon
    {
        [Key, Column(Order = 1)]
        public string MaHD { get; set; }
        [Key, Column(Order = 2)]
        public string MaSP { get; set; }
        public int SoLuong { get; set; }


        [ForeignKey("MaHD")]
        public HoaDon HoaDon { get; set; }
        [ForeignKey("MaSP")]
        public SanPham SanPham { get; set; }
    }



    public class LoaiSanPham
    {
        [Key]
        public string MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }
        public ICollection<SanPham> SanPhams { get; set; }
    }
}
