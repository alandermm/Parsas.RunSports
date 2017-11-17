namespace Repositorio
{
    public class FornecedorREP: Pessoa, ICadastro
    {
        public string Cadastrar(Fornecedor objeto)
        {
            string msg="";
            streamWriter arquivo= null;

            try{
                arquivo=new streamWriter("Fornecedor.csv",true);
                arquivo.WriteLine(objeto.Nome+";"+objeto.Telefone+";"+objeto.Documento+";"+objeto.Email);
                msg="Cadastro efetuado com sucesso"
            }catch(Exception ex){
                throw new Exception("Erro ao tentar gravar o arquivo "+ex.Message);
                
            }finally{
                arquivo.Close();

            }
            return msg;
            


        }

        public string Pesquisar(Fornecedor objeto)
        {
            throw new NotImplementedException();
        }



        
        
    }
}