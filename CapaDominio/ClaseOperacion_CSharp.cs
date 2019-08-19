using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominioCSharp
{
    public class ClaseOperacion_CSharp
    {
        public double Calcular(double num1, double num2, string operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case "Multiplicar":
                    resultado = num1 * num2;
                    break;
                case "Dividir":
                    resultado = num1 / num2;
                    break;
                case "Sumar":
                    resultado = num1 + num2;
                    break;
                case "Restar":
                    resultado = num1 - num2;
                    break;
            }
            return resultado;
        }
    }
}
