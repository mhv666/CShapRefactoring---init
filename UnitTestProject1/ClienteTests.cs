using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CShapRefactoring;

namespace CShapRefactoring.Tests
{
    [TestClass]
    public class ClienteTests
    {
        [TestMethod]
        public void emitirReciboRentaSinRentasPrevias()
        {
            // arrange
            Cliente cliente = new Cliente("Juan Perez");
            string reciboEsperado = "Rentas del Cliente: Juan Perez\nCantidad a pagar: 0\nHas acumulado 0 puntos adicionales a tu cuenta.";

            // act
            string reciboResultado = cliente.emitirReciboRenta();

            // assert
            Assert.AreEqual(reciboEsperado, reciboResultado);
        }
        /*
        [TestMethod]
        public void emitirReciboRentaPeliculaCatalogoDosDias()
        {
            // arrange
            Cliente cliente = new Cliente("Juan Perez");
            Pelicula salvandoSoldadoRyan = new Pelicula("Salvando al Soldado Ryan", Pelicula.CATALOGO);
            string reciboEsperado = "Rentas del Cliente: Juan Perez\n\tSalvando al Soldado Ryan\t2\nCantidad a pagar: 2\nHas acumulado 1 puntos adicionales a tu cuenta.";

            // act
            cliente.agregarRenta(new Renta(salvandoSoldadoRyan, 2));
            string reciboResultado = cliente.emitirReciboRenta();

            // assert
            Assert.AreEqual(reciboEsperado, reciboResultado);
        }

        [TestMethod]
        public void emitirReciboRentaPeliculaCatalogoMasDosDias()
        {
            // arrange
            Cliente cliente = new Cliente("Juan Perez");
            Pelicula salvandoSoldadoRyan = new Pelicula("Salvando al Soldado Ryan", Pelicula.CATALOGO);
            string reciboEsperado = "Rentas del Cliente: Juan Perez\n\tSalvando al Soldado Ryan\t5\nCantidad a pagar: 5\nHas acumulado 1 puntos adicionales a tu cuenta.";

            // act
            cliente.agregarRenta(new Renta(salvandoSoldadoRyan, 4));
            string reciboResultado = cliente.emitirReciboRenta();

            // assert
            Assert.AreEqual(reciboEsperado, reciboResultado);
        }

        [TestMethod]
        public void emitirReciboRentaPeliculaEstreno()
        {
            // arrange
            Cliente cliente = new Cliente("Juan Perez");
            Pelicula salvandoSoldadoRyan = new Pelicula("Salvando al Soldado Ryan", Pelicula.ESTRENO);
            string reciboEsperado = "Rentas del Cliente: Juan Perez\n\tSalvando al Soldado Ryan\t3\nCantidad a pagar: 3\nHas acumulado 1 puntos adicionales a tu cuenta.";

            // act
            cliente.agregarRenta(new Renta(salvandoSoldadoRyan, 1));
            string reciboResultado = cliente.emitirReciboRenta();

            // assert
            Assert.AreEqual(reciboEsperado, reciboResultado);
        }

        [TestMethod]
        public void emitirReciboRentaPeliculaInfantil()
        {
            // arrange
            Cliente cliente = new Cliente("Juan Perez");
            Pelicula toyStory = new Pelicula("Toy Story", Pelicula.INFANTIL);
            string reciboEsperado = "Rentas del Cliente: Juan Perez\n\tToy Story\t1.5\nCantidad a pagar: 1.5\nHas acumulado 1 puntos adicionales a tu cuenta.";

            // act
            cliente.agregarRenta(new Renta(toyStory, 1));
            string reciboResultado = cliente.emitirReciboRenta();

            // assert
            Assert.AreEqual(reciboEsperado, reciboResultado);
        }

        [TestMethod]
        public void emitirReciboRentaPeliculasVarias()
        {
            // arrange
            Cliente cliente = new Cliente("Juan Perez");
            Pelicula salvandoSoldadoRyan = new Pelicula("Salvando al Soldado Ryan", Pelicula.CATALOGO);
            Pelicula kong = new Pelicula("Kong", Pelicula.ESTRENO);
            Pelicula toyStory = new Pelicula("Toy Story", Pelicula.INFANTIL);
            string reciboEsperado = "Rentas del Cliente: Juan Perez\n\tSalvando al Soldado Ryan\t2\n\tKong\t3\n" +
                    "\tToy Story\t1.5\nCantidad a pagar: 6.5\nHas acumulado 3 puntos adicionales a tu cuenta.";

            // act
            cliente.agregarRenta(new Renta(salvandoSoldadoRyan, 1));
            cliente.agregarRenta(new Renta(kong, 1));
            cliente.agregarRenta(new Renta(toyStory, 1));
            string reciboResultado = cliente.emitirReciboRenta();

            // assert
            Assert.AreEqual(reciboEsperado, reciboResultado);
        }

        [TestMethod]
        public void emitirReciboRentaPeliculaInfantilMas3Dias()
        {
            // arrange
            Cliente cliente = new Cliente("Juan Perez");
            Pelicula toyStory = new Pelicula("Toy Story", Pelicula.INFANTIL);
            string reciboEsperado = "Rentas del Cliente: Juan Perez\n\tToy Story\t4.5\nCantidad a pagar: 4.5\nHas acumulado 1 puntos adicionales a tu cuenta.";

            // act
            cliente.agregarRenta(new Renta(toyStory, 5));
            string reciboResultado = cliente.emitirReciboRenta();

            // assert
            Assert.AreEqual(reciboEsperado, reciboResultado);
        }

        [TestMethod]
        public void emitirReciboRentaPeliculaEstrenoMas1Dia()
        {
            // arrange
            Cliente cliente = new Cliente("Juan Perez");
            Pelicula salvandoSoldadoRyan = new Pelicula("Salvando al Soldado Ryan", Pelicula.ESTRENO);
            string reciboEsperado = "Rentas del Cliente: Juan Perez\n\tSalvando al Soldado Ryan\t9\nCantidad a pagar: 9\nHas acumulado 2 puntos adicionales a tu cuenta.";

            // act
            cliente.agregarRenta(new Renta(salvandoSoldadoRyan, 3));
            string reciboResultado = cliente.emitirReciboRenta();

            // assert
            Assert.AreEqual(reciboEsperado, reciboResultado);
        }
        */
    }
}
