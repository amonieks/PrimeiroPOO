using System;


namespace encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Mastercard master = new Mastercard();
            master.Nome = "Antonio";
            master.Parcelas = 5;

            Console.WriteLine("Insira o Nome do Produto Adquirido");
            string Produto = Console.ReadLine();

            Console.WriteLine("Insira o Valor do Produto");            
            double ValorProduto =  double.Parse(Console.ReadLine());

            Console.WriteLine("digite o Desconto concedido");
            float Desconto = float.Parse(Console.ReadLine());

            double Valor = ValorProduto -(ValorProduto * (Desconto/100));

            master.ComprarComDescontoMastercard(Produto,Desconto,Valor);



        }
    }
}
