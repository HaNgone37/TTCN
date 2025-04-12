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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //panel1.BackColor = Color.FromArgb(0xDB, 0x7F, 0x8E);
            panelSideMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#f9baa9");
            //panelChildForm.BackColor = System.Drawing.ColorTranslator.FromHtml("#fffafa");
            //panelTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffe2e1");

            customizedesign();
        }
        private void customizedesign()
        {
            panelDanhMucSubMenu.Visible = false;
            panelDonHangSubMenu.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelDanhMucSubMenu.Visible == true)
                panelDanhMucSubMenu.Visible = false;
            if (panelDonHangSubMenu.Visible == true)
                panelDonHangSubMenu.Visible = false;
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmKhachHang());
            hidesubmenu();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmQlyTK());
            hidesubmenu();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            showsubmenu(panelDanhMucSubMenu);
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmSanPham());
            hidesubmenu();
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmDanhMucSP());
            hidesubmenu();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmKhuyenMai());
            hidesubmenu();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            showsubmenu(panelDonHangSubMenu);
        }

        private void btnDatTruoc_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }


        Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmBackGround());
        }

        private void btnTaoHDMoi_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
    }
}
