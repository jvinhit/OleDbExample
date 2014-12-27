using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BussinessLayer
{
    public class BAThanhPho
    {
        QuanLyBanHangDataContext DBS = new QuanLyBanHangDataContext();
        public List<DThanhPho> XemDanhMucThanhPho()
        {
            var tpho = from tp in DBS.ThanhPhos
                       select tp;
            List<DThanhPho> listTP = new List<DThanhPho>();
            foreach (var item in tpho)
            {
                listTP.Add(new DThanhPho(item));
            }
            return listTP;
        }
        public void ThemThanhPho(string ma_tp, string ten_tp)
        {
            ThanhPho tp = new ThanhPho()
            {
                MaTP = ma_tp,
                TenTP = ten_tp
            };
            DBS.Entry(tp).State = EntityState.Added;
            DBS.SaveChanges();
        }
        public void SuaThanhPho(string ma_tp, string ten_tp)
        {
            ThanhPho tp_sua = DBS.ThanhPhos.Single(tp => tp.MaTP == ma_tp);
            tp_sua.TenTP = ten_tp;
            DBS.Entry(tp_sua).State = EntityState.Modified;
            DBS.SaveChanges();
        }

        public void XoaThanhPho(string ma_tp)
        {
            ThanhPho tp_xoa = DBS.ThanhPhos.Single(tp => tp.MaTP == ma_tp);

            DBS.Entry(tp_xoa).State = EntityState.Deleted;
            DBS.SaveChanges();
        }

    }
}
