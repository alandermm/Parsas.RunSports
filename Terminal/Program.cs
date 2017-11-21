using System;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void menuPrincipal(){
            int opt = 0;
            do{
                Console.println(
                    "Escolha uma das opções abaixo:" +
                    "1 - Cadastrar" +
                    "2 - Vender" +
                    "3 - Comprar" +
                    "4 - Histórico" +
                    "9 - Sair"
                );
                opt = Int16.Parse(Console.ReadLine());
            }while (opt != 9);
            
            switch (opt)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 9: 
                    Enviroment.Exit(0);
                    break;
            }
        }
        
        static void menuCadastro(){
            int opt = 0;
            do{
                Console.println(
                    "Escolha uma das opções abaixo:" +
                    "1 - Cadastrar Produto" +
                    "2 - Cadastrar Cliente" +
                    "3 - Cadastrar Fornecedor" +
                    "9 - Voltar ao menu anterior"
                );
                opt = Int16.Parse(Console.ReadLine());
            }while (opt != 9);
        }

        static void formaPagamento(){
            int opt = 0;
            do{
                Console.println(
                    "Escolha a forma de pagamento:" +
                    "1 - À Vista" +
                    "2 - Debito" +
                    "3 - Credito" +
                    "9 - Voltar ao menu anterior"
                );
                opt = Int16.Parse(Console.ReadLine());
            }while (opt != 9);
        }

        static void menuHistorico(){
            int opt = 0;
            do{
                Console.println(
                    "Escolha o histórico a ser exibido:" +
                    "1 - Histórico de Vendas" +
                    "2 - Histórico de compras" +
                    "9 - Voltar ao menu anterior"
                );
                opt = Int16.Parse(Console.ReadLine());
            }while (opt != 9);
        }
    }
}
