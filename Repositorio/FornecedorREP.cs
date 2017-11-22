using System;
using System.IO;
using Dominio;
namespace Repositorio
{
    public class FornecedorREP: Pessoa, ICadastro<Fornecedor>
    {
        public string Cadastrar(Fornecedor objeto)
        {
            string msg="";
            StreamWriter arquivo= null;

            try{
                arquivo=new StreamWriter("Fornecedor.csv",true);
                arquivo.WriteLine(objeto.Nome+";"+objeto.Telefone+";"+objeto.Documento+";"+objeto.Email);
                msg="Cadastro efetuado com sucesso";
            }catch(Exception ex){
                throw new Exception("Erro ao tentar gravar o arquivo "+ex.Message);
                
            }finally{
                arquivo.Close();

            }
            return msg;
            


        }

        public string Pesquisar(string objeto)
        {
            throw new NotImplementedException();
        }
    }
}