﻿using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "Gibson";
            p1.Preco = 3500f;

            p1.Cadastrar(p1);
            p1.Remover("Tagima");

            Produto alterado = new Produto();
            alterado.Codigo = 2;
            alterado.Nome = "ESP";
            alterado.Preco = 126000f;

            p1.Alterar(alterado);

            List<Produto> lista = p1.Ler();

            foreach(Produto item in lista)
            {
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }

        }
    }
}