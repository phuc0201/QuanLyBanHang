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
    public partial class F_Find : Form
    {
        DataGridView _dgv;
        public F_Find(DataGridView dgv, string str)
        {
            InitializeComponent();
            _dgv = dgv;
            lb_PrimaryKeyFromTable.Text = str;
        }
        private bool FindFormDgv()
        {
            for (int i = 0; i < _dgv.Rows.Count-1; i++)
            {
                MessageBox.Show("" + _dgv.Rows[i].Cells[0].Value.ToString());
                if (txtPrimaryKeyFromTable.Text == _dgv.Rows[i].Cells[0].Value.ToString())
                {                    
                    return true;
                }
            }
            return false;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            /*            if (FindFormDgv()==true)
                            MessageBox.Show("Đã tìm thấy");
                        else
                            MessageBox.Show("Không tìm thấy vui lòng kiểm tra lại thông tin!");*/
            FindFormDgv();
        }
    }
}
