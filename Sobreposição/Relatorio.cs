using System;

namespace Sobreposição
{
    public class Relatorio
    {
        public DateTime Data { get; set; }

        public virtual void MostrarRelatorio(){

            System.Console.WriteLine("Mostrando Relatório Geral");
        }
    }
}