using Entities.Interfaces;

namespace Entities
{
    public abstract class TetrisElementoBase : ITetrisElementoBase,
                                              ITetrisMovimiento
    {
        protected TetrisElementoBase(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; private set; }

        string _posicion = "Arriba"; //Valores: Arriba, Derecha, Abajo, Izquierda

        public string Posicion
        {
            get
            {
                return _posicion;
            }
        }

        public void MoverAIzquierda()
        {

            switch (Posicion)
            {
                case "Arriba":
                    _posicion = "Izquierda";
                    return;
                case "Derecha":
                    _posicion = "Arriba";
                    return;
                case "Abajo":
                    _posicion = "Derecha";
                    return;
                case "Izquierda":
                    _posicion = "Abajo";
                    return;
            }
        }

        public void MoverADerecha()
        {

            switch (Posicion)
            {
                case "Arriba":
                    _posicion = "Derecha";
                    return;
                case "Derecha":
                    _posicion = "Abajo";
                    return;
                case "Abajo":
                    _posicion = "Izquierda";
                    return;
                case "Izquierda":
                    _posicion = "Arriba";
                    return;
            }

        }
    }
}
