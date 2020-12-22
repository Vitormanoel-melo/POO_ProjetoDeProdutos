using System;
using System.Collections.Generic;

namespace POO_ProjetoDeProdutos.classes
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }
        
        public float Preco { get; set; }

        public DateTime DataCadastro { get; set; }
        
        Marca Marca = new Marca();
        
        public Usuario cadastradoPor = new Usuario();
        
        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){

            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do produto");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome do produto");
            novoProduto.NomeProduto = Console.ReadLine();
            
            Console.WriteLine("Digite o preço do produto");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            // Chamamos um método do objeto Marca
            novoProduto.Marca = Marca.Cadastrar();

            novoProduto.cadastradoPor = new Usuario();

            DataCadastro = DateTime.UtcNow;

            ListaDeProdutos.Add(novoProduto);

            
        }
        public void Listar(){ 
            Console.ForegroundColor = ConsoleColor.Green;

                foreach (Produto item in ListaDeProdutos)
                {
                    Console.WriteLine($"Código {item.Codigo} ");
                    Console.WriteLine($"Produto: {item.NomeProduto} ");
                    Console.WriteLine($"Preço: {item.Preco} ");
                    Console.WriteLine($"Marca: {item.Marca.NomeMarca} ");
                    Console.WriteLine($"Data do Cadastro: {item.DataCadastro} ");
                    Console.WriteLine($"Cadastrado por: {item.cadastradoPor.Nome} ");
                }

            Console.ResetColor();

        }

        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(x => x.Codigo == cod);
            
            ListaDeProdutos.Remove(prodDelete);

        }


    }
}