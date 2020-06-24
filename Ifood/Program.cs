using System;

namespace Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            System.Console.WriteLine("Digit o Seu Nome");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Informe o seu endereço");
            string local = Console.ReadLine();

            Cliente cliente = new Cliente(nome,local);
            Restaurante galoburguer = new Restaurante("Galo Burguer", "AV. Cocorico 1045");

            Pedido pedido = new Pedido();
            pedido.Cliente = cliente;
            pedido.Restaurante = galoburguer;
            Console.Clear();

            System.Console.WriteLine(pedido.EntregarPedido());
                       
        

            
            
                        
              

                



        }
    }
}
