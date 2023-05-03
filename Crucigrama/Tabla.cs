using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucigrama
{

    public class Partida
    {
        int id;
        public Jugador jugador1, jugador2;
        int punteo;
        public Partida(int id, Jugador a, Jugador b)
        {
            this.id = id;
            this.jugador1 = a;
            this.jugador2 = b;
        }
    }
    public class Tabla
    {
        List<Partida> partidas;
    }
}
