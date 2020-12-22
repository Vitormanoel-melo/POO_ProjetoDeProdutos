using System;

namespace POO_ProjetoDeProdutos.classes
{
    public class Login
    {
        public bool Logado { get; set; }
        
        public Login(){
            Usuario usuario = new Usuario();

            Logar();

            if(Logado == true){
                GerarMenu();

            }
            else if(Logado == false){

            }

        }

        public void GerarMenu(){
            
            Produto produto = new Produto();

            Marca marca = new Marca();

            string opcao = "n";


            do{
                Console.WriteLine("Escolha uma opção abaixo");

                Console.WriteLine("[1] - Cadastrar Marca ");
                Console.WriteLine("[2] - Listar Marca ");
                Console.WriteLine("[3] - Excluir Marca ");
                Console.WriteLine("[4] - Cadastrar Produto ");
                Console.WriteLine("[5] - Listar Produtos ");
                Console.WriteLine("[6] - Excluir Produto ");
                Console.WriteLine("[0] - Sair da aplicação ");
                opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":

                        marca.Cadastrar();

                        break;

                    case "2":

                        marca.Listar();

                        break;

                    case "3":

                        Console.WriteLine("Digite um código para excluir a marca: ");
                        int cod = int.Parse(Console.ReadLine());

                        marca.Deletar(cod);
                        break;

                    case "4":
                        produto.Cadastrar();

                        break;

                    case "5":

                        produto.Listar();

                        break;

                    case "6":
                        Console.WriteLine("Digite o código do produto para excluí-lo: ");
                        int codProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(codProduto);

                        break;

                    default:
                        break;
                }
                

            }while(opcao != "0");

        }


        void Logar(){
            Usuario user = new Usuario();
            string login = "true";
            do{
            Console.WriteLine("Digite seu E-mail: ");
            string emailLogin = Console.ReadLine();
            
            Console.WriteLine("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();
            
            if(emailLogin == user.Email && senhaLogin == user.Senha){
                Logado = true;
                login = "true";
                Console.WriteLine("Login efetuado com sucesso!");
            }
            else{
                login = "false";
                Console.WriteLine("Falha no Login! Tente novamente ");
            }

            }while(login == "false");

        }


        void Deslogar(){
            Logado = false;
        }
        
    }
}