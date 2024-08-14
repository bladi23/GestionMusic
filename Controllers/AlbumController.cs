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
            DataTable listaAlbum = new DataTable();
            listaAlbum = albumModel.Todos();
            return listaAlbum;
        }
    }
}
