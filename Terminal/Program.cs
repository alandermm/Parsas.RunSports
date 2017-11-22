using System;
using Dominio;
using Repositorio;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            menuPrincipal();
        }

        static void menuPrincipal(){
            int opt = 0;
            do{
                Console.WriteLine(
                    "Escolha uma das opções abaixo:" +
                    "\n1 - Cadastrar" +
                    "\n2 - Vender" +
                    "\n3 - Comprar" +
                    "\n4 - Histórico" +
                    "\n9 - Sair"
                );
                opt = Int16.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        menuCadastro();
                        break;
                    case 2:
                        formaPagamento();
                        break;
                    case 3:
                        formaPagamento();
                        break;
                    case 4:
                        menuHistorico();
                        break;
                    case 9: 
                        Environment.Exit(0);
                        break;
                }
            }while (opt != 9);   
        }
        
        static void menuCadastro(){
            int opt = 0;
            do{
                Console.WriteLine(
                    "\nEscolha uma das opções abaixo:" +
                    "\n1 - Cadastrar Produto" +
                    "\n2 - Cadastrar Cliente" +
                    "\n3 - Cadastrar Fornecedor" +
                    "\n9 - Voltar ao menu anterior"
                );
                opt = Int16.Parse(Console.ReadLine());

                switch(opt){
                    case 1:{
                        bool cadastrado;
                        do{
                            Console.Write("Digite o código de barras: ");
                            string codigoBarras = Console.ReadLine();
                            Console.Write("Digite o Nome do produto: ");
                            string nomeProduto = Console.ReadLine();
                            Console.Write("Digite a descrição do produto: ");
                            string descricao = Console.ReadLine();
                            Console.Write("Digite o preço: ");
                            double preco = double.Parse(Console.ReadLine());
                            Produto produto = new Produto(codigoBarras, nomeProduto, descricao, preco);
                            cadastrado = new ProdutoREP().Cadastrar(produto);
                        } while(!cadastrado);
                        break;
                    }
                    case 2: {
                        bool cadastrado;
                        do{
                            Console.Write("Digite o nome do cliente: ");
                            string nome = Console.ReadLine();
                            Console.Write("Digite o documento do cliente: ");
                            string documento = Console.ReadLine();
                            Console.Write("Digite o telefone: ");
                            string telefone = Console.ReadLine();
                            Console.Write("Digite o e-mail: ");
                            string email = Console.ReadLine();
                            Cliente cliente = new Cliente(nome, telefone, documento, email);
                            cadastrado = new ClienteREP().Cadastrar(cliente);
                        } while(!cadastrado);
                        break;
                    } 
                    case 3:
                        bool cadastrado;
                        do{
                            Console.Write("Digite o nome do fornecedor: ");
                            string nome = Console.ReadLine();
                            Console.Write("Digite o documento do fornecedor: ");
                            string documento = Console.ReadLine();
                            Console.Write("Digite o telefone: ");
                            string telefone = Console.ReadLine();
                            Console.Write("Digite o e-mail: ");
                            string email = Console.ReadLine();
                            Fornecedor fornecedor = new Fornecedor(nome, telefone, documento, email);
                            cadastrado = new FornecedorREP().Cadastrar(fornecedor);
                        } while(!cadastrado);
                        break;
                    case 9:

                        break;
                }
            }while (opt != 9);
        }

        static void formaPagamento(){
            int opt3 = 0;
            do{
                Console.WriteLine(
                    "Escolha a forma de pagamento:" +
                    "\n1 - À Vista" +
                    "\n2 - Debito" +
                    "\n3 - Credito" +
                    "\n9 - Voltar ao menu anterior"
                );
                opt3 = Int16.Parse(Console.ReadLine());
            }while (opt3 != 9);
        }

        static void menuHistorico(){
            int opt4 = 0;
            do{
                Console.WriteLine(
                    "Escolha o histórico a ser exibido:" +
                    "\n1 - Histórico de Vendas" +
                    "\n2 - Histórico de compras" +
                    "\n9 - Voltar ao menu anterior"
                );
                opt4 = Int16.Parse(Console.ReadLine());
            }while (opt4 != 9);
        }
    }
}
