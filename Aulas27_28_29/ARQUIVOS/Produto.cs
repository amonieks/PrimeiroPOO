using System;
using System.IO;

namespace ARQUIVOS
{
    public class Produto
    {
        public string Nome { get; set; }
        
        public int Codigo { get; set; }

        public double Valor { get; set; }


        private string PATH = "Database/Produto.csv";

        private string DIR = "Database";

        public Produto()
        {
            try{
                // Testa a existência do arquivo e cria um novo em caso negativo

            if(!File.Exists(PATH))
            {
            File.Create(PATH).Close();
            }
            }catch{

                // Trata o erro gerado quando o folder/pasta para criar o arquivo não está disponível

                //System.Console.WriteLine("A pasta destino não existe, digite o nome para criá-la");
                //DIR = Console.ReadLine();
                
                //Cria a pasta
                DirectoryInfo dir = new DirectoryInfo(DIR);
                dir.Create();
                
                // Atualiza o nome do novo caminho para criar o arquivo
                string PAT = $"{DIR}/{PATH.Split('/')[1]}";

                //Informa o novo caminho criado
                System.Console.WriteLine();
                System.Console.WriteLine(PAT);
                System.Console.WriteLine();


                //informa o nome do novo diretório/pasta
                System.Console.WriteLine($"Diretório: '{DIR}' Criado ");

                //Cria  o Arquivo
                File.Create(PAT).Close();


              //  PATH = PAT;
               // System.Console.WriteLine("New Folder = {PATH}");
                
            }
        }

        private string PrepararLinha(Produto p)
        {

            //monta a string para ser incluida no arquivo CSV
            return $"Código {p.Codigo}; Nome {p.Nome}; Preço {p.Valor}";
        }

        public void Cadastrar(Produto produto)
        {
            //Cria a linha de caracteres
            var Linha = new string[]{PrepararLinha(produto)};

            //Busca o arquivo PATH e adiiona a Linha criada
            File.AppendAllLines(PATH,Linha);

        }


    }
}