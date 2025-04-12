using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapCN.Forms
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {

        }

        //private void frmKhachHang_Resize(object sender, EventArgs e)
        //{
        //    int groupBoxWidth = grbQLKH.Width;
        //    int groupBoxHeight = grbQLKH.Height;

        //    int labelWidth = 101;
        //    int textboxWidth = groupBoxWidth - labelWidth - 20; // 20 for padding

        //    lblMaKH.Width = labelWidth;
        //    txtMaKH.Width = textboxWidth;
        //    txtMaKH.Left = lblMaKH.Right + 5;

        //    lblTenKH.Width = labelWidth;
        //    txtTenKH.Width = textboxWidth;
        //    txtTenKH.Left = lblTenKH.Right + 5;

        //    lblDiaChi.Width = labelWidth;
        //    txtDiaChi.Width = textboxWidth;
        //    txtDiaChi.Left = lblDiaChi.Right + 5;

        //    lblSDT.Width = labelWidth;
        //    txtSDT.Width = textboxWidth;
        //    txtSDT.Left = lblSDT.Right + 5;

        //    lblID.Width = labelWidth;
        //    txtID.Width = textboxWidth;
        //    txtID.Left = lblID.Right + 5;

        //}
    }
}
