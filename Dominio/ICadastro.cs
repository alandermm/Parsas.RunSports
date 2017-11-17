using System;
namespace Dominio
{
    public interface ICadastro <T> where T : class
    
        
    {
        string Cadastrar(T objeto);
        string Pesquisar(string campo);
         
    }
}