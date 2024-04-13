using lab8_student.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_student.Controller
{
    class LoginController
    {
        private static CanBoModel.CanBo canBo = new CanBoModel.CanBo();
        public SqlDataReader Login(string username, string password)
        {
            try
            {
                Database.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from CanBo where MaCB = @username and MatKhau = @password", Database.connection);
                cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.Int, 10)).Value = username;
                cmd.Parameters.Add(new SqlParameter("password", SqlDbType.Int)).Value = password;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    canBo._maCB = reader.GetInt32(reader.GetOrdinal("MaCB"));
                    canBo._matKhau = reader.GetInt32(reader.GetOrdinal("MatKhau"));

                }
                return reader;
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
