using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapCN.Class
{
    internal class Functions
    {
        public static SqlConnection Conn;
        public static string Connstring;

        public static void connect()
        {
            Connstring = "Data Source=hango1;Initial Catalog=NgotDessertByDiep;Integrated Security=True;Encrypt=False";

            if (Conn == null)
            {
                Conn = new SqlConnection(Connstring);
            }

            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
                //MessageBox.Show("Kết nối thành công");
            }
        }

        public static void disconnect()
        {
            if (Conn != null && Conn.State == ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose(); // Giải phóng tài nguyên
                Conn = null;
            }
        }

        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter();
            //Tạo đối tượng Command thực hiện câu lệnh SELECT 
            Mydata.SelectCommand = new SqlCommand();
            Mydata.SelectCommand.Connection = Class.Functions.Conn; //Kết nối CSDL
            Mydata.SelectCommand.CommandText = sql; //Gán câu lệnh SELECT
            DataTable table = new DataTable(); //Khai báo DataTable nhận dlieu trả về
            Mydata.Fill(table); //Thực hiện câu lệnh SELECT và đổ dlieu và bảng table
            return table;
        }

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Class.Functions.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static void RunSql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = Class.Functions.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Class.Functions.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmd.Dispose();
                cmd = null;
            }
        }


        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) &&
                (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }

        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;

            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường dữ liệu sẽ hiển thị lên combobox
        }

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Functions.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }

        public static (string, string) GetHashAndSaltByUsername(string username)
        {
            string sql = $"SELECT MatKhau, Salt FROM TaiKhoan WHERE TenDangNhap = N'{username}'";
            DataTable dt = GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                string hash = dt.Rows[0]["MatKhau"].ToString();
                string salt = dt.Rows[0]["Salt"].ToString();
                return (hash, salt);
            }
            else
            {
                return (null, null);
            }
        }
    }
}

