using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Dominio;

namespace Repositorio
{
    public class ClienteREP : Pessoa, ICadastro<Cliente>
    {
        public bool Cadastrar(Cliente objeto)
        {
            bool efetuado = false;
            StreamWriter arquivo = null;

            try{

                //O "true" faz com o arquivo crie anexos, para que fiquem mais informações no mesmo arquivo;
                arquivo = new StreamWriter("cliente.csv",true);
                arquivo.WriteLine(Nome+";"+Telefone+";"+ Documento+";"+ Email);
                efetuado = true;
                      
            }

            catch(Exception erro){
                throw new Exception("Erro ao tentar gravar o arquivo"+erro.Message);
            }


            finally{
                arquivo.Close();
            }

            return efetuado; }
        
        

        public string Pesquisar(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}