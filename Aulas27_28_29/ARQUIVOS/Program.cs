using System;

namespace ARQUIVOS
{
    class Program
    {
        static void Main(string[] args)
        {
          Produto p1 = new Produto();
          p1.Codigo = 1;
          p1.Nome = "xbox";
          p1.Valor = 1800;

          p1.Cadastrar(p1);



        }
    }
}
