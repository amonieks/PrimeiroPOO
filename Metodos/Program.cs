using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
                carro1.Marca = "fiat";
                System.Console.WriteLine($"A marca do carro escolhido é:{carro1.Marca}");
                System.Console.WriteLine();

            Carro carro2 = new Carro("Chevrolet");
                System.Console.WriteLine($"A marca do carro escolhido é:{carro2.Marca}");
                System.Console.WriteLine();

            Carro carro3 = new Carro("Ford","Prata",50000);
                System.Console.WriteLine($"A marca do carro escolhido é:{carro3.Marca}\nA cor escolhida é:{carro3.Cor}\nA Kilometragem atual é:{carro3.Kilometragem}");
                


            

        }
    }
}
