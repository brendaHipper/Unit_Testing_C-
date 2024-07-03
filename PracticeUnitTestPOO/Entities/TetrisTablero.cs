using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TetrisTablero: ITetrisTablero
    {
        public List<TetrisPieza> Piezas { get; private set; }

        public TetrisTablero()
        {
            Piezas = new List<TetrisPieza>();
        }

        public TetrisPieza ObtenerProximaPieza()
        {
            var piezasNombres = new string[] { "PiezaT, PiezaJ, PiezaL, PiezaO, PiezaI" };

            var random = new Random();

            int randomIndex = random.Next(piezasNombres.Length);

            return new TetrisPieza(piezasNombres[randomIndex]);
        }
    }
}
