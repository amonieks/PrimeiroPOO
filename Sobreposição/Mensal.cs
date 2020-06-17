namespace Sobreposição
{
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio(){

            base.MostrarRelatorio();
            System.Console.WriteLine("Mostrando Relatório Mensal");
        }


        
    }
}