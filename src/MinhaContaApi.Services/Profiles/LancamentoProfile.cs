using AutoMapper;
using MinhaContaApi.Repositories.Models;
using MinhaContaApi.Services.Entities;

namespace MinhaContaApi.Services.Profiles;

public class LancamentoProfile : Profile
{
    public LancamentoProfile()
    {
        CreateMap<LancamentoModel, Lancamento>()
            .ForMember(m => m.Id, o => o.MapFrom(s => s.ExternalId));
        CreateMap<Lancamento, LancamentoModel>()
            .ForMember(m => m.Id, o => o.Ignore())
            .ForMember(m => m.ExternalId, o => o.MapFrom(s => s.Id));
    }
}