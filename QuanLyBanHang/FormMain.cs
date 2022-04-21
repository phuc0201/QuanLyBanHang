using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FMain : Form
    {
        FormNV fNV;
        public FMain()
        {
            InitializeComponent();
            string strConn = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            fNV = new FormNV(strConn);
        }

        private void table_NV_Click(object sender, EventArgs e)
        {
            fNV.ShowDialog();
        }
    }
}
