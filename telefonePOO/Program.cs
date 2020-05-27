using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            

            smartphone motorola = new smartphone();
            
            motorola.cor = "Preto";
            motorola.modelo = "motorola";
            motorola.tamanho = "7 Polegadas";
            
            Console.WriteLine(motorola.ligado());
            Console.WriteLine("---------------------");

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("---------------------");
            Console.WriteLine("1 - Enviar uma mensagem");
            Console.WriteLine("2 - Fazer uma ligação");
            Console.WriteLine("3 - Informações do telefone");
            Console.WriteLine("4 - Desligar");
            string escolha= Console.ReadLine();
            Console.clear();

           



            Console.WriteLine("Hello World!");
        }
    }
}
