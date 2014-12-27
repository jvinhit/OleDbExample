using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace LapTrinhWinCuoiKi
{
    public partial class frmConnectDatabase : DevExpress.XtraEditors.XtraForm
    {
        public frmConnectDatabase()
        {
            InitializeComponent();
        }

        private void frmConnectDatabase_Load(object sender, EventArgs e)
        {
            cbAuthentication.SelectedIndex = 1;
        }
        public static string ConnectionString = "";
        public static string DataBase = "";

        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            if (cbAuthentication.SelectedIndex == 0)
            {
                cbDatabase.Items.Clear();
                SqlConnection conn = new SqlConnection("Server=" + txtServer.Text + ";DataBase=Master;UID=" + txtUser.Text + ";PWD=" + txtPass.Text + ";");
                SqlCommand cmd = new SqlCommand("sp_databases", conn);
                SqlDataReader rdr;
                try
                {
                    conn.Open();
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        cbDatabase.Items.Add(rdr[0].ToString());
                    }
                    MessageBox.Show("Success...", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Dispose();
                    cmd.Dispose();
                }
            }
            if (cbAuthentication.SelectedIndex == 1)
            {
                cbDatabase.Items.Clear();
                SqlConnection conn = new SqlConnection("Server=" + txtServer.Text + ";DataBase=Master;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("sp_databases", conn);
                SqlDataReader rdr;
                try
                {
                    conn.Open();
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        cbDatabase.Items.Add(rdr[0].ToString());
                    }
                    MessageBox.Show("Success...", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Dispose();
                    cmd.Dispose();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbDatabase.Text != "")
            {

                if (cbAuthentication.SelectedIndex == 0)
                {
                    DataBase = cbDatabase.Text;
                    ConnectionString = "Server=" + txtServer.Text + ";DataBase=" + cbDatabase.Text + ";UID=" + txtUser.Text + ";PWD=" + txtPass.Text + ";";
                }
                else
                {
                    DataBase = cbDatabase.Text;
                    ConnectionString = "Server=" + txtServer.Text + ";DataBase=" + cbDatabase.Text + ";Integrated Security=true;";
                }
                this.Hide();
            }
        }
        private void cbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthentication.SelectedIndex == 1)
            {
                txtPass.Enabled = false;
                txtUser.Enabled = false;
            }
            else
            {
                txtPass.Enabled = true;
                txtUser.Enabled = true;
            }
        }
    }
}
