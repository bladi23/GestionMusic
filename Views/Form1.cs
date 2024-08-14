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

        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            lst_album.DataSource = albumController.Todos();
            lst_album.DisplayMember = "titulo";
            lst_album.DisplayMember = "genero";
            
            lst_album.DisplayMember = "discografia";
            lst_album.ValueMember = "album_id";

        }
    }
}
