using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucigrama
{
    public class Jugador
    {
        public string nombre;
        public string imagen;

        public Jugador(string nombre, string imagen)
        {
            this.nombre = nombre;
            this.imagen = imagen;
        }
    }
}
