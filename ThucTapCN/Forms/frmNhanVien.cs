using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapCN.Class;

namespace ThucTapCN.Forms
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#f9baa9");
        }


        DataTable tblNv;
        //private void frmNhanVien_Load(object sender, EventArgs e)
        //{
        //    txtManv.Enabled = false;
        //    btnLuu.Enabled = false;
        //    btnBoqua.Enabled = false;
        //    Load_DataGridView();

        //    ResetValues();

        //    txtTimkiem.Enter += TxtTimkiem_Enter;
        //    txtTimkiem.Leave += TxtTimkiem_Leave;

        //    txtTimkiem.Text = placeholderText;
        //    txtTimkiem.ForeColor = SystemColors.GrayText; // Màu xám nhạt
        //}

        private string placeholderText = "Nhập từ khóa cần tìm kiếm...";

        private void TxtTimkiem_Enter(object sender, EventArgs e)
        {
            // Khi người dùng nhấp vào ô tìm kiếm
            if (txtTimkiem.Text == placeholderText)
            {
                txtTimkiem.Text = "";
                txtTimkiem.ForeColor = SystemColors.WindowText; // Màu văn bản bình thường
            }
        }

        private void TxtTimkiem_Leave(object sender, EventArgs e)
        {
            // Khi người dùng rời khỏi ô tìm kiếm
            if (string.IsNullOrWhiteSpace(txtTimkiem.Text))
            {
                txtTimkiem.Text = placeholderText;
                txtTimkiem.ForeColor = SystemColors.GrayText; // Màu xám nhạt
            }
        }

        private void ResetValues()
        {
            txtManv.Text = "";
            txtTennhanvien.Text = "";
            txtAnh.Text = "";
            txtSdt.Text = "";
            txtDiachi.Text = "";
            if (rdoNam.Checked)
            {
                rdoNam.Checked = false;
            }
            if (rdoNu.Checked)
            {
                rdoNu.Checked = false;
            }
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from nhanvien";

            tblNv = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblNv;
            DataGridView.Columns[0].HeaderText = "Mã nhân viên";
            DataGridView.Columns[1].HeaderText = "Tên nhân viên";
            DataGridView.Columns[2].HeaderText = "Ngày sinh";
            DataGridView.Columns[3].HeaderText = "Giới tính";
            DataGridView.Columns[4].HeaderText = "Địa chỉ";
            DataGridView.Columns[5].HeaderText = "SĐT";
            DataGridView.Columns[6].HeaderText = "Ảnh";
            DataGridView.Columns[0].Width = 80;
            DataGridView.Columns[1].Width = 120;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 80;
            DataGridView.Columns[4].Width = 120;
            DataGridView.Columns[5].Width = 120;
            DataGridView.Columns[6].Width = 120;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if(btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManv.Focus();
                return;
            }
            if (tblNv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManv.Text = DataGridView.CurrentRow.Cells["manv"].Value.ToString();
            txtTennhanvien.Text = DataGridView.CurrentRow.Cells["tennv"].Value.ToString();
            txtDiachi.Text = DataGridView.CurrentRow.Cells["diachi"].Value.ToString();
            txtSdt.Text = DataGridView.CurrentRow.Cells["sdt"].Value.ToString();
            if (DataGridView.CurrentRow.Cells["gioitinh"].Value.ToString() == "Nam")
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            if (DataGridView.CurrentRow.Cells["Anh"].Value.ToString() != "")
            {
                txtAnh.Text = DataGridView.CurrentRow.Cells["Anh"].Value.ToString();
                picAnh.Image = Image.FromFile(txtAnh.Text);
            }
            else
            {
                txtAnh.Text = "";
                picAnh.Image = null;
            }
            dateNgaysinh.Value = (DateTime)DataGridView.CurrentRow.Cells["ngaysinh"].Value;
            btnBoqua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtManv.Enabled = true;
            txtManv.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if(tblNv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtManv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtTennhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return;
            }
            if (txtSdt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return;
            }
            string gt;
            if (rdoNam.Checked)
            {
                gt = "Nam";
            }
            else if (rdoNu.Checked)
            {
                gt = "Nữ";
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giới tính nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dateNgaysinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNgaysinh.Focus();
                return;
            }
            if(dateNgaysinh.Value.Year < 1900)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNgaysinh.Focus();
                return;
            }
            DateTime today = DateTime.Today;
            int age = today.Year - dateNgaysinh.Value.Year;
            if (dateNgaysinh.Value.Date > today.AddYears(-age)) age--; // Trừ 1 nếu chưa tới sinh nhật năm nay

            if (age < 18)
            {
                MessageBox.Show("Nhân viên phải từ đủ 18 tuổi trở lên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNgaysinh.Focus();
                return;
            }
            sql = "update nhanvien set tennv=N'" + txtTennhanvien.Text.Trim() 
                + "', ngaysinh='" + dateNgaysinh.Value.ToString("yyyy-MM-dd") 
                + "', gioitinh=N'" + gt 
                + "', diachi=N'" + txtDiachi.Text.ToString() 
                + "', sdt='" + txtSdt.Text.Trim() 
                + "', anh = N'" + txtAnh.Text.Trim()
                + "' where manv='" + txtManv.Text.Trim().ToString() + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                sql = "SELECT * FROM Hoadonban WHERE Manv='" + txtManv.Text + "'";
                if (Functions.CheckKey(sql))
                {
                    MessageBox.Show("Không thể xóa nhân viên này vì ràng buộc dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql = "SELECT * FROM Hoadonnhap WHERE Manv='" + txtManv.Text + "'";
                if (Functions.CheckKey(sql))
                {
                    MessageBox.Show("Không thể xóa nhân viên này vì ràng buộc dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql = "SELECT * FROM Dondattruoc WHERE Manv='" + txtManv.Text + "'";
                if (Functions.CheckKey(sql))
                {
                    MessageBox.Show("Không thể xóa nhân viên này vì ràng buộc dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    sql = "DELETE Nhanvien WHERE Manv='" + txtManv.Text + "'";
                    Functions.RunSqlDel(sql);
                    Load_DataGridView();
                }
            }
            ResetValues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if(txtManv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManv.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return;
            }
            if (txtSdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return;
            }
            string gt;
            if (rdoNam.Checked)
            {
                gt = "Nam";
            }
            else if (rdoNu.Checked)
            {
                gt = "Nữ";
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giới tính nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dateNgaysinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNgaysinh.Focus();
                return;
            }
            if (dateNgaysinh.Value.Year < 1900)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNgaysinh.Focus();
                return;
            }
            DateTime today = DateTime.Today;
            int age = today.Year - dateNgaysinh.Value.Year;
            if (dateNgaysinh.Value.Date > today.AddYears(-age)) age--; // Trừ 1 nếu chưa tới sinh nhật năm nay

            if (age < 18)
            {
                MessageBox.Show("Nhân viên phải từ đủ 18 tuổi trở lên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNgaysinh.Focus();
                return;
            }
            sql = "SELECT manv FROM nhanvien WHERE manv='" + txtManv.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManv.Focus();
                txtManv.Text = "";
                return;
            }
            else
            {
                sql = "INSERT INTO nhanvien(manv, tennv, ngaysinh, gioitinh, diachi, sdt, anh) VALUES('" + txtManv.Text.Trim().ToString()
                    + "', N'" + txtTennhanvien.Text.Trim().ToString()
                    + "', '" + dateNgaysinh.Value.ToString("yyyy-MM-dd")
                    + "', N'" + gt
                    + "', N'" + txtDiachi.Text.Trim()
                    + "', '" + txtSdt.Text.Trim()
                    + "', N'" + txtAnh.Text.Trim()
                    + "')";
                Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
            }
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtManv.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chon hinh anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManv.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable tblTk;
            string sql;
            if (txtTimkiem.Text == placeholderText || txtTimkiem.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTimkiem.Focus();
                return;
            }
            sql = "SELECT * FROM Nhanvien WHERE Manv LIKE N'%" + txtTimkiem.Text.Trim() + "%' OR Tennv LIKE N'%" + txtTimkiem.Text.Trim() + "%'";
            tblTk = Functions.GetDataToTable(sql);
            if (tblTk.Rows.Count == 0)
            {
                //MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (DialogResult.OK == MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question))
                {
                    DataGridView.DataSource = tblNv;
                    txtTimkiem.Text = placeholderText;
                    txtTimkiem.Focus();
                    return;
                }
            }
            //else
            //{
            //    MessageBox.Show("Tìm thấy " + tblHH.Rows.Count + " kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            DataGridView.DataSource = tblTk;
            ResetValues();
        }

        private void frmNhanVien_Load_1(object sender, EventArgs e)
        {
            txtManv.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();

            ResetValues();

            txtTimkiem.Enter += TxtTimkiem_Enter;
            txtTimkiem.Leave += TxtTimkiem_Leave;

            txtTimkiem.Text = placeholderText;
            txtTimkiem.ForeColor = SystemColors.GrayText; // Màu xám nhạt
        }
    }
}
