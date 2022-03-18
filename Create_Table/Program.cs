using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=MEGANE\\ALDYAHMADFAUZI;database=ProdiTI;Integrated Security = TRUE");

                con.Open();

                SqlCommand cm = new SqlCommand("create table MahasiswaTI(NIM char(12) not null primary key," +
                    "Nama varchar(50), Alamat varchar(255), Jenis_kelamin char(1))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat ");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("EROR.." + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
