using System;
namespace Dominio
{
    public interface ICadastro<T> where T : class
    {
        bool Cadastrar(T objeto);
        T Pesquisar(string campo);
    }
}