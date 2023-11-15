using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperExpress
{
    public class Conexion
    {
        public SqlConnection connect = new SqlConnection();
        public Conexion(string user, string pass)
        {
            try
            {
                connect = new SqlConnection("Server = SIS18\\SQLSERVER2019; Database = SuperExpress2; UID = " + user + "; PWD = " + pass);
                connect.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("no se conecto al servidor");
            }
        }

    }
}
//camello se la come
