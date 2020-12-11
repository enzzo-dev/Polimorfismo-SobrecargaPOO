using System;
using Polimorfismo_SobrecargaPOO.classes;

namespace Polimorfismo_SobrecargaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();

            fun.Mostrar();
            fun.Mostrar(2);
            fun.Mostrar("Waldevino");

        }
    }
}
