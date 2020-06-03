using System;

namespace abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito Visa = new CartaoCredito();
            Visa.Limite = 300;

            Boleto conta = new Boleto();
            


            System.Console.WriteLine("-------------");
            System.Console.WriteLine($"Seu Limite atual para compras é de:{Visa.Limite}");

            System.Console.WriteLine($"Você tem uma conta no valor de R$900,00 vencendo hoje");
            System.Console.WriteLine("-------------");
            System.Console.WriteLine("");

            System.Console.WriteLine("Em quanto deseja aumentar o limite:");
            float acrescimo = float.Parse(Console.ReadLine());
            Visa.AumentarLimite(acrescimo);

            System.Console.WriteLine("-------------");
            System.Console.WriteLine("");
            System.Console.WriteLine($"Novo limitie: {Visa.Limite}");

            System.Console.WriteLine("Digite o Valor do pagamento");
            float valorpag = float.Parse(Console.ReadLine());

            System.Console.WriteLine("-------------");
            System.Console.WriteLine("");


            string pagamento = Visa.Pagar(valorpag);
            System.Console.WriteLine($" {pagamento}");

            
            


        }
    }
}
