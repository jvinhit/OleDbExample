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
    public partial class frmThem : DevComponents.DotNetBar.Office2007Form
    {
       

        private void frmThem_Load(object sender, EventArgs e)
        {
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();

            this.btnThem.Enabled = true;
            this.btnHuy.Enabled = false;
            this.btnXoa.Enabled = false;
            this.ThaoTac.Enabled = false;
            this.btnReload.Enabled = true;
            this.btnSua.Enabled = false;
           
        }
         private OleDbConnection objConnect;
        private DataTable objDataTable;
        public frmThem()
        {
            InitializeComponent();
        }
        private void subBindingData()
        {
            txtMaSinhVien.DataBindings.Clear();
            txtMaSinhVien.DataBindings.Add("Text", dgvSinhVien.DataSource, "Masv");
            txtHoDem.DataBindings.Clear();
            txtHoDem.DataBindings.Add("Text", dgvSinhVien.DataSource, "Hodem");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvSinhVien.DataSource, "Ten");
            dtpNgay.DataBindings.Clear();
            dtpNgay.DataBindings.Add("Text", dgvSinhVien.DataSource, "Ngaysinh");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dgvSinhVien.DataSource, "Gioitinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvSinhVien.DataSource, "Diachi");
            //txtHocBong.DataBindings.Clear();
            //txtHocBong.DataBindings.Add("Text", dgvSinhVien.DataSource, "Hocbong");
            txtMakhoa.DataBindings.Clear();
            txtMakhoa.DataBindings.Add("Text", dgvSinhVien.DataSource, "Makhoa");


        }
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
        private void subSelectBySQLTructiepQuaDataReader()
        {
            //Tạo kết nối tới file Access
            subCreateConnect();
            //Truy vấn dữ liệu

            String varSelect = "Select * From SinhVien ";
                //
                //"Select Masv, Hodem,Ten,Ngaysinh,iif(Gioitinh=-1,'Nữ','Nam') As Giotinh, Diachi,Hocbong,Makhoa  From SinhVien";//Lệnh SQL
            OleDbCommand objCommand = new OleDbCommand(varSelect, objConnect);
            //Tạo DataReader nhận dữ liệu trả về
            OleDbDataReader objReader = objCommand.ExecuteReader();
            //Tạo đối tượng DataTable và Load DataReader vào
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
            //Gán dữ liệu vào Datagrid
            dgvSinhVien.DataSource = objDataTable;
            //Hủy các đối tượng
            objCommand.Dispose();
            objCommand = null;
            objReader.Close();
            objReader.Dispose();
            objReader = null;
            objDataTable.Dispose();
            objDataTable = null;
            subDestroyConnect();
            
            
        }
         private void subInsertCommandHasParameter()
        {
            //Tạo kết nối tới file Access
            subCreateConnect();
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            //objCommand.CommandText = "Insert into DanhsachSV values(@STT,@Name,@Address,@Phone,@Email)";
            objCommand.CommandText = "Insert into SinhVien values(?,?,?,?,?,?,?)";
            objCommand.Parameters.Add("@Masv", OleDbType.Integer).Value = Convert.ToInt32(txtMaSinhVien.Text);
            objCommand.Parameters.Add("@Hodem", OleDbType.VarChar).Value = txtHoDem.Text;
            objCommand.Parameters.Add("@Ten", OleDbType.VarChar).Value = txtTen.Text;
            objCommand.Parameters.Add("@NgaySinh", OleDbType.VarChar).Value = dtpNgay.Text;
            objCommand.Parameters.Add("@Gioitinh", OleDbType.VarChar).Value = txtGioiTinh.Text;
            objCommand.Parameters.Add("@Diachi", OleDbType.VarChar).Value = txtDiaChi.Text;
           // objCommand.Parameters.Add("@Hocbong", OleDbType.VarChar).Value = txtHocBong.Text;
            objCommand.Parameters.Add("@Makhoa", OleDbType.VarChar).Value = txtMakhoa.Text;

            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            subDestroyConnect();
            subBindingData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            subInsertCommandHasParameter();
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();
        }

        private void ThaoTac_Click(object sender, EventArgs e)
        {
           
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            subDeleteCommandHasParameter();
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();
        }
        private void subDeleteCommandHasParameter()
        {
            //Tạo kết nối
            subCreateConnect();
            //Tạo command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Delete From SinhVien Where Masv = ?";
            objcommand.Parameters.Add("Masv", OleDbType.Integer).Value = Convert.ToInt32(txtMaSinhVien.Text);
            objcommand.ExecuteNonQuery();
            //Hủy đối tượng
            objcommand.Dispose(); objcommand = null;
            subDestroyConnect();
            this.btnXoa.Enabled= true;
            subBindingData();
        }

        #region Update DL
        //private void subUpdateCommandNoParameter()
        //{
        //    //Tạo kết nối tới file Access
        //    subCreateConnect();
        //    //Tạo đối tượng command
        //    OleDbCommand objCommand = new OleDbCommand();
        //    objCommand.Connection = objConnect;
        //    objCommand.CommandType = CommandType.Text;
        //    objCommand.CommandText = "Update SinhVien Set " +
        //                            "Hodem = " + "'" + txtHoDem.Text + "'" + "," +
        //                            "Ten = " + "'" + txtTen.Text + "'" + "," +
        //                            "Ngaysinh = " + "'" + dtpNgay.Text + "'" + "," +
        //                            "Gioitinh = " + "'" + txtGioiTinh.Text + "'" +","+
        //                            "Diachi = " + "'" +txtDiaChi.Text+"'"+","+
        //                            "Hocbong ="+"'"+ txtHocBong.Text+ "'"+","+
        //                            "Makhoa="+"'"+txtMakhoa.Text+"'"+","+
        //                            "Where Masv = " + Convert.ToInt32(txtMaSinhVien.Text);
        //    objCommand.ExecuteNonQuery();
        //    //Hủy đối tượng
        //    objCommand.Dispose();
        //    objCommand = null;
        //    subDestroyConnect();
        //}
        private void subUpdateCommandHasParameter()
        {
            //T?o k?t n?i t?i file Access
            subCreateConnect();
            //T?o d?i tu?ng command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update SinhVien Set Hodem = @Hodem, Ten=@Ten, Ngaysinh=@Ngaysinh, Gioitinh=@Gioitinh, Diachi=@Diachi, Makhoa=@Makhoa Where Masv=@Masv";
            //objCommand.CommandText = "Update DanhsachSV Set Name=?,Address=?,Phone=?,Email=? Where STT=?";                
            objCommand.Parameters.Add("@Hodem", OleDbType.VarChar).Value = txtHoDem.Text;
            objCommand.Parameters.Add("@Ten", OleDbType.VarChar).Value = txtTen.Text;
            objCommand.Parameters.Add("@Ngaysinh", OleDbType.VarChar).Value = dtpNgay.Text;
            objCommand.Parameters.Add("@Gioitinh", OleDbType.VarChar).Value = txtGioiTinh.Text;
            objCommand.Parameters.Add("@Diachi", OleDbType.VarChar).Value = txtDiaChi.Text;
           // objCommand.Parameters.Add("@Hocbong", OleDbType.VarChar).Value = txtHocBong.Text;
            objCommand.Parameters.Add("@Makhoa", OleDbType.VarChar).Value = txtMakhoa.Text;
            objCommand.Parameters.Add("@Masv", OleDbType.Integer).Value = Convert.ToInt32(txtMaSinhVien.Text);
            objCommand.ExecuteNonQuery();
            //H?y d?i tu?ng
            objCommand.Dispose();
            objCommand = null;
            subDestroyConnect();
            subBindingData();
        }
        #endregion
        private void btnSua_Click(object sender, EventArgs e)
        {
          
            subUpdateCommandHasParameter();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();
        }

      

    }
}
