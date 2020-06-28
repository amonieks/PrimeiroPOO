using System;

namespace INTERFACE
{
    class Program
    {
        static void Main(string[] args)
        {
                string escolha ="";
                Carrinho c = new Carrinho();

                Produto p1 = new Produto(1,"Computador",1400);
                Produto p2 = new Produto(2,"Televisão",1200);
                Produto p3 = new Produto(3,"Telefone",900);
                Produto p4 = new Produto(4,"Tablet",1400);

                System.Console.WriteLine();
                    Console.Clear();
                System.Console.WriteLine("===================");
                        c.Cadastrar(p1);
                        c.Cadastrar(p2);
                        c.Cadastrar(p3);
                        c.Cadastrar(p4);

                        c.Listar();
                System.Console.WriteLine("===================");
                System.Console.WriteLine();
                do{
                    Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Aperte 0 para retirar um produto ou 1 para continuar");
                    Console.ForegroundColor = ConsoleColor.White;
                 escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":

                     

                                            
                            c.Listar();
                            System.Console.WriteLine($"Valor Total: {c.Total()}"); 

                        break;

                    case "0":

                            c.Listar();
                            System.Console.WriteLine();

                            Console.ForegroundColor = ConsoleColor.Blue;
                            System.Console.WriteLine("Digite o código do item a ser removido");
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Console.WriteLine();
                            string cd = Console.ReadLine();
                            switch (cd)
                            {
                                case "1":
                                c.Deletar(p1);
                                break;

                                case "2":
                                c.Deletar(p2);
                                break;

                                case "3":
                                c.Deletar(p3);
                                break;

                                case "4":
                                c.Deletar(p4);
                                break;
                            

                                default:
                                System.Console.WriteLine("opção Fora da lista");
                                break;
                            }
                            


                            c.Listar();
                            System.Console.WriteLine($"Valor Total: {c.Total()}"); 

                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;
                        
                        System.Console.WriteLine("Escolha uma opção válida");
                        Console.ForegroundColor = ConsoleColor.White;
                        
                        break;
                }
                
                }while((escolha!="0")&&(escolha!="1"));
               
               

                



            
            

        }
    }
}
