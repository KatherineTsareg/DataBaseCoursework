using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Coursework
{
    class CSqlFunctions
    {
        //static private SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=C:\STUDY\3COURSE\1 СЕМЕСТР\DATABASE\COURSEWORK\COURSEWORK\LOCALDBAPPDATA.MDF; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        static private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LocalDBAppData.mdf;Integrated Security=True");
        
        static async public void Refresh(ListBox listBox)
        {
            await connection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Seller", connection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    listBox.Items.Add(Convert.ToString(sqlReader["Name"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
                connection.Close();
            }
        }
        static public void InsertIntoSellerTable(string name, DateTime BDDate, string phone, int cashbox, string gender, string photoPath)
        {
            try
            {
                connection.Open();
                SqlCommand commandInsert = new SqlCommand("INSERT INTO dbo.Seller (Name, Phone, Cashbox, Gender, Birthday) VALUES (@_name, @_phone, @_cashbox, @_gender, @_birthday)", connection);
                commandInsert.Parameters.AddWithValue("_name", name);
                commandInsert.Parameters.AddWithValue("_birthday", BDDate);
                commandInsert.Parameters.AddWithValue("_phone", phone);
                commandInsert.Parameters.AddWithValue("_cashbox", cashbox);
                commandInsert.Parameters.AddWithValue("_gender", gender);

                commandInsert.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            

            
        }
    }
}
