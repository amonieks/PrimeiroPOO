namespace Ifood
{
    public class Cliente
    {
        public string Nome { get; set; }
        
        public string Endereco { get; set; }

        public string MostrarDados(string nome, string endereco)
        {
            
            return $"Cliente:{nome}\nEndereco:{endereco}";
        }
    }
}