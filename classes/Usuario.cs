using System;

namespace POO_ProjetoDeProdutos.classes
{
    public class Usuario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Senha {get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        public Usuario(){
            Cadastrar();
        }

        public void Cadastrar(){
            
            Nome = "administrador";       
            
            Email = "admin@admin.com";
            
            Senha = "123456";
            
            DataCadastro = DateTime.Now;

        }

        
        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("");

        }

    }
}