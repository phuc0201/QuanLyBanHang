using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyBanHang
{
    public partial class FormNV : Form
    {
        ConnectSqlAndFilldata dataTable;
        SqlConnection sqlConnection = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        int gioitinh = 0;
        string BirthDay = "";
        string strConn;
        public FormNV(string strconn)
        {
            strConn = strconn;
            dataTable = new ConnectSqlAndFilldata(sqlConnection, da,dt);
            InitializeComponent();      
            LoadData();
        }
        public void LoadData()
        {
            foreach(Control txt in this.Controls)
            {
                if(txt is TextBox)
                {
                    txt.ResetText();
                }
            }
            try
            {
                sqlConnection = new SqlConnection(strConn);
                dataTable.FillData(dgv_NV, "NHANVIEN", sqlConnection);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NHANVIEN. Lỗi rồi!!!");
            }           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            BirthDay+= dtP_BirthDay.Value.Year.ToString()+"-" + dtP_BirthDay.Value.Month.ToString()+"-" + dtP_BirthDay.Value.Day.ToString();
            if (txtMNV.Text!="" && txtHo.Text!="" && txtTen.Text!="" && txtPhoneNumber.Text!="" && txtDiaChi.Text!="" & txtPhoneNumber.Text.Length==10)
            {                
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
                sqlConnection.Open();
                try
                {
                    if (cb_Sex.CheckState == CheckState.Checked)
                        gioitinh = 1;
                    SqlCommand cmd = new SqlCommand();// 
                    cmd.Connection = sqlConnection;//
                    cmd.CommandType = CommandType.Text;//
                    cmd.CommandText = "Insert Into NhanVien Values(N'" + txtMNV.Text + "',N'" + txtHo.Text + "',N'"+txtTen.Text+"','"+gioitinh+"', '"+BirthDay+"', N'"+txtDiaChi.Text+"',N'"+txtPhoneNumber.Text+"', N'"+null+"')";
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm xong!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
                sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("Không thành công vui lòng nhập dữ liệu");
                txtMNV.Focus();
            }
            gioitinh = 0;
            LoadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa không?", "Trả lời",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
                sqlConnection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandType = CommandType.Text;
                    int r = dgv_NV.CurrentCell.RowIndex;
                    string strMaNV = dgv_NV.Rows[r].Cells[0].Value.ToString();
                    cmd.CommandText = "Delete From NhanVien Where MaNV='" + strMaNV.Trim() + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                    sqlConnection.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được. Lỗi rồi!!!");
                }
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            F_Find ffind = new F_Find(dgv_NV, "Mã số NV");
            ffind.ShowDialog();
        }
    }
}
