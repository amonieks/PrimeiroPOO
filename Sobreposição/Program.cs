using System;

namespace Sobreposição
{
    class Program
    {
        static void Main(string[] args)
        {

            Mensal relatorioMes = new Mensal();
            Anual relatorioAno = new Anual();
            relatorioAno.Data= DateTime.Now;

            
            System.Console.WriteLine();
            System.Console.WriteLine(relatorioAno.Data);
            System.Console.WriteLine();


            relatorioAno.MostrarRelatorio();
            System.Console.WriteLine();
            System.Console.WriteLine();

            relatorioMes.MostrarRelatorio();

            Console.WriteLine("yeeees!!!!");
        }
    }
}
