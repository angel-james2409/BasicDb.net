using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BasicDb
{
    class CrudEmployee

    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public SqlConnection EstablishConnection()
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }
        public Boolean Readdata()
        {
            bool successflag = false;
            con = EstablishConnection();
            cmd = new SqlCommand("SELECT Fullname,Empcode,Mobile,Position FROM Employe", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + "   " + rdr[1] + "  " + rdr[2] + "    " + rdr[3]);
                successflag = true;
            }
            con.Close();
            return successflag;
        }

    }
}
