using AutoMapper;
using MinhaContaApi.Repositories.Abstractions;
using MinhaContaApi.Repositories.Models;
using MinhaContaApi.Services.Abstractions;
using MinhaContaApi.Services.Entities;

namespace MinhaContaApi.Services.Services;

public class LancamentoService : ILancamentoService
{
    private readonly ILancamentoRepository _repository;
    private readonly IMapper _mapper;
    
    public LancamentoService(IMapper mapper, ILancamentoRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<Lancamento> GetAsync(string id)
    {
        var model = await _repository.GetAsync(id);
        return _mapper.Map<Lancamento>(model);
    }

    public async Task<IEnumerable<Lancamento>> GetAllAsync()
    {
        var lista = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<Lancamento>>(lista);
    }

    public async Task<Lancamento> AddAsync(Lancamento entity)
    {
        var model = _mapper.Map<LancamentoModel>(entity);
        model.UserId = Guid.NewGuid().ToString(); //TODO add logged user
        await _repository.AddAsync(model);
        return _mapper.Map<Lancamento>(model);
    }

    public async Task RemoveAsync(string id) => await _repository.RemoveAsync(id);
}