

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

public class DataTransfer
{
    // Tạo 1 thể hiện cho DataTransfer -> Chúng ta sẽ không phải khởi tạo class khi dùng
    private static DataTransfer _instance;

    // Đóng gói dữ liệu
    public static DataTransfer Instance
    {
        get
        {
            // Khi gọi class ra dùng . _instance mặc định là Nothing
            // Chúng ta phải Khởi tạo cho _instance thì mới có thể dùng được 
            if (_instance == null)
                _instance = new DataTransfer();
            return _instance;
        }
        // Chúng ta cho đối tượng chỉ được phép gọi ra dùng chứ không được phép thay đổi giá trị trong đó
        // Muốn làm vậy thì thì phải thêm Private phía trước Set
        private set
        {
            _instance = value;
        }
    }

    // Muốn kết nối được tới MySql thì chúng ta phải có 1 chuỗi kết nối
    // Trong đó :
    // "userid" : Tên đăng nhập khi tạo Mysql
    // "password" : Mật khẩu khi tạo Mysql
    // "database" : Tên Database muốn sử dụng
    private string ConnectString = "SERVER=localhost;DATABASE=shop_dathao;UID=root;PASSWORD=trung;port=3306;";

    /// <summary>
    ///  Thực thi 1 truy vấn hay cập nhật nào đó hoặc Lấy dữ liệu để đưa vào DataTable
    ///   </summary>
    ///   <param name="Query">Câu lệnh truy vấn trong Mysql</param>
    ///   <param name="DanhSachParameter">Danh sách các parameter truyền vào để tránh lỗi Mysql Injection khi cập nhật hoặc thêm dữ liệu</param>
    ///   <returns></returns>
    public DataTable ExecuteQuerry(string Query, MySqlParameter[] DanhSachParameter = null)
    {
        // Khởi tạo đối tượng datatable 
        DataTable data = new DataTable();

        // Khởi tạo 1 đối tượng kết nối
        // Và lấy đường dẫn tới CSDL
        using (MySqlConnection Connect = new MySqlConnection(ConnectString))
        {

            // Mở kết nối
            Connect.Open();

            // thực thi lệnh trong mysql
            MySqlCommand Command = new MySqlCommand();
            Command = new MySqlCommand(Query, Connect);

            // Tránh lỗi Mysql injection
            if (DanhSachParameter != null)
                Command.Parameters.AddRange(DanhSachParameter);

            // Tạo đối tượng Adater là cầu nối đọc dữ liệu giữa DataSet và DataSource
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            Adapter.SelectCommand = Command;

            // Fill dữ liệu vào datatable
            Adapter.Fill(data);

            // Đóng kết nối
            Connect.Close();

            return data;
        }
    }

    public DataTable ExecuteQuerryPro(string ProceduresFunc)
    {
        // Khởi tạo đối tượng datatable 
        DataTable data = new DataTable();

        // Khởi tạo 1 đối tượng kết nối
        // Và lấy đường dẫn tới CSDL
        using (MySqlConnection Connect = new MySqlConnection(ConnectString))
        {
            // Mở kết nối
            Connect.Open();
            // thực thi lệnh trong mysql
            MySqlCommand Command = new MySqlCommand(ProceduresFunc, Connect);

            // Tạo đối tượng Adater là cầu nối đọc dữ liệu giữa DataSet và DataSource
            MySqlDataAdapter Adapter = new MySqlDataAdapter(Command);

            // Fill dữ liệu vào datatable
            Adapter.Fill(data);

            // Đóng kết nối
            Connect.Close();

            return data;
        }
    }


    /// <summary>
    /// Dược dùng khi thực hiện các câu lệnh Đếm một cái gì đó Hoặc kiểm tra tồn tại - kiểm tra trùng 
    /// vd: SELECT count(*) FROM Something WHERE Conditional 
    /// </summary>
    /// <param name="Query">Câu lệnh Đếm hoặc Kiểm tra tồn tại</param>
    /// <param name="DanhSachParameter">Danh sách các parameter truyền vào để tránh lỗi Mysql Injection khi cập nhật hoặc thêm dữ liệu</param>
    /// <returns></returns>
    public int ExecuteScalar(string Query, MySqlParameter[] DanhSachParameter = null)
    {
        int data;
        // Khởi tạo 1 đối tượng kết nối
        // Và lấy đường dẫn tới CSDL
        using (MySqlConnection Connect = new MySqlConnection(ConnectString))
        {

            // Mở kết nối
            Connect.Open();

            // thực thi lệnh trong mysql
            MySqlCommand Command = new MySqlCommand(Query, Connect);

            // Tránh lỗi Mysql injection
            if (DanhSachParameter != null)
               Command.Parameters.AddRange(DanhSachParameter);

            // Trả về số dòng thực hiện câu lệnh
            data = Convert.ToInt32(Command.ExecuteScalar());

            // Đóng kết nối
            Connect.Close();
            return data;
        }
    }

    /// <summary>
    /// Thực hiện các câu lệnh Insert - Update - Delete
    /// Trả về số dòng thực hiện được
    /// </summary>
    /// <param name="Query">Câu lệnh cần thực hiện</param>
    /// <param name="DanhSachParameter">Danh sách các parameter truyền vào để tránh lỗi Mysql Injection khi cập nhật hoặc thêm dữ liệu</param>
    /// <returns></returns>
    public int ExecuteNonQuerry(string Query, MySqlParameter[] DanhSachParameter = null)
    {
        int data;

        // Khởi tạo 1 đối tượng kết nối
        // Và lấy đường dẫn tới CSDL
        using (MySqlConnection Connect = new MySqlConnection(ConnectString))
        {

            // Mở kết nối
            Connect.Open();

            // thực thi lệnh trong mysql
            MySqlCommand Command = new MySqlCommand();
            Command = new MySqlCommand(Query, Connect);

            // Tránh lỗi Mysql injection
            if (DanhSachParameter != null)
                Command.Parameters.AddRange(DanhSachParameter);
            // Thực thi câu lệnh Sql và trả về số dòng được thực hiện
            data = Command.ExecuteNonQuery();

            // Đóng kết nối
            Connect.Close();

            return data;
        }
    }

    public int ExecuteNonQuerrypRO(string Query)
    {
        int data;

        // Khởi tạo 1 đối tượng kết nối
        // Và lấy đường dẫn tới CSDL
        using (MySqlConnection Connect = new MySqlConnection(ConnectString))
        {

            // Mở kết nối
            Connect.Open();

            // thực thi lệnh trong mysql
            MySqlCommand Command = new MySqlCommand();
            Command = new MySqlCommand(Query, Connect);
            // Thực thi câu lệnh Sql và trả về số dòng được thực hiện
            data = Command.ExecuteNonQuery();

            // Đóng kết nối
            Connect.Close();

            return data;
        }
    }
}
