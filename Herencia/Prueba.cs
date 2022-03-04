using System;

namespace Herencia
{
    class Prueba
    {
        static void Main(string[] args)
        {
            //Suma suma1 = new Suma();
            //suma1.Valor1 = 10;
            //suma1.Valor2 = 20;
            //suma1.Operar();

            Resta resta1 = new Resta();
            Console.WriteLine("Dame el valor 1");
            resta1.Valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el valor 2");
            resta1.Valor2 = Convert.ToInt32(Console.ReadLine());
            resta1.Operar();

            Console.ReadKey();
        }
    }
}
