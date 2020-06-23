namespace Ifood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }

        public string Endereco { get; set; }

        public Restaurante(string nomeFantasia, string endereco)
        {
            this.NomeFantasia = nomeFantasia;
            this.Endereco = endereco;

        }

        public string MostrarDados(string nomefantasia, string endereco)
        {

            return $"Restaurante:{nomefantasia} \nEndereço:{endereco}";
      }
    }
}