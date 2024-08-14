using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias de la conexion
using System.Data.SqlClient;
using System.Data;
using GestionMusic.Config;

namespace GestionMusic.Models
{
    internal class AlbumModel
    {
            private ConexionBDD conexion = new ConexionBDD();

        //lector Sql data reader
        private SqlDataReader leer;
        DataTable listaAlbum = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Todos()
        { comando.Connection = conexion.AbrirConexion() ;
            comando.CommandText = "select * from albumes";
            leer = comando.ExecuteReader();
            listaAlbum.Load(leer);
            conexion.CerrarConexion();
            return listaAlbum; }

    }
}
