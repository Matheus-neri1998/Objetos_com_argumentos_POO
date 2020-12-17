using System;
using System.Collections.Generic;

namespace Objetos_com_argumentos_POO.Classes
{
    public class Carrinho
    {
        // Criamos uma propriedade para guardar o valor total do carrinho
        public float ValorTotal {get; set;}


        // Criamos uma lista que representará nosso carrinho
        List<Produto> carrinho = new List<Produto>();


        // Criamos o método para adicionar um produto ao carrinho
        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }


        // Criamos um método que remove um produto do carrinho
        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }


        // Podemos criar um método para listar os produtos que estão no carrinho
        public void MostrarProduto()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if(carrinho != null)
            {
                foreach (Produto cart in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" {cart.Codigo} - {cart.Nome} - R$ {cart.Preco}");
                    Console.ResetColor();
                }
            }
        } // fim de MostrarProduto


        // Criamos um método para calcular o total da compra
        public void MostarTotal()
        {
            if (carrinho != null)
            {
                foreach (Produto product in carrinho)
                {
                    ValorTotal += product.Preco;
                }
                    Console.WriteLine($" Total do carrinho R$ { ValorTotal.ToString ("n2") } ");
               } else {
                    Console.WriteLine("Seu carrinho está vazio. ");
                }
        Console.ResetColor();

        } // fim de MostrarTotal


        // Criando método para alterar o produto
        public void AlterarItem(int _codigo_procurado, Produto _novo_Produto){
            carrinho.Find(produto => produto.Codigo == _codigo_procurado).Nome = _novo_Produto.Nome;
            carrinho.Find(produto => produto.Codigo == _codigo_procurado).Preco = _novo_Produto.Preco;


        } // fim de AlterarItem

        

        } // fim da classe Carrinho


    }