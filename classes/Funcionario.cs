using System;

namespace Polimorfismo_SobrecargaPOO.classes
{
    public class Funcionario
    {
        public string[] lista = {"Enzzo" , "Ellen" , "Waldevino" , "Ivete"};

        public void Mostrar(){
            //Mostrar Nomes cadastrados

            foreach(var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }

        public void Mostrar (int indice){
            //Mostrar índices dos nomes cadastrados

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(lista[indice]);
            Console.ResetColor();
        }

        public void Mostrar(string busca){
            //Buscar nomes cadastrados

            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                    if(item == busca){
                        System.Console.WriteLine($"Resultado da busca: {item}");
                    }
                Console.ResetColor();    
            }
        }
    }
}