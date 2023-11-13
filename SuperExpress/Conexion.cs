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
                connect = new SqlConnection("Server = OWEN_LAPTOP; Database = SuperExpress2; UID = " + user + "; PWD = " + pass);
                connect.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("no se conecto al servidor");
            }
        }

    }
}
