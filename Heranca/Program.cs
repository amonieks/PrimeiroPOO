using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            Cnpj cnpjp = new Cnpj();

            Cpf cpfp = new Cpf();

            System.Console.WriteLine(cpfp.saudacao());
            System.Console.WriteLine();

            Console.WriteLine("Escreve su nome ai");
            string nome = Console.ReadLine(); 
            cnpjp.Nome = nome; 
            cpfp.Nome = nome;


            

            string numero = "35547690-35";
            string registro = "23423553/0001-2";

            
            bool testcpf = cpfp.ValidarCpf(numero);
            bool testcnpj = cnpjp.ValidarCnpj(registro);
            System.Console.WriteLine();
            System.Console.WriteLine($"CPF do Mano: {cpfp.NumeroCpf(numero)}");
            System.Console.WriteLine($"CNPJ da Loja: {cnpjp.Numerocnpj(registro)}");



        }
    }
}
