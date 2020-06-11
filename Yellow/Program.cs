using System;

namespace Yellow
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();
            Admin admin = new Admin();
            Bicicletas bicicleta = new Bicicletas();
            

            cliente.Email = "email";
            cliente.Senha = "senha";
            admin.Email = "email";
            admin.Senha = "admin";

            System.Console.WriteLine(cliente.Email);
            System.Console.WriteLine(admin.Senha);

        
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Para logar como cliente escolha = 0");
            Console.WriteLine("Para logar como funcionário escolha = 1");
            Console.WriteLine("-----------------------------------");

            string resposta = Console.ReadLine();
            string email;
            string senha;
            bool teste;

            

            switch (resposta)
            {
                case "0": 
                System.Console.WriteLine("Digite o email");
                email = Console.ReadLine();
                System.Console.WriteLine("Digite a Senha");
                senha = Console.ReadLine();
                
                 teste = (cliente.Login(email,senha));
                
                if(teste){
                    System.Console.WriteLine("Login com sucesso "); 
                    Pagamento pagamento = new Pagamento();

                    System.Console.WriteLine("Digite sua localização atual");
                    cliente.Localizacao = Console.ReadLine();

                    }else{
                    System.Console.WriteLine("Senha ou email incorreto");
                    }  

                break;



                case "1": 
                System.Console.WriteLine("Digite o email");
                email = Console.ReadLine();
                System.Console.WriteLine("Digite a Senha");
                senha = Console.ReadLine();
                teste = (admin.Login(email,senha));
                
                if(teste){
                    System.Console.WriteLine("Login com sucesso ");
                    admin.IdEmpregado = "1020";

                    System.Console.WriteLine("Digite o ID para acessar o equipamento");
                    string ID = Console.ReadLine();                    
                    System.Console.WriteLine(admin.Consertar(ID));
                    
                }else{
                    System.Console.WriteLine("Senha ou email incorreto");
                }            
                break;


                default:
                System.Console.WriteLine("Escolha uma opção válida"); 
                break;
            }
        }
    }
}
