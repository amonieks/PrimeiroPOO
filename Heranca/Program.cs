using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            Cnpj cnpjp = new Cnpj();

            Cpf cpfp = new Cpf();


            Console.WriteLine("Escreva o Seu nome");
            cnpjp.Nome = Console.ReadLine();
            cpfp.Nome = Console.ReadLine();

            System.Console.WriteLine(cpfp.saudacao());

            string numero = "35547690-35";
            string registro = "23423553/0001-2";

            cpfp.ValidarCpf(numero);
            cnpjp.numerocnpj(registro);




        }
    }
}
