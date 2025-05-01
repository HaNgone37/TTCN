using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ThucTapCN.Class;

namespace ThucTapCN.Forms
{
    public partial class frmKhuyenMai : Form
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#f9baa9");
        }

        DataTable tblKm;

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            txtMakm.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            Load_DataGridView();
            ResetValues();
            cboGiatri.Items.AddRange(new string[] { "5%", "10%", "15%", "20%", "25%", "50%" });

            cboTrangthai.Items.AddRange(new string[] { "Đang áp dụng", "Đã hết hạn", "Sắp diễn ra", "Tạm ngưng" });

            cboGiatri.SelectedIndex = -1;
            cboTrangthai.SelectedIndex = -1;
            cboGiatri.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangthai.DropDownStyle = ComboBoxStyle.DropDownList;

            txtTimkiem.Enter += TxtTimkiem_Enter;
            txtTimkiem.Leave += TxtTimkiem_Leave;

            txtTimkiem.Text = placeholderText;
            txtTimkiem.ForeColor = SystemColors.GrayText; // Màu xám nhạt
        }

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

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM CTkhuyenmai";
            tblKm = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblKm;
            DataGridView.Columns[0].HeaderText = "Mã CTKM";
            DataGridView.Columns[1].HeaderText = "Tên Chương trình";
            DataGridView.Columns[2].HeaderText = "Mô tả";
            DataGridView.Columns[3].HeaderText = "Giá trị (%)";
            DataGridView.Columns[4].HeaderText = "Trạng thái";
            DataGridView.Columns[5].HeaderText = "Ngày bắt đầu";
            DataGridView.Columns[6].HeaderText = "Ngày kết thúc";
            DataGridView.Columns[0].Width = 150;
            DataGridView.Columns[1].Width = 200;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 100;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void ResetValues()
        {
            txtMakm.Text = "";
            txtTenct.Text = "";
            txtMota.Text = "";
            cboGiatri.SelectedIndex = -1;
            cboTrangthai.SelectedIndex = -1;
            dateNgaybd.Value = DateTime.Now;
            dateNgaykt.Value = DateTime.Now;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang trong chế độ thêm mới, không thể chọn bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tblKm.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMakm.Text = DataGridView.CurrentRow.Cells["mactkm"].Value.ToString();
            txtTenct.Text = DataGridView.CurrentRow.Cells["tenctkm"].Value.ToString();
            txtMota.Text = DataGridView.CurrentRow.Cells["mota"].Value.ToString();
            //cboGiatri.Text = DataGridView.CurrentRow.Cells["giatrikm"].Value.ToString();
            float giatri = float.Parse(DataGridView.CurrentRow.Cells["giatrikm"].Value.ToString());
            cboGiatri.Text = (giatri * 100).ToString("0") + "%";
            cboTrangthai.Text = DataGridView.CurrentRow.Cells["trangthai"].Value.ToString();
            dateNgaybd.Value = DateTime.Parse(DataGridView.CurrentRow.Cells["ngaybd"].Value.ToString());
            dateNgaykt.Value = DateTime.Parse(DataGridView.CurrentRow.Cells["ngaykt"].Value.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMakm.Enabled = true;
            txtMakm.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKm.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakm.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMota.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMota.Focus();
                return;
            }
            if (txtTenct.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên CT khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenct.Focus();
                return;
            }
            if (cboGiatri.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboTrangthai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateNgaybd.Value > dateNgaykt.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((dateNgaykt.Value - dateNgaybd.Value).TotalDays > 365)
            {
                MessageBox.Show("Chương trình khuyến mãi không được dài quá 1 năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //sql = "SELECT COUNT(*) FROM ctkhuyenmai " +
            // "WHERE mactkm <> '" + txtMakm.Text.Trim() + "' " +
            // "AND ngaybd <= '" + dateNgaykt.Value.ToString("yyyy/MM/dd") + "' " +
            // "AND ngaykt >= '" + dateNgaybd.Value.ToString("yyyy/MM/dd") + "'";

            //if (Functions.CheckKey(sql))
            //{
            //    MessageBox.Show("Thời gian khuyến mãi này trùng với một chương trình khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            // Xử lý giá trị khuyến mãi (loại bỏ ký tự "%" và chuyển thành float)
            string giatrikmText = cboGiatri.Text.Trim().Replace("%", ""); // Loại bỏ "%"
            float giatrikm = float.Parse(giatrikmText) / 100;

            sql = "UPDATE CTkhuyenmai SET " +
            "tenctkm = N'" + txtTenct.Text.Trim() + "', " +
            "mota = N'" + txtMota.Text.Trim() + "', " +
            "giatrikm = '" + giatrikm.ToString().Replace(",", ".") + "', " +
            "trangthai = N'" + cboTrangthai.Text.Trim() + "', " +
            "ngaybd = '" + dateNgaybd.Value.ToString("yyyy-MM-dd") + "', " + 
            "ngaykt = '" + dateNgaykt.Value.ToString("yyyy-MM-dd") + "' " +
            "WHERE mactkm = '" + txtMakm.Text.Trim() + "'";

            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKm.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakm.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                sql = "SELECT * FROM Hoadonban WHERE Mactkm='" + txtMakm.Text + "'";
                if (Functions.CheckKey(sql))
                {
                    MessageBox.Show("Không thể xóa sự kiện này vì ràng buộc dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    sql = "DELETE CTKhuyenMai WHERE Mactkm='" + txtMakm.Text + "'";
                    Functions.RunSqlDel(sql);
                    Load_DataGridView();
                }
            }
            ResetValues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMakm.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã CT khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakm.Focus();
                return;
            }
            if (txtTenct.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên CT khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenct.Focus();
                return;
            }
            if (txtMota.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMota.Focus();
                return;
            }
            if (cboGiatri.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboTrangthai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateNgaybd.Value > dateNgaykt.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((dateNgaykt.Value - dateNgaybd.Value).TotalDays > 365)
            {
                MessageBox.Show("Chương trình khuyến mãi không được dài quá 1 năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //sql = "SELECT COUNT(*) FROM ctkhuyenmai " +
            // "WHERE ngaybd <= '" + dateNgaykt.Value.ToString("yyyy/MM/dd") + "' " +
            // "AND ngaykt >= '" + dateNgaybd.Value.ToString("yyyy/MM/dd") + "'";

            //if (Functions.CheckKey(sql))
            //{
            //    MessageBox.Show("Thời gian khuyến mãi này trùng với một chương trình khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            sql = "SELECT * FROM CTKhuyenMai WHERE Mactkm='" + txtMakm.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã CT khuyến mãi này đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakm.Focus();
                return;
            }
            else
            {
                // Xử lý giá trị khuyến mãi (loại bỏ ký tự "%" và chuyển thành float)
                string giatrikmText = cboGiatri.Text.Trim().Replace("%", ""); // Loại bỏ "%"
                float giatrikm = float.Parse(giatrikmText) / 100;
                //if (!float.TryParse(giatrikmText, out giatrikm))
                //{
                //    MessageBox.Show("Giá trị khuyến mãi không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                sql = "Insert into CTKhuyenMai (Mactkm, tenctkm, mota, giatrikm, trangthai, ngaybd, ngaykt) "
                + "values('" + txtMakm.Text.Trim()
                + "', N'" + txtTenct.Text.Trim()
                + "', N'" + txtMota.Text.Trim()
                + "', '" + giatrikm.ToString().Replace(",", ".")
                + "', N'" + cboTrangthai.Text + "', '"
                + dateNgaybd.Value.ToString("yyyy-MM-dd") + "', '"
                + dateNgaykt.Value.ToString("yyyy-MM-dd") + "')";

                Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
            }
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMakm.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMakm.Enabled = false;
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
            sql = "SELECT * FROM CtKhuyenMai WHERE Mactkm LIKE N'%" + txtTimkiem.Text.Trim() + "%' OR TenCTKM LIKE N'%" + txtTimkiem.Text.Trim() + "%'";
            tblTk = Functions.GetDataToTable(sql);
            if (tblTk.Rows.Count == 0)
            {
                //MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (DialogResult.OK == MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question))
                {
                    DataGridView.DataSource = tblKm;
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
    }
}
