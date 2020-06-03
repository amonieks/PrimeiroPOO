using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcCientifica hp12 = new CalcCientifica();

            System.Console.WriteLine("Digite o calculo que pretente executar");
            hp12.ControlarMetodos(Console.ReadLine());
            System.Console.WriteLine("Resultado :"+hp12.Resultado);
            

            System.Console.WriteLine("-----------------------------------");

         

            System.Console.WriteLine("Digite os números separdos por vírgula para calcular a média");
            hp12.CalcularMedia(Console.ReadLine());
            System.Console.WriteLine("Resultado :"+hp12.Resultado);


        }
    }
}
