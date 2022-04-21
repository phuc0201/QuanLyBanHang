using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace QuanLyBanHang
{
    public class ConnectSqlAndFilldata
    {
        string str_SelectTable = "SELECT * FROM ";
        public SqlDataAdapter da { get; set; }
        public DataTable dt { get; set; }
        public ConnectSqlAndFilldata(SqlConnection conn, SqlDataAdapter da, DataTable dt)
        {
            this.dt = dt;
            this.da = da;
        }
        public void FillData(DataGridView dgv, string Table, SqlConnection sqlConn)
        {
            try
            {
                da = new SqlDataAdapter(str_SelectTable + Table, sqlConn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }
    }
}
