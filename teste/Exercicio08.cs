using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe.atos.teste
{
    internal class Exercicio08
    {
        public static void Ex08()
        {
            double Celsius, Fahrenheit;

            Celsius = 36;
            Fahrenheit = (9 * Celsius + 160) / 5;

            Console.WriteLine($"a temperatura convertida de Celsius para Fahrenheit é de {Fahrenheit}°F\r\n");
        }
    }
}
