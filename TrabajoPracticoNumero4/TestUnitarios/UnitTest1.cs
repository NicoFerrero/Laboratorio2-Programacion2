using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        public void ListaInstanciada()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        public void PaquetesDiferentes()
        {
            Paquete p1 = new Paquete("aaabbb", "1234");
            Paquete p2 = new Paquete("cccddd", "1234");
            Correo correo = new Correo();
            correo += p1;

            try
            {
                correo += p2;
            }
            catch
            {
            }      
        }
    }
}
