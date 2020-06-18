using System;

namespace Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            string lista ="";
            string[] comanda = new string[5];
            
            Cliente cliente = new Cliente();
            Restaurante galoburguer = new Restaurante();
            Pedido pedido = new Pedido();

            galoburguer.NomeFantasia = "Galo Burguer";
            galoburguer.Endereco = "Av. Rangus, 1020";

               /* System.Console.WriteLine("Por favor, informe o seu nome");
                cliente.Nome = Console.ReadLine();
                System.Console.WriteLine("Digite o seu endereço");
                cliente.Endereco = Console.ReadLine();
                Console.Clear();*/

            
                        
              

                


             do{
            System.Console.WriteLine("------------------------------------------------");
            System.Console.WriteLine(galoburguer.MostrarDados(galoburguer.NomeFantasia,galoburguer.Endereco));
            System.Console.WriteLine();
            System.Console.WriteLine(cliente.MostrarDados(cliente.Nome,cliente.Endereco));
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Galo Burguer Smart");
            System.Console.WriteLine("2 - Batata Frita");
            System.Console.WriteLine("3 - Refrigerante");
            System.Console.WriteLine("4 - Galo Burgue Super");
            System.Console.WriteLine("5 - Combo Cacarejo");
            System.Console.WriteLine();
            System.Console.WriteLine("0 - Concluir o pedido");
            
            System.Console.WriteLine("------------------------------------------------");
              
             
                    
                 
             for (int i = 0; i < 4; i++)
             {

                    System.Console.WriteLine("Adicione o Item ao pedido");
                    lista = Console.ReadLine();

                    comanda[i]= lista;

                    System.Console.WriteLine(comanda[i]);
                    System.Console.WriteLine(comanda);

             }


              }while(lista!="0");

              pedido.Itens=comanda;


             //string comanda = "";


                        /*    switch (lista)
                            {
                                
                                case "1": 
                                comanda = "Galo Burguer Smart";
                                break;
                                
                                case "2": 
                                comanda = "Refrigerante";
                                break;

                                case "3": 
                                comanda = "Refrigerante";
                                break;

                                case "4": 
                                comanda = "Galo Burguer Super";
                                break;

                                case "5": 
                                comanda = "Combo Cacarejo";
                                break;

                                                
                                default: 
                                System.Console.WriteLine("Escolha uma opção válida"); 
                                break;
                            }*/
                



             


                        Console.Clear();



           /* System.Console.WriteLine($"{galoburguer.Endereco}\n{galoburguer.NomeFantasia}");
            System.Console.WriteLine();
            System.Console.WriteLine($"{cliente.Endereco}\n{cliente.Nome}");
            System.Console.WriteLine();*/
            System.Console.WriteLine(pedido.Itens);

        }
    }
}
