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
    public partial class Menu : Form
    {
        public Jugador jugador1;
        public Jugador jugador2;
        public Tabla tabla;
        public Menu()
        {
            this.jugador1 = new Jugador("", "");
            this.jugador2 = new Jugador("", "");
            InitializeComponent();
        }

        private void btn_partida_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 partida = new Form1(jugador1, jugador2, tabla);
            partida.ShowDialog();
            this.Visible = true;
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Configuracion configuracion = new Configuracion();
            configuracion.pasarJugadores(jugador1, jugador2);
            configuracion.ShowDialog();
            this.jugador1 = configuracion.j1;
            this.jugador2 = configuracion.j2;
            this.Visible = true;
        }
    }
}
