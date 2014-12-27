using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLayer
{
    public class LoadCSDL
    {
        public void InitialData()
        {
            TaoCSDL dt = new TaoCSDL();
            dt.ThemDuLieu();
        } 
    }
}
