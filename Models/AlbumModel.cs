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
        public void Guardar(string titulo, string genero, int añoLanzamiento, string discografica)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Albumes (titulo, genero, año_lanzamiento, discografica) VALUES (@titulo, @genero, @añoLanzamiento, @discografica)";
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@añoLanzamiento", añoLanzamiento);
            comando.Parameters.AddWithValue("@discografica", discografica);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar(int album_id, string titulo, string genero, int añoLanzamiento, string discografica)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Albumes SET titulo = @titulo, genero = @genero, año_lanzamiento = @añoLanzamiento, discografica = @discografica WHERE album_id = @album_id";
            comando.Parameters.AddWithValue("@album_id", album_id);
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@añoLanzamiento", añoLanzamiento);
            comando.Parameters.AddWithValue("@discografica", discografica);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int album_id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM Albumes WHERE album_id = @album_id";
            comando.Parameters.AddWithValue("@album_id", album_id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
