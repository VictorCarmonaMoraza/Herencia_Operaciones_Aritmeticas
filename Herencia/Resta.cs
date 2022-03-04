using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Resta: Operacion
    {

        public void Operar()
        {
            if (Valor1 < Valor2)
            {
                Resultado = Valor1 - Valor2;
                Console.WriteLine("El resultado sera negativo y es: {0}", Resultado);
            }
            else if(Valor1.Equals(Valor2))
            {
                Resultado = Valor1 - Valor2;
                Console.WriteLine("El resultado sera nulo y es: {0}", Resultado);
            }
            else
            {
                Resultado = Valor1 - Valor2;
                Console.WriteLine("El resultado sera positivo y es: {0}", Resultado);
            }
        }
    }
}
