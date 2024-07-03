using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    // TetrisPieza no implementaba la Clase Abstracta
    public class TetrisPieza : TetrisElementoBase
    {
        public TetrisPieza(string nombre) : base(nombre)
        {

        }
    }
}
