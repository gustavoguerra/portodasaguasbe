using AutoMapper;
using Deposito.Application.AutoMapper.Profiles;
using System.Diagnostics.CodeAnalysis;


namespace Deposito.Application.AutoMapper
{
    [ExcludeFromCodeCoverage]
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
                ps.AddProfile(new DomainToViewModel());
                ps.AddProfile(new ViewModelToDomain());
            });
        }
    }
}
