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
    public partial class DiemRenLuyen : DevComponents.DotNetBar.Office2007Form
    {
        public DiemRenLuyen()
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
        private void GetDataTimKiem(string sql)
        {

            subCreateConnect();
           
            OleDbCommand objCommand = new OleDbCommand(sql, objConnect);
            OleDbDataReader objReader = objCommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
            dgvDiemRenLuyen.DataSource = objDataTable;
            objCommand.Dispose();
            objCommand = null;
            objReader.Close();
            objReader.Dispose();
            objReader = null;
            objDataTable.Dispose();
            objDataTable = null;
            subDestroyConnect();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            string sql = "Select SinhVien.Masv,SinhVien.Hodem, SinhVien.Ten, DiemRenLuyen.DiemRL From SinhVien, DiemRenLuyen Where SinhVien.Masv = DiemRenLuyen.Masv";
            GetDataTimKiem(sql);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string title = txtMasv.Text.ToString();
            if (title != "")
            {
                String sqltimkiem = "select Sinhvien.Masv, SinhVien.Hodem, Sinhvien.Ten,DiemRenLuyen.DiemRL From SinhVien,DiemRenLuyen Where SinhVien.Masv = DiemRenLuyen.Masv and SinhVien.Masv= '"+title+"'"; //Select SinhVien.Masv,SinhVien.Hodem, SinhVien.Ten, DiemRenLuyen.DiemRL From SinhVien, DiemRenLuyen Where SinhVien.Masv = DiemRenLuyen.Masv LIKE '" + title + "%'";
                 GetDataTimKiem(sqltimkiem);
            }
            else
            {
                MessageBox.Show("Nhập MSSV!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
