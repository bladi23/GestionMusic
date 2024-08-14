using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace GestionMusic.Config
{
   class ConexionBDD
    {
        string cadena = "Server=BLADIMIR-DESKTO\\SQLEXPRESS; Database=MusicaBDD; Integrated Security=true";
        private SqlConnection conex = new SqlConnection("Server=BLADIMIR-DESKTO\\SQLEXPRESS; Database=MusicaBDD; Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            if (conex.State == ConnectionState.Closed)
                conex.Open();

            return conex;
        }

        public SqlConnection CerrarConexion()
        {
            if (conex.State == ConnectionState.Open)
                conex.Close();
            return conex;
        }
    }
}