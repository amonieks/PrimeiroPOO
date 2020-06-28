using System;
using System.Collections.Generic;
namespace INTERFACE
{
    public class Carrinho:Icarrinho
    {
        public float ValorTotal{get;set;}

        List<Produto> carrinho = new List<Produto>();


        public void Listar()
        {
            
            foreach (Produto i in carrinho)
            {
                
                System.Console.WriteLine($"Produto: ({i.Codigo}) {i.Nome} ========= Preco: {i.Preco}");
            }

        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Alterar(int _codigo,Produto produto)
        {
            carrinho.Find(z=>z.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(z=>z.Codigo == _codigo).Preco = produto.Preco;
        }

        public void Deletar(Produto produto)
        {
            
            carrinho.Remove(produto);
        }

        public double Total()
        {
              double total = 0;
              

                foreach (Produto i in carrinho)
                {
                  

                    total+=i.Preco;
                    
                }

                

                return total;
        
        }


    }
}