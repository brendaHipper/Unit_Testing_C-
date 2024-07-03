using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface ITetrisTablero
    {
        List<TetrisPieza> Piezas { get; }
        TetrisPieza ObtenerProximaPieza();
    }
}
