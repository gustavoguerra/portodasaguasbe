using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deposito.Application.ViewModel
{
    public class ProdutoViewModel
    {
        public string ProdutoNome { get; set; }
        public decimal ProdutoValor { get; set; }
        public bool ProdutoAtivo { get; set; }
    }
}
