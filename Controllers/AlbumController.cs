using GestionMusic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace GestionMusic.Controllers
{
    internal class AlbumController
    {
        private AlbumModel albumModel = new AlbumModel();

        public DataTable Todos()
        {
            return albumModel.Todos();
        }

        public void Guardar(string titulo, string genero, int añoLanzamiento, string discografica)
        {
            albumModel.Guardar(titulo, genero, añoLanzamiento, discografica);
        }

        public void Editar(int album_id, string titulo, string genero, int añoLanzamiento, string discografica)
        {
            albumModel.Editar(album_id, titulo, genero, añoLanzamiento, discografica);
        }

        public void Eliminar(int album_id)
        {
            albumModel.Eliminar(album_id);
        }
    }
}
