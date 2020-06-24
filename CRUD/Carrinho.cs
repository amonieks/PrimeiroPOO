using System.Collections.Generic;

namespace CRUD
{
    public class Carrinho
    {
        
        public float ValorTotal { get; set; }

        List<Produto> carrito = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrito.Add(_produto);
        }



        public void Remover(Produto _produto)
        {
            carrito.Remove(_produto);
        }

        public void MostrarDados()
        {
             foreach (Produto i in carrito)
            {
                System.Console.WriteLine($"  Produto:{i.Nome}------{i.Preco}");
                
            }
        }

        public void Atualizar(int _codigo, Produto _novoproduto)
        {
            carrito.Find(x=>x.Codigo == _codigo ).Nome=_novoproduto.Nome;
            carrito.Find(x=>x.Codigo == _codigo ).Preco=_novoproduto.Preco;
        }

        

        




    }
}