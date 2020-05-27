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
            motorola.tamanho = 7;
            
            Console.WriteLine(motorola.ligadesliga());
            Console.WriteLine("---------------------");

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("---------------------");
            Console.WriteLine("1 - Enviar uma mensagem");
            Console.WriteLine("2 - Fazer uma ligação");
            Console.WriteLine("3 - Informações do telefone");
            Console.WriteLine("4 - Desligar");
            string escolha= Console.ReadLine();
            Console.Clear();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine(motorola.mensagem());
                    break;
                
                case "2":
                    Console.WriteLine(motorola.chamada());
                    break;

                case "3":
                    Console.WriteLine(motorola.modelo+"n/"+motorola.cor+"n/"+motorola.tamanho);
                    break;
                
                case "4":
                    motorola.ligado = false;
                    Console.WriteLine(motorola.ligadesliga());
                    break;
                default:
                    Console.WriteLine("Escolha uma opção no menu");
                break;

            }

           



        
        }
    }
}
