namespace ThucTapCN.Forms
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.panelDonHangSubMenu = new System.Windows.Forms.Panel();
            this.btnTaoHDMoi = new System.Windows.Forms.Button();
            this.btnDatTruoc = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.panelDanhMucSubMenu = new System.Windows.Forms.Panel();
            this.btnKhuyenMai = new System.Windows.Forms.Button();
            this.btnLoaiSP = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelDonHangSubMenu.SuspendLayout();
            this.panelDanhMucSubMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelSideMenu.Controls.Add(this.btnQLTaiKhoan);
            this.panelSideMenu.Controls.Add(this.btnDangXuat);
            this.panelSideMenu.Controls.Add(this.btnBaoCao);
            this.panelSideMenu.Controls.Add(this.panelDonHangSubMenu);
            this.panelSideMenu.Controls.Add(this.btnDonHang);
            this.panelSideMenu.Controls.Add(this.panelDanhMucSubMenu);
            this.panelSideMenu.Controls.Add(this.btnDanhMuc);
            this.panelSideMenu.Controls.Add(this.btnKhachHang);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(355, 997);
            this.panelSideMenu.TabIndex = 1;
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQLTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTaiKhoan.Image = global::ThucTapCN.Properties.Resources.qly_user;
            this.btnQLTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(0, 801);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(355, 70);
            this.btnQLTaiKhoan.TabIndex = 9;
            this.btnQLTaiKhoan.Text = " Quản lý Tài khoản";
            this.btnQLTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::ThucTapCN.Properties.Resources.dang_xuat;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 927);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(355, 70);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "  &Đăng Xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Image = global::ThucTapCN.Properties.Resources.báo_cáo;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 731);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(355, 70);
            this.btnBaoCao.TabIndex = 7;
            this.btnBaoCao.Text = " Báo Cáo";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // panelDonHangSubMenu
            // 
            this.panelDonHangSubMenu.Controls.Add(this.btnTaoHDMoi);
            this.panelDonHangSubMenu.Controls.Add(this.btnDatTruoc);
            this.panelDonHangSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDonHangSubMenu.Location = new System.Drawing.Point(0, 582);
            this.panelDonHangSubMenu.Name = "panelDonHangSubMenu";
            this.panelDonHangSubMenu.Size = new System.Drawing.Size(355, 149);
            this.panelDonHangSubMenu.TabIndex = 6;
            // 
            // btnTaoHDMoi
            // 
            this.btnTaoHDMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnTaoHDMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaoHDMoi.FlatAppearance.BorderSize = 0;
            this.btnTaoHDMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHDMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHDMoi.Image = global::ThucTapCN.Properties.Resources.them_hoa_don;
            this.btnTaoHDMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHDMoi.Location = new System.Drawing.Point(0, 70);
            this.btnTaoHDMoi.Name = "btnTaoHDMoi";
            this.btnTaoHDMoi.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnTaoHDMoi.Size = new System.Drawing.Size(355, 79);
            this.btnTaoHDMoi.TabIndex = 1;
            this.btnTaoHDMoi.Text = " Tạo hóa đơn mới";
            this.btnTaoHDMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHDMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoHDMoi.UseVisualStyleBackColor = false;
            this.btnTaoHDMoi.Click += new System.EventHandler(this.btnTaoHDMoi_Click);
            // 
            // btnDatTruoc
            // 
            this.btnDatTruoc.BackColor = System.Drawing.SystemColors.Control;
            this.btnDatTruoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatTruoc.FlatAppearance.BorderSize = 0;
            this.btnDatTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatTruoc.Image = global::ThucTapCN.Properties.Resources.dat_truoc;
            this.btnDatTruoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatTruoc.Location = new System.Drawing.Point(0, 0);
            this.btnDatTruoc.Name = "btnDatTruoc";
            this.btnDatTruoc.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnDatTruoc.Size = new System.Drawing.Size(355, 70);
            this.btnDatTruoc.TabIndex = 0;
            this.btnDatTruoc.Text = " Đặt trước";
            this.btnDatTruoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatTruoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatTruoc.UseVisualStyleBackColor = false;
            this.btnDatTruoc.Click += new System.EventHandler(this.btnDatTruoc_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonHang.FlatAppearance.BorderSize = 0;
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Image = global::ThucTapCN.Properties.Resources.don_hang;
            this.btnDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.Location = new System.Drawing.Point(0, 512);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDonHang.Size = new System.Drawing.Size(355, 70);
            this.btnDonHang.TabIndex = 5;
            this.btnDonHang.Text = " Đặt Hàng";
            this.btnDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDonHang.UseVisualStyleBackColor = false;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // panelDanhMucSubMenu
            // 
            this.panelDanhMucSubMenu.Controls.Add(this.btnKhuyenMai);
            this.panelDanhMucSubMenu.Controls.Add(this.btnLoaiSP);
            this.panelDanhMucSubMenu.Controls.Add(this.btnSP);
            this.panelDanhMucSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanhMucSubMenu.Location = new System.Drawing.Point(0, 316);
            this.panelDanhMucSubMenu.Name = "panelDanhMucSubMenu";
            this.panelDanhMucSubMenu.Size = new System.Drawing.Size(355, 196);
            this.panelDanhMucSubMenu.TabIndex = 4;
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.BackColor = System.Drawing.SystemColors.Control;
            this.btnKhuyenMai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhuyenMai.FlatAppearance.BorderSize = 0;
            this.btnKhuyenMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhuyenMai.Image = global::ThucTapCN.Properties.Resources.giam_gia;
            this.btnKhuyenMai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhuyenMai.Location = new System.Drawing.Point(0, 140);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnKhuyenMai.Size = new System.Drawing.Size(355, 59);
            this.btnKhuyenMai.TabIndex = 2;
            this.btnKhuyenMai.Text = " Khuyến mại";
            this.btnKhuyenMai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhuyenMai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhuyenMai.UseVisualStyleBackColor = false;
            this.btnKhuyenMai.Click += new System.EventHandler(this.btnKhuyenMai_Click);
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoaiSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoaiSP.FlatAppearance.BorderSize = 0;
            this.btnLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSP.Image = global::ThucTapCN.Properties.Resources.loai_sp;
            this.btnLoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiSP.Location = new System.Drawing.Point(0, 70);
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnLoaiSP.Size = new System.Drawing.Size(355, 70);
            this.btnLoaiSP.TabIndex = 1;
            this.btnLoaiSP.Text = " Loại Sản phẩm";
            this.btnLoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoaiSP.UseVisualStyleBackColor = false;
            this.btnLoaiSP.Click += new System.EventHandler(this.btnLoaiSP_Click);
            // 
            // btnSP
            // 
            this.btnSP.BackColor = System.Drawing.SystemColors.Control;
            this.btnSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSP.FlatAppearance.BorderSize = 0;
            this.btnSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSP.Image = global::ThucTapCN.Properties.Resources.spham;
            this.btnSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSP.Location = new System.Drawing.Point(0, 0);
            this.btnSP.Name = "btnSP";
            this.btnSP.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnSP.Size = new System.Drawing.Size(355, 70);
            this.btnSP.TabIndex = 0;
            this.btnSP.Text = " Sản phẩm";
            this.btnSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSP.UseVisualStyleBackColor = false;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.Image = global::ThucTapCN.Properties.Resources.danhmuc;
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 246);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDanhMuc.Size = new System.Drawing.Size(355, 70);
            this.btnDanhMuc.TabIndex = 3;
            this.btnDanhMuc.Text = " Danh Mục";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Image = global::ThucTapCN.Properties.Resources.khach_hang;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 176);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(355, 70);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = " Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::ThucTapCN.Properties.Resources.logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(355, 176);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.panelTop);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(355, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1412, 997);
            this.panelChildForm.TabIndex = 4;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop.Controls.Add(this.lblChucVu);
            this.panelTop.Controls.Add(this.lblXinChao);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1412, 100);
            this.panelTop.TabIndex = 0;
            // 
            // lblChucVu
            // 
            this.lblChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(1102, 40);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(110, 29);
            this.lblChucVu.TabIndex = 1;
            this.lblChucVu.Text = "Chức vụ: ";
            // 
            // lblXinChao
            // 
            this.lblXinChao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.Location = new System.Drawing.Point(845, 40);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(119, 29);
            this.lblXinChao.TabIndex = 0;
            this.lblXinChao.Text = "Xin chào: ";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 997);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelDonHangSubMenu.ResumeLayout(false);
            this.panelDanhMucSubMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Panel panelDonHangSubMenu;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Panel panelDanhMucSubMenu;
        private System.Windows.Forms.Button btnKhuyenMai;
        private System.Windows.Forms.Button btnLoaiSP;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnQLTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnTaoHDMoi;
        private System.Windows.Forms.Button btnDatTruoc;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblXinChao;
    }
}