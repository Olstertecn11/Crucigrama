﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crucigrama
{
    public partial class Configuracion : Form
    {
        public Jugador j1, j2;
        public Configuracion()
        {
            InitializeComponent();
        }

        public void pasarJugadores(Jugador j1, Jugador j2)
        {
            this.j1 = j1;
            this.j2 = j2;
        }
        private void btn_pic_1_Click(object sender, EventArgs e)
        {
            this.seleccionarImagen(pic_1, 1);
        }

        public void seleccionarImagen(PictureBox pic, int id)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string img = ofd.FileName;
                pic.Image = Image.FromFile(img);
                if (id == 2) this.j2.imagen = img;
                if (id == 1)this.j1.imagen = img;
            }
        }

        private void btn_pic_2_Click(object sender, EventArgs e)
        {
            this.seleccionarImagen(pic_2, 2);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.j1.nombre = txt_j1.Text;
            this.j2.nombre = txt_j2.Text;
            MessageBox.Show("Configuracion Guardada!");
            this.Close();
        }
    }
}
