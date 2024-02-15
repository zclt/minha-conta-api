using AutoMapper;
using MinhaContaApi.Repositories.Models;
using MinhaContaApi.Services.Entities;

namespace MinhaContaApi.Services.Profiles;

public class LancamentoProfile : Profile
{
    public LancamentoProfile()
    {
        CreateMap<Lancamento, LancamentoModel>().ReverseMap();
    }
}