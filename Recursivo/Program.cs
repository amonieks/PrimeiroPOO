using System;

namespace Recursivo
{
    class Program
    {
        static void Main(string[] args)
        {

            Recur r = new Recur();
            Fatorial f = new Fatorial();

            r.GerarFibonacci(0,1,10);
            System.Console.WriteLine("----");
            System.Console.WriteLine(f.Fator(5));
            
        }
    }
}
