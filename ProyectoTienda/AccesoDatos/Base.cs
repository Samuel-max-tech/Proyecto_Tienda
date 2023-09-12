using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class Base
    {
            MySqlConnection con;
            public Base()
            {
                con = new MySqlConnection("server=localhost; user=root; password=;" +
                    "database=Tienda");
            }
            public string Comando(string q)
            {
                try
                {
                    MySqlCommand i = new MySqlCommand(q, con);
                    con.Open();
                    i.ExecuteNonQuery();
                    con.Close();
                    return "Correcto";
                }
                catch (Exception ex)
                {
                    con.Close();
                    return ex.Message;
                }
            }
            public DataSet Mostrar(string q, string t)
            {
                DataSet ds = new DataSet();
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(q, con);
                    con.Open();
                    da.Fill(ds, t);
                    con.Close();
                    return ds;
                }
                catch (Exception)
                {
                    con.Close();
                    return ds;
                }
            }
    }
}
