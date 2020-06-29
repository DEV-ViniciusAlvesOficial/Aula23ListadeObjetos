using System;
using System.Collections.Generic;

namespace Aula23ListaDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando a lista

        List<Produto> produtos = new List<Produto>();

           
        produtos.Add(new Produto(1, "Sorvete de chocolate", 1.50f));
        produtos.Add(new Produto(2, "Sorvete de creme", 1.50f));
        produtos.Add(new Produto(3, "Cookies 'N Cream", 2.80f));
        produtos.Add(new Produto(4, "Sorvete de morango", 1.50f));
        produtos.Add(new Produto(5, "Sorvete de flocos ", 2.99f));


        Produto SorveteBlueIce = new Produto();
        SorveteBlueIce.Codigo = 10;
        SorveteBlueIce.Nome = "Sorvete Blue Ice";
        SorveteBlueIce.Preco = 2.80f;

        produtos.Add(SorveteBlueIce);

         //Foreach = mostrar produtos

        foreach(Produto p in produtos){
            Console.WriteLine($" {p.Nome} - R$ {p.Preco} ");
        }

  
        produtos.RemoveAt(1);

        produtos.RemoveAll(x => x.Nome == "Sorvete de chocolate");

        Console.WriteLine("\nLista alterada: ");

        foreach(Produto p in produtos){
            Console.WriteLine($" {p.Nome} - R$ {p.Preco} ");
        }

        }
    }
}
