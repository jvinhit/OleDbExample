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
    public partial class frmBuocThoiHoc : DevComponents.DotNetBar.Office2007Form
    {
        public frmBuocThoiHoc()
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
        private void getData()
        {
            subCreateConnect();
            string  sqlstringcc = "Select SinhVien.Masv, SinhVien.Hodem, SinhVien.Ten, BuocThoiHoc.LyDo From SinhVien,BuocThoiHoc Where SinhVien.Masv= BuocThoiHoc.Masv";
            OleDbCommand objCommand = new OleDbCommand(sqlstringcc, objConnect);
            OleDbDataReader objReader = objCommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
            dgvBuocThoiHoc.DataSource = objDataTable;
            objCommand.Dispose();
            objCommand = null;
            objReader.Close();
            objReader.Dispose();
            objReader = null;
            objDataTable.Dispose();
            objDataTable = null;
            subDestroyConnect();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            getData();
        }

    }
}
