using System;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1,"Samsumg",1500);
            Produto p2 = new Produto(2,"Xiaomi",1300);
            Produto p3 = new Produto(3,"Aple",2500);

            Carrinho c=new Carrinho();
            c.Adicionar(p1);
            c.Adicionar(p2);
            c.Adicionar(p3);

            c.Remover(p2);

            Produto novo = new Produto(3,"Motorola",1800);
            c.Atualizar(3,novo);

            c.MostrarDados();
        }
    }
}
