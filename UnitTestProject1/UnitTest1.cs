using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CShapRefactoring;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
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
    }
}
