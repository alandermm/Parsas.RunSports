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
        
        

        public string Pesquisar(string pesq_nome)
        {
            string resultado="Cliente não encontrado";
            StreamReader ler = null;
            try{
                ler =  new StreamReader("cliente.csv",Encoding.Default);
                string linha="";
                while((linha=ler.ReadLine())!=null){
                    string[] dados= linha.Split(';');
                    if(dados[0]==pesq_nome){
                        resultado=linha;
                        break;
                    }

                }

            }catch(Exception e){
                resultado = "Erro ao tentar ler o arquivo"+e.Message;
            }finally{
                ler.Close();
            }



            return resultado;
        }
    }
}