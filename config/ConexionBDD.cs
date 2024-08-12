using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tienda2.config
{
    internal class ConexionBDD
    {

        private SqlConnection con = new SqlConnection("Server=DESKTOP-0OS6OUS;Database=Cuarto;User Id=sa" +
            ",Password=SebastianCedillo9;");

        public SqlConnection AbrirConexion()
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        public SqlConnection CerrarConexion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }




    }
}
