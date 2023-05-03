using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace Crucigrama
{
    public partial class Form1 : Form
    {
        public List<Palabra> palabras = new List<Palabra>();
        public int contador_turnos;
        public int correctas;
        public Boolean turno = true;
        public Jugador j1, j2;
        public Tabla tabla;
        int segundos = 0;
        public Form1(Jugador jug1, Jugador jug2, Tabla tabl)
        {
            this.contador_turnos = 0;
            this.tabla = tabl;
            this.j1 = jug1;
            this.j2 = jug2;
            InitializeComponent();
            this.correctas = 0;
            this.crearPalabras();
            this.configurarEvento();
            this.escribirCorrectas();
            this.configurar();
        }

        public void configurarEvento()
        {
            foreach (Control c in panel_contenedor.Controls)
            {
                if (c is TextBox)
                {
                    c.TextChanged += new EventHandler(textboxes_TextChanged);
                }
            }
        }

        public void configurar()
        {
            Config myConf = this.readJson();

            if (myConf != null)
            {
                List<Palabra> p_v = this.palabras.FindAll(el => el.pos.Equals("v"));
                List<Palabra> p_h = this.palabras.FindAll(el => el.pos.Equals("h"));

                foreach (Vertical vert in myConf.verticales)
                {
                    foreach (Palabra pal in p_v)
                    {
                        if (pal.id == Convert.ToInt32(vert.id))
                        {
                            pal.texto = vert.val;
                        }
                    }
                }

                foreach (Horizontal hori in myConf.horizontales)
                {
                    foreach (Palabra pal in p_h)
                    {
                        if (pal.id == Convert.ToInt32(hori.id))
                        {
                            pal.texto = hori.val;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Null");
            }
        }

        Config readJson()
        {
            using (StreamReader r = new StreamReader("config.json"))
            {
                string json = r.ReadToEnd();
                Config conf = JsonConvert.DeserializeObject<Config>(json);
                return conf;
            }
            return null;
        }

        public void crearPalabras()
        {
            this.palabras.Add(new Palabra(1, "h", "rana", new List<TextBox> { txt1, txt2, txt3, txt4 }));
            this.palabras.Add(new Palabra(1, "v", "aguila", new List<TextBox> { txt2, txt5, txt6, txt7, txt8, txt9 }));
            this.palabras.Add(new Palabra(2, "h", "buitre", new List<TextBox> { txt10, txt6, txt11, txt12, txt13, txt14 }));
            this.palabras.Add(new Palabra(2, "v", "babosa", new List<TextBox> { txt17, txt18, txt19, txt20, txt21, txt22 }));
        }


        public void escribirCorrectas()
        {
            lbl_correctas.Text = this.correctas.ToString();
            if (this.turno)
            {
                lbl_turno.Text = j1.nombre;
                picture.Image = Image.FromFile(j1.imagen);
            }
            else
            {
                lbl_turno.Text = j2.nombre;
                picture.Image = Image.FromFile(j2.imagen);
            }
            lbl_llenas.Text = this.contador_turnos.ToString();
        }
        public void analizar()
        {
            foreach (Palabra palabra in palabras)
            {
                if (palabra.estaLlenaCorrectamente() && palabra.llena == false)
                {
                    palabra.llena = true;
                    this.correctas++;
                    //this.turno = !this.turno;
                }
            }
            this.escribirCorrectas();
        }

        void textboxes_TextChanged(object sender, EventArgs e)
        {
            int anterior = this.correctas;
            this.analizar();
            if (this.correctas != anterior)
            {
                MessageBox.Show("completado");
            }
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.segundos++;
            if (this.segundos % 30 == 0)
            {
                MessageBox.Show("tiempo acabado...");
                this.turno = !this.turno;
                this.contador_turnos++;
                this.escribirCorrectas();
            }
            lbl_tiempo.Text = this.segundos.ToString();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            this.turno = !this.turno;
            this.contador_turnos++;
            this.escribirCorrectas();
        }
    }
}