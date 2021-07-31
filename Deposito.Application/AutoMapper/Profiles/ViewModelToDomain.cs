using AutoMapper;
using Deposito.Application.ViewModel;
using Deposito.Domain.Models;

namespace Deposito.Application.AutoMapper.Profiles
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<ClienteViewModel, ClienteDomain>();
            CreateMap<ProdutoViewModel, ProdutoDomain>();
            //CreateMap<FuncionarioViewModel, FuncionarioDomain>();
            //CreateMap<EnderecoViewModel, EnderecoDomain>();
            //CreateMap<InformacoesViewModel, InformacaoAdicionalDomain>();
            //CreateMap<FilterViewModel, FilterDomain>();
            //CreateMap<EmpresaFornecedorViewModel, EmpresaFornecedorDomain>();
        }
    }
}
