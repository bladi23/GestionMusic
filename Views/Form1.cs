using GestionMusic.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMusic
{
    public partial class frm_principal : Form
    {
        AlbumController albumController = new AlbumController();
        int album_id;

        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            CargarListaAlbumes();
        }

        private void CargarListaAlbumes()
        {
            lst_album.DataSource = albumController.Todos();
            lst_album.DisplayMember = "titulo";
            lst_album.ValueMember = "album_id";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            albumController.Guardar(txt_titulo.Text, txt_genero.Text, int.Parse(txt_año.Text), txt_discografia.Text);
            CargarListaAlbumes();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            album_id = (int)lst_album.SelectedValue;
            albumController.Editar(album_id, txt_titulo.Text, txt_genero.Text, int.Parse(txt_año.Text), txt_discografia.Text);
            CargarListaAlbumes();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            album_id = (int)lst_album.SelectedValue;
            albumController.Eliminar(album_id);
            CargarListaAlbumes();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_titulo.Clear();
            txt_genero.Clear();
            txt_año.Clear();
            txt_discografia.Clear();
        }

        
    }
}
