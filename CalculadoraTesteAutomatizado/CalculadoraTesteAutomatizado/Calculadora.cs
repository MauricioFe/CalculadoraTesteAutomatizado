﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTesteAutomatizado
{
    public class Calculadora
    {
        public static decimal Somar(decimal num1, decimal num2) { return (num1 + num2); }
        public static decimal Subtrair(decimal num1, decimal num2) { return (num1 - num2); }
        public static decimal Multiplicar(decimal num1, decimal num2) { return (num1 * num2); }
        public static decimal Dividir(decimal num1, decimal num2) { return (num1 / num2); }
    }
}
