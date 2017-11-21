namespace Dominio
{
    /// <summary>
    /// Criação da Classe Produto
    /// </summary>
    public class Produto 
    {

        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Produto()
        {

        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="descricao"></param>
        /// <param name="preco"></param>
        /// <param name="id"></param>
        public Produto(string id, string nome, string descricao, double preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
            
        }

    }

}