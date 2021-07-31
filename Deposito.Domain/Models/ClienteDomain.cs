using System.ComponentModel.DataAnnotations.Schema;

namespace Deposito.Domain.Models
{
    [Table("DepositoCliente")]
    public class ClienteDomain : Entity
    {
        public string ClienteNome { get; set; }
        public string ClienteCep { get; set; }
        public string ClienteRua { get; set; }
        public string ClienteNumero { get; set; }
        public string ClienteBairro { get; set; }
        public string ClienteCidade { get; set; }
        public string ClienteEstado { get; set; }
        public string ClienteTelefone { get; set; }
        public string ClienteEmail { get; set; }
    }
}
