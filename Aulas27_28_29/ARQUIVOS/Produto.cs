using System;
using System.IO;

namespace ARQUIVOS
{
    public class Produto
    {
        public string Nome { get; set; }
        
        public int Codigo { get; set; }

        public double Valor { get; set; }


        private string PATH = "Database/produtos.csv";

        private string DIR = "Database";

        public Produto()
        {
            try{

            if(!File.Exists(PATH))
            {
            File.Create(PATH).Close();
            }
            }catch{

                System.Console.WriteLine("Não há um diretorio para o arquivo digite o nome da pasta para criá-la");
                DIR = Console.ReadLine();
                DirectoryInfo dir = new DirectoryInfo(DIR);
                dir.Create();
                
                string PAT = $"{DIR}/{PATH.Split('/')[1]}";
                System.Console.WriteLine();
                System.Console.WriteLine(PAT);
                System.Console.WriteLine();
                
                System.Console.WriteLine($"Diretório: '{DIR}' Criado ");
                File.Create(PAT).Close();

                PATH = PAT;
                System.Console.WriteLine();
                System.Console.WriteLine($"New Path = {PATH}");
                
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