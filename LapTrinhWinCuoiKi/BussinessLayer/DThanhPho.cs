using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLayer
{
    public class DThanhPho
    {
        private string maTP;
        public string MaTP
        {
            get { return maTP; }
            set { maTP = value; }
        }
        private string tenTP;
        public string TenTP
        {
            get { return tenTP; }
            set { tenTP = value; }
        }
        public DThanhPho()
        {
        }
        public DThanhPho(ThanhPho tp)
        {
            this.MaTP= tp.MaTP;
            this.TenTP = tp.TenTP;
        }
    }
}
