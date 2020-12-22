using System;
using System.Collections.Generic;

namespace POO_ProjetoDeProdutos.classes
{
    public class Marca
    {

        public int Codigo { get; set; }
        
        public string NomeMarca { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        List<Marca> ListaDeMarcas = new List<Marca>();
        
        

        public Marca Cadastrar(){
            Marca novaMarca = new Marca();

            Console.WriteLine("Digite o código da marca");
            novaMarca.Codigo = int.Parse(Console.ReadLine());  

            Console.WriteLine("Digite o nome da marca");
            novaMarca.NomeMarca = Console.ReadLine();
            
            DataCadastro = DateTime.Now;

            ListaDeMarcas.Add(novaMarca);
            
            return novaMarca;
        }   

        public void Listar(){
            foreach (Marca item in ListaDeMarcas)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Código: {item.Codigo} ");
                Console.WriteLine($"Nome da Marca: {item.NomeMarca} ");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro} ");
                Console.ResetColor();
            }

        }

        public void Deletar(int cod){
            Marca marcaDeletar = ListaDeMarcas.Find(x => x.Codigo == cod);

            ListaDeMarcas.Remove(marcaDeletar);

        }


    }
}