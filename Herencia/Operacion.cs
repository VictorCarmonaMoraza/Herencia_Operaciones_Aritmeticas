﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Operacion
    {
        private int valor1;
        private int valor2;
        private int resultado;

        public int Valor1 { get => valor1; set => valor1 = value; }
        public int Valor2 { get => valor2; set => valor2 = value; }
        public int Resultado { get => resultado; set => resultado = value; }

        public virtual void Operar()
        {
            Console.WriteLine("Padre");
        }
    }
}
