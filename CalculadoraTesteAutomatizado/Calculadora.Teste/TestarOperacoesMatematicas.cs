using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculadoraTesteAutomatizado;

namespace CalculadoraTeste
{
    [TestClass]
    public class TestarOperacoesMatematicas
    {
        [TestMethod]
        [DataRow(10, 20)]
        public void RetornaValorSoma(double num1, double num2)
        {
            decimal resultadoEsperado = Convert.ToDecimal(num1 + num2);
            decimal resultadoObtidido = Calculadora.Somar(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
            Assert.AreEqual(resultadoEsperado, resultadoObtidido);
        }
        [TestMethod]
        [DataRow(10, 20)]
        public void RetornaValorSubtracao(double num1, double num2)
        {
            decimal resultadoEsperado = Convert.ToDecimal(num1 - num2);
            decimal resultadoObtidido = Calculadora.Somar(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
            Assert.AreEqual(resultadoEsperado, resultadoObtidido);
        }
        [TestMethod]
        [DataRow(10, 20)]
        public void RetornaValorMultiplicacao(double num1, double num2)
        {
            decimal resultadoEsperado = Convert.ToDecimal(num1 * num2);
            decimal resultadoObtidido = Calculadora.Somar(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
            Assert.AreEqual(resultadoEsperado, resultadoObtidido);
        }
        [TestMethod]
        [DataRow(10, 20)]
        public void RetornaValorDivisao(double num1, double num2)
        {
            decimal resultadoEsperado = Convert.ToDecimal(num1 / num2);
            decimal resultadoObtidido = Calculadora.Somar(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
            Assert.AreEqual(resultadoEsperado, resultadoObtidido);
        }
    }
}
