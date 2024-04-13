using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_student
{
    class Database
    {
        public static SqlConnection connection;
        public static Boolean OpenConnection()
        {
            try
            {
                connection = new SqlConnection("Server=MINHIFY\\MYB2014996;database=SinhVien;Integrated Security=true");
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

            return true;

        }
        public static Boolean CloseConnection()
        {
            connection.Close();
            return true;
        }
        
    }
  
}
