using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDb
{
    class Program
    {
        static void Main(string[] args)
        {
            //string cs = "Data Source=LAPTOP-S7I6BAFA\\SQLEXPRESS ;Initial Catalog=sample;Integrated Security=True;";
            ////SqlConnection con = new SqlConnection();
            ////con.ConnectionString = cs;
            //SqlConnection con = new SqlConnection(cs);
            ////SqlCommand cmd = new SqlCommand();
            ////cmd.CommandText = " SELECT * FROM Customers";
            ////cmd.Connection = con;
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customers",con);
            //con.Open();
            //SqlDataReader rdr=cmd.ExecuteReader();
            //while (rdr.Read())
            //{
            //    Console.WriteLine(rdr[0] + "   " + rdr[1] + "     " + rdr[2] + "");
            //}
            //con.Close();
            CrudEmployee ce = new CrudEmployee();
            ce.Readdata();
            Console.ReadLine();

        }
    }
}
