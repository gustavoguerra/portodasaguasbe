using System.ComponentModel.DataAnnotations.Schema;

namespace Deposito.Domain.Models
{

    [Table("DepositoProduto")]
    public class ProdutoDomain : Entity
    {
        public string ProdutoNome { get; set; }
        public decimal ProdutoValor { get; set; }
        public bool ProdutoAtivo { get; set; }
    }

}
