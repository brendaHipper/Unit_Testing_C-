using Entities.Interfaces;
using Entities;

namespace TestProjectPOO
{
    public class UnitTestClass
    {
        //Escenario: Juego del Tetris
        //---------------------------------------------------------------------
        //  1- Contiene Piezas (5 piezas en total)
        //  2- Piezas puden ser: PiezaT, PiezaJ, PiezaL, PiezaO, PiezaI
        //  3- Las piezas pueden moverse a izquierda o derecha
        //  4- Las piezas tiene una posicion: Arriba, Derecha, Abajo, Izquierda
        //  5- Las piezas se encuentra dentro de un tablero

        [Fact]
        public void Test01_Teoria_Pregunta1()
        {
            var respuesta0 = string.Empty;
            var respuesta1 = ".NET Framework es la versión más reciente de.NET.";
            var respuesta2 = ".NET Core/NET 8 no puede ejecutarse en sistemas operativos Linux.";
            var respuesta3 = ".NET Core/NET 8 puede ejecutarse en diferentes sistemas operativos.";
            var respuesta4 = ".NET Framework admite el desarrollo de aplicaciones de Windows solamente.";

            var respuestaVerdadera = respuesta3;

            Assert.NotNull(respuestaVerdadera);
        }


        [Fact]
        public void Test02_Teoria_Pregunta2()
        {

            //Describa que es un Assembly (Emsamblado en .NET)
            var respuesta = "Assembly es una unidad de construcción fundamental de .NET que posee una colección de recursos y de tipos compilados para funcionar en conjunto y formar una unidad logica de funcionalidad. Las funcionalidades de un Assembly son las de contenedor de codigo MSIL, funciona como unidad de implementacion cuando se inicia una aplicacion, posee el control de versionado, reutilizacion, activacion y permisos de seguridad. El formato del Assembly es un archivo binario que describe y contiene programas. Puede adoptar la forma de ua archivo ejecutable .exe o de biblioteca de vinculos dinamicos .dll";

            Assert.NotNull(respuesta);
        }


        [Fact]
        public void Test03_POO_Objetos()
        {
            var piezaT = new TetrisPieza("PiezaT");


            //Test
            Assert.NotNull(piezaT);
            Assert.Equal("PiezaT", piezaT.Nombre);
            Assert.Equal("Arriba", piezaT.Posicion);
        }


        /// <summary>
        /// Agregar al tablero 100
        /// </summary>
        [Fact]
        public void Test04_POO_ObjetosEnlazados()
        {
            var tablero = new TetrisTablero();

            //Alumno
            //Itere esta linea para agregar al tablero 100 pieza
            for (int i = 0; i < 100; i++)
            {
                tablero.Piezas.Add(tablero.ObtenerProximaPieza());
            }


            //Test
            Assert.NotNull(tablero);
            Assert.Equal(100, tablero.Piezas.Count);
        }


        [Fact]
        public void Test05_POO_Interfaces()
        {
            var tablero = new TetrisTablero();

            //Alumno
            //Itere esta linea para agregar 100 piezas al tablero
            for (int i = 0; i < 100; i++)
            {
                tablero.Piezas.Add(tablero.ObtenerProximaPieza());
            }

            //Obtenga una pieza, la pieza 10
            var pieza10 = (ITetrisElementoBase)tablero.Piezas[9];


            //Test
            //Assert.IsType<ITetrisTablero>(tablero);
            //Assert.IsType<ITetrisElementoBase>(pieza10);
            //Assert.Equal(100, tablero.Piezas.Count);

            Assert.NotNull((ITetrisTablero)tablero);
            Assert.NotNull((ITetrisElementoBase)pieza10);
            Assert.Equal(100, tablero.Piezas.Count);

            // observaciones David
            Assert.NotNull(tablero);
            Assert.NotNull(pieza10);
            Assert.Equal(100, tablero.Piezas.Count);

            Assert.IsAssignableFrom<ITetrisTablero>(tablero);
            Assert.IsAssignableFrom<ITetrisElementoBase>(pieza10);
            //Nunca va a pasar el assert xq tablero no es del tipo interfaz
            //Assert.IsType<ITetrisTablero>((ITetrisTablero)tablero);
            //Para poder usar el is type debo pasarle la clase TetrisTablero
            Assert.IsType<TetrisTablero>(tablero);
            //Assert.IsType<ITetrisElementoBase>((ITetrisElementoBase)pieza10);
            Assert.Equal(100, tablero.Piezas.Count);
        }



        /// <summary>
        /// Agregar una pieza en el tablero pero antes dejarla en posicion "abajo"
        /// </summary>
        [Fact]
        public void Test06_POO_Metodos()
        {
            var tablero = new TetrisTablero();

            //Alumno
            //Itere esta linea para agregar 100 piezas al tablero
            //tablero.Piezas.Add(tablero.ObtenerProximaPieza());
            for (int i = 0; i < 100; i++)
            {
                tablero.Piezas.Add(tablero.ObtenerProximaPieza());
            }


            //Alumno: Cree la proxima pieza... 
            var proximaPieza = tablero.ObtenerProximaPieza();
            //...

            // arriba crea la pieza y en esta linea agrega la pieza creada arriba (Agrega la pieza 101)
            tablero.Piezas.Add(proximaPieza);
            // Como no tengo el método moverAbajo(), debo repetir 2 veces el método MoverADerecha(); para rotar la pieza
            proximaPieza.MoverADerecha();
            proximaPieza.MoverADerecha();


            //Test
            Assert.Equal("Abajo", proximaPieza.Posicion);
            Assert.Equal(101, tablero.Piezas.Count);
            Assert.Equal("Arriba", tablero.Piezas[0].Posicion);
            Assert.Equal("Arriba", tablero.Piezas[99].Posicion);
            Assert.Equal("Abajo", tablero.Piezas[100].Posicion);
        }


        [Fact]
        public void Test07_Fechas_Cadenas()
        {
            var parcial1 = new DateTime(2024, 4, 30, 14, 10, 00);

            // Alumno
            var parcial1_anio = parcial1.Year;
            var parcial1_fechaconhora = parcial1.ToString("dd/MM/yy HH:mm:ss");

            var cultureInfo = new System.Globalization.CultureInfo("es-ES");
            var parcial1_diaSemana = cultureInfo.TextInfo.ToTitleCase(cultureInfo.DateTimeFormat.GetDayName(parcial1.DayOfWeek));
            var parcial1_mes = cultureInfo.DateTimeFormat.GetMonthName(parcial1.Month).ToUpper();

            var parcial1_dia_int = parcial1.Day;

            var parcial1_frase = $"Hoy es {parcial1_diaSemana}, {parcial1_dia_int} de {parcial1_mes} de {parcial1_anio}";
            //var parcial1_frase = $"Hoy es {parcial1_diaSemana}, {parcial1.Day} de {parcial1_mes} de {parcial1.Year}";

            Assert.Equal(2024, parcial1_anio);
            Assert.Equal("30/04/24 14:10:00", parcial1_fechaconhora);
            Assert.Equal("Hoy es Martes, 30 de ABRIL de 2024", parcial1_frase);

        }



        /// <summary>
        /// Cuantas Piezas T se encuentran en el tablero
        /// </summary>
        [Fact]
        public void Test08_LINQ_1()
        {

            var tablero = new TetrisTablero();

            CompletarTableroParaTest(tablero);


            //Alumno
            var cantidadPiezasT = tablero.Piezas.Count(pieza => pieza.Nombre == "PiezaT");

            Assert.Equal(20, cantidadPiezasT);
        }


        /// <summary>
        /// Cuantas piezas estan en posicion "Izquierda"
        /// </summary>
        [Fact]
        public void Test09_LINQ_2()
        {

            var tablero = new TetrisTablero();

            CompletarTableroParaTest(tablero);


            //alumno
            var piezasPosicionIzquierda = from pieza in tablero.Piezas
                                          where pieza.Posicion == "Izquierda"
                                          select pieza;

            var cantidadPiezasPosicionIzquierda = piezasPosicionIzquierda.Count();


            Assert.Equal(30, cantidadPiezasPosicionIzquierda);
        }



        /// <summary>
        /// Cuentas piezas se encuentran hacia la derecha y son del tipo de piezaPiezaT
        /// </summary>
        [Fact]
        public void Test10_LINQ_3()
        {

            var tablero = new TetrisTablero();

            CompletarTableroParaTest(tablero);


            //Alumno
            var query = from pieza in tablero.Piezas
                        where pieza.Posicion == "Derecha" && pieza.Nombre == "PiezaT"
                        select pieza;

            var cantidad = query.Count();


            Assert.Equal(1, cantidad);
        }



        private void CompletarTableroParaTest(ITetrisTablero tablero)
        {

            for (int i = 1; i <= 20; i++)
            {
                var piezaT = new TetrisPieza("PiezaT");
                tablero.Piezas.Add(piezaT);
            }
            tablero.Piezas[19].MoverADerecha();


            for (int i = 1; i <= 30; i++)
            {
                var piezaL = new TetrisPieza("PiezaL");
                piezaL.MoverADerecha();
                piezaL.MoverADerecha();
                piezaL.MoverADerecha();
                tablero.Piezas.Add(piezaL);
            }

            var piezaI = new TetrisPieza("PiezaI");
            piezaI.MoverADerecha();
            tablero.Piezas.Add(piezaI);


            var piezaJ = new TetrisPieza("PiezaJ");
            piezaJ.MoverADerecha();
            tablero.Piezas.Add(piezaJ);

            return;
        }
    }
}