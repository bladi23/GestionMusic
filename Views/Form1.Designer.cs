namespace GestionMusic
{
    partial class frm_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.lst_album = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.txt_discografia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cancelar2 = new System.Windows.Forms.Button();
            this.btn_eliminar2 = new System.Windows.Forms.Button();
            this.btn_editar2 = new System.Windows.Forms.Button();
            this.txt_nacionalidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_guardar2 = new System.Windows.Forms.Button();
            this.Album = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(60, 400);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DE MUSICA";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(71, 140);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(100, 20);
            this.txt_titulo.TabIndex = 2;
            // 
            // lst_album
            // 
            this.lst_album.FormattingEnabled = true;
            this.lst_album.Location = new System.Drawing.Point(187, 121);
            this.lst_album.Name = "lst_album";
            this.lst_album.Size = new System.Drawing.Size(219, 251);
            this.lst_album.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulo de Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genero";
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(71, 214);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(100, 20);
            this.txt_genero.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año Lanzamiento";
            // 
            // txt_año
            // 
            this.txt_año.Location = new System.Drawing.Point(71, 267);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(100, 20);
            this.txt_año.TabIndex = 8;
            // 
            // txt_discografia
            // 
            this.txt_discografia.Location = new System.Drawing.Point(71, 330);
            this.txt_discografia.Name = "txt_discografia";
            this.txt_discografia.Size = new System.Drawing.Size(100, 20);
            this.txt_discografia.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Discografia";
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(157, 400);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 11;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(260, 400);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(360, 400);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar ";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar2
            // 
            this.btn_cancelar2.Location = new System.Drawing.Point(766, 400);
            this.btn_cancelar2.Name = "btn_cancelar2";
            this.btn_cancelar2.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar2.TabIndex = 26;
            this.btn_cancelar2.Text = "Cancelar ";
            this.btn_cancelar2.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar2
            // 
            this.btn_eliminar2.Location = new System.Drawing.Point(666, 400);
            this.btn_eliminar2.Name = "btn_eliminar2";
            this.btn_eliminar2.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar2.TabIndex = 25;
            this.btn_eliminar2.Text = "Eliminar";
            this.btn_eliminar2.UseVisualStyleBackColor = true;
            // 
            // btn_editar2
            // 
            this.btn_editar2.Location = new System.Drawing.Point(563, 400);
            this.btn_editar2.Name = "btn_editar2";
            this.btn_editar2.Size = new System.Drawing.Size(75, 23);
            this.btn_editar2.TabIndex = 24;
            this.btn_editar2.Text = "Editar";
            this.btn_editar2.UseVisualStyleBackColor = true;
            // 
            // txt_nacionalidad
            // 
            this.txt_nacionalidad.Location = new System.Drawing.Point(477, 330);
            this.txt_nacionalidad.Name = "txt_nacionalidad";
            this.txt_nacionalidad.Size = new System.Drawing.Size(100, 20);
            this.txt_nacionalidad.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nacionalidad";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(477, 267);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(477, 214);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nombre";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(593, 121);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(219, 251);
            this.listBox2.TabIndex = 16;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(477, 140);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 15;
            // 
            // btn_guardar2
            // 
            this.btn_guardar2.Location = new System.Drawing.Point(466, 400);
            this.btn_guardar2.Name = "btn_guardar2";
            this.btn_guardar2.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar2.TabIndex = 14;
            this.btn_guardar2.Text = "Guardar";
            this.btn_guardar2.UseVisualStyleBackColor = true;
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album.Location = new System.Drawing.Point(184, 72);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(70, 20);
            this.Album.TabIndex = 27;
            this.Album.Text = "ALBUM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(645, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "ARTISTA";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.btn_cancelar2);
            this.Controls.Add(this.btn_eliminar2);
            this.Controls.Add(this.btn_editar2);
            this.Controls.Add(this.txt_nacionalidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_guardar2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txt_discografia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_año);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_genero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_album);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_guardar);
            this.Name = "frm_principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.ListBox lst_album;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.TextBox txt_discografia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cancelar2;
        private System.Windows.Forms.Button btn_eliminar2;
        private System.Windows.Forms.Button btn_editar2;
        private System.Windows.Forms.TextBox txt_nacionalidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_guardar2;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.Label label11;
    }
}

