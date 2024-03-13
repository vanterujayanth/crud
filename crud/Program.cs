using System;
using System.Data.SqlClient;
namespace crud
{
    class Program
    {
        public static void Main(string[] args) 
        {
            String CONNECTION = "server=DESKTOP-2GMEK14\\SQLEXPRESS01;initial catalog=payroll;integrated security=SSPI";

            //string insertvalue = "insert into employeepayroll ";
            SqlConnection conn = new SqlConnection(CONNECTION);
            conn.Open();
            Console.WriteLine("sucefully!");
            //SqlCommand cmd = new SqlCommand("", conn);
            ////cmd.ExecuteNonQuery();

            //SqlDataReader r = cmd.ExecuteReader();
            //while (r.Read())
            //{
            //    Console.WriteLine(r["id"]);
            //}



        }
    }
}
