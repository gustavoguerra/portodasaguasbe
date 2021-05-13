using AutoMapper;
using Deposito.Application.ViewModel;
using Deposito.Domain.Models;

namespace Deposito.Application.AutoMapper.Profiles
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<ClienteDomain, ClienteViewModel>();
            //CreateMap<LoginDomain, LoginViewModel>();
            //CreateMap<FuncionarioDomain, FuncionarioViewModel>();
            //CreateMap<EnderecoDomain, EnderecoViewModel>();
            //CreateMap<TipoEmpresaDomain, TipoEmpresaViewModel>();
            //CreateMap<EmpresaFornecedorDomain, EmpresaFornecedorViewModel>();
            //CreateMap<InformacaoAdicionalDomain, InformacoesViewModel>();
            //CreateMap<FilterDomain, FilterViewModel>();
        }
    }
}
