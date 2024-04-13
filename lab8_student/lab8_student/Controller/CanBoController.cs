using lab8_student.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_student
{
    class CanBoController
    {
        
        public CanBoModel.CanBo GetCanBoByMaCB(string maCB)
        {
            CanBoModel.CanBo canBo = new CanBoModel.CanBo();

            try
            {

                Database.OpenConnection();
                string query = "SELECT MaCB, MatKhau from CanBo where MaCB = @MaCB";
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                cmd.Parameters.AddWithValue("@MaCB", maCB);

                SqlDataAdapter adapter = new SqlDataAdapter();  
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0 )
                {
                    canBo._maCB = Convert.ToInt32(dataTable.Rows[0]["MaCB"]);
                    canBo._matKhau = Convert.ToInt32(dataTable.Rows[0]["MatKhau"]);
                }    

                Database.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return canBo;
        }
    }
}
