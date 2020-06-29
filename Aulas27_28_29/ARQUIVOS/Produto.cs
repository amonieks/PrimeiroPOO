using System.IO;

namespace ARQUIVOS
{
    public class Produto
    {
        public string Nome { get; set; }
        
        public int Codigo { get; set; }

        public double Valor { get; set; }


        private const string PATH = "Database/produtos.csv";

        public Produto()
        {
            if(!File.Exists(PATH))
            {
            File.Create(PATH).Close();
            }
        }

        private string PrepararLinha(Produto p)
        {
            return $"Código {p.Codigo}; Nome {p.Nome}; Preço {p.Valor}";
        }

        public void Cadastrar(Produto produto)
        {
            var Linha = new string[]{PrepararLinha(produto)};
            File.AppendAllLines(PATH,Linha);

        }


    }
}