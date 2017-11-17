namespace Dominio
{
    /// <summary>
    /// Criação da Classe Fornecedor que herdará os atributos da Classe Pessoa e os métodos da Interface ICadastro
    /// </summary>
    public class Fornecedor : Pessoa
    {

        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Fornecedor()
        {

        }

        /// <summary>
        /// Construtor criado com base nos atributos herdados da classe pai Pessoa
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="documento"></param>
        /// <param name="email"></param>
        public Fornecedor(string nome, string telefone, string documento, string email)
        {
            base.Nome = nome;
            base.Telefone = telefone;
            base.Documento = documento;
            base.Email = email;
        }


    }

}