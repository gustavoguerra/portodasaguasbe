using Deposito.Application.AutoMapper;
using Deposito.Business.Business;
using Deposito.Business.Interfaces;
using Deposito.Repository.Interfaces;
using Deposito.Repository.Repository;
using Deposito.Services.Interfaces;
using Deposito.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Deposito.Application.Extencions
{
    public static class DependencyInjection
    {
        public static void DependencyInsection(this IServiceCollection services)
        {
            var mapperConfig = AutoMapperConfig.RegisterMappings();
            services.AddSingleton(mapperConfig.CreateMapper());

            DependencyInjectionServices(services);
            DependencyInjectionBusiness(services);
            DependencyInjectionRepository(services);
            DependencyInjectionInfrastructure(services);
        }
        public static void DependencyInjectionServices(IServiceCollection services)
        {
            services.AddTransient<IClienteServices, ClienteServices>();
            services.AddTransient<IProdutoServices, ProdutoServices>();
        }

        public static void DependencyInjectionBusiness(IServiceCollection services)
        {
            services.AddTransient<IClienteBusiness, ClienteBusiness>();
            services.AddTransient<IProdutoBusiness, ProdutoBusiness>();
        }

        public static void DependencyInjectionInfrastructure(IServiceCollection services)
        {
            //services.AddTransient<IRecuperaSenhaInfrastructure, RecuperaSenhaInfrastructure>();
        }
        public static void DependencyInjectionRepository(IServiceCollection services)
        {
            services.AddSingleton<IClienteRepository, ClienteRepository>();
            services.AddSingleton<IProdutoRepository, ProdutoRepository>();
        }
    }
}
