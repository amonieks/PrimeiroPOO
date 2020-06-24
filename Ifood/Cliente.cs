namespace Ifood
{
    public class Cliente
    {
        public string Nome { get; set; }
        
        public string Endereco { get; set; }

        public Cliente(string nome, string endereco)
        {
            this.Nome = nome;
            this.Endereco = endereco;
        }

        public string MostrarDados()
        {
            
            return $"Cliente:{Nome}\nEndereco:{Endereco}";
        }
    }
}