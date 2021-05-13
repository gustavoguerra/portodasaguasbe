namespace Deposito.Domain.Models
{
    public class ClienteDomain : Entity
    {
        public string ClineteNome { get; set; }
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
