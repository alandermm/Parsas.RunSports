namespace Dominio
{
    /// <summary>
    /// Criação da Classe Cliente que herdará os atributos da Classe Pessoa e os métodos da Interface ICadastro
    /// </summary>
    public class Cliente:Pessoa,ICadastro
    {

        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Cliente()
        {
            
        }

        /// <summary>
        /// Construtor criado com base nos atributos herdados da classe pai Pessoa
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="documento"></param>
        /// <param name="email"></param>
        public Cliente(string nome,string telefone,string documento,string email)
        {
            base.Nome = nome;
            base.Telefone = telefone;
            base.Documento = documento;
            base.Email = email;            
        }


        
        public string Cadastrar()
        {
            throw new System.NotImplementedException();
        }

        public string Pesquisar()
        {
            throw new System.NotImplementedException();
        }
    }

}