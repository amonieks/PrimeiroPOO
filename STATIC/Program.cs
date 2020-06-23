using System;

namespace STATIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação do Dolar hoje");
            CasadeCambio.CotacaoRealDolar = float.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite a cotação do Euro hoje");
            CasadeCambio.CotacaoRealEuro = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite um valor");
            float BLR = float.Parse(Console.ReadLine());
            System.Console.Clear();

            

            


            
            System.Console.WriteLine();
            System.Console.WriteLine($"Valor em Dolares: US${CasadeCambio.CambioDolar(BLR)}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Valor em Euros: EUR{CasadeCambio.CambioEuro(BLR)}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Valor US$ convertido em Reais: R${CasadeCambio.CambioDolarReal(BLR)}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Valor US$ convertido em Reais: R${CasadeCambio.CambioEuroReal(BLR)}");
        }
    }
}
