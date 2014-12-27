using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.OleDb;

namespace DoANLTQL10110139
{
    public partial class KetQuaHocTap : DevComponents.DotNetBar.Office2007Form
    {
        public KetQuaHocTap()
        {
            InitializeComponent();
        }
        private OleDbConnection objConnect;
        private DataTable objDataTable;
       
        private void subCreateConnect()
        {
            String varChuoiConnect = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/JVinhIT/Documents/QuanLySinhVien_10110139.accdb";
            objConnect = new OleDbConnection(varChuoiConnect);
            objConnect.Open(); //Mở kết nối
        }
        private void subDestroyConnect()
        {
            objConnect.Close(); //Đóng kết nối
            objConnect.Dispose();//Giải phóng tài nguyên
            objConnect = null; //Hủy đối tượng
        }

        private void getData(string sql)
        {
            subCreateConnect();
           
            OleDbCommand objCommand = new OleDbCommand(sql, objConnect);
            OleDbDataReader objReader = objCommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
            dgvKetQua.DataSource = objDataTable;
            objCommand.Dispose();
            objCommand = null;
            objReader.Close();
            objReader.Dispose();
            objReader = null;
            objDataTable.Dispose();
            objDataTable = null;
            //subDestroyConnect();

        }

        private void btnTimKiemMSSV_Click(object sender, EventArgs e)
        {
            string title = txtMasv.Text.ToString();
            if (title != "")
            {
                string sqltimkiem = "Select SinhVien.Masv, MonHoc.Mamon, MonHoc.Tenmon, KetQua.Diem From SinhVien, MonHoc, KetQua Where SinhVien.Masv = KetQua.Masv AND MonHoc.Mamon = KetQua.Mamon AND SinhVien.Masv LIKE '" + title + "%'";
                getData(sqltimkiem);
            }
            else
            {
                MessageBox.Show("Nhập MSSV!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string sql = "Select SinhVien.Masv, MonHoc.Mamon,MonHoc.TenMon,KetQua.Diem From SinhVien, MonHoc,KetQua Where SinhVien.Masv = KetQua.Masv And MonHoc.Mamon = KetQua.Mamon";
            getData(sql);
        }

       

        
    }
}
