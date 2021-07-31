
namespace Deposito.Domain
{
    public static class ErrorMessages
    {
        //Erro Genrico
        public const string ERRO_GENERICO = "Ocorreu um erro ao processar a requisição, favor contate o responsável da área !";
        
        //comum
        public const string DELETE_ERROR = "Erro ao deletar!";
        public const string UPDATE_ERROR = "Erro ao atualizar!";
        public const string INSERT_ERROR = "Erro ao inserir!";
        public const string GET_ERROR = "Erro ao listar!";
        public const string TOKEN_ERRO = "Usuario não autorizado!";
        public const string USUARIO_ERRO = "Usuario ou senha invalido";
        public const string FILTER_ERRO = "Valores do filtro são invalidas";

        //endereco
        public const string CEP = "CEP informado é invalido, insira um CEP válido!";
        public const string CIDADE = "A cidade é invalido, insira uma cidade válida!";
        public const string ESTADO = "O UF é invalido, insira um UF válido!";
        public const string LOGRADOURO = "O logradouro é invalido, insira um logradouro válido!";
        public const string BAIRRO = "O bairro é invalido, insira um bairro válido!";
        public const string NUMERO = "O número é invalido, insira um número válido!";

        //Cliente
        public const string CLIENTENOME = "Nome do cliente obrigatorio !";
        public const string CLIENTETELEFONE = "Telefone obrigatorio !";

        //Produto
        public const string PRODUTONOME = "Nome do produto é obrigatorio !";
        public const string PRODUTOVALOR = "Valor do produto é obrigatorio !";
    }
}
