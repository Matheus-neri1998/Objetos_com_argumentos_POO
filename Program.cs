using System;
using Objetos_com_argumentos_POO.Classes;

namespace Objetos_com_argumentos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando alguns produtos usando a classe Produto

            Produto p1 = new Produto(1, "Read Dead Redemption", 499f);
            Produto p2 = new Produto(2, "Mortal Kombat 11", 56.9f);
            Produto p3 = new Produto(3, "GTA 5", 56.90f);
            Produto p4 = new Produto(4, "WWE 2K21", 20.99f);

            // Adicionando os produtos ao carrinho

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            carrinho.MostrarProduto();

            Console.ForegroundColor = ConsoleColor.Red;
            Produto p5 = new Produto(5, "GTA 4", 100f);

            carrinho.AlterarItem(1, p5);

            carrinho.MostrarProduto();
            carrinho.RemoverProduto(p1);
            carrinho.MostrarProduto();

            Console.ResetColor();


        } // fim de Main
    }
}
