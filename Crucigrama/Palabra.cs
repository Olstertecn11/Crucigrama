using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucigrama
{
    public class Palabra
    {
        public int id;
        public string pos;
        public string texto;
        public List<TextBox> cajas;
        public Boolean llena;
        public Palabra(int id, string pos, string c, List<TextBox> arr)
        {
            this.pos = pos;
            this.id = id;
            this.texto = c;
            this.cajas = new List<TextBox>();
            this.cajas = arr;
            this.llena = false;
        }

        public Boolean estaLlenaCorrectamente()
        {
            string linea = "";
            foreach (TextBox txt in cajas) { 
                linea += txt.Text;
            }
            return linea == this.texto;
        }
    }
}
