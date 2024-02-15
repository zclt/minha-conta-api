using MinhaContaApi.Services.Entities;

namespace MinhaContaApi.Services.Abstractions;

public interface ILancamentoService
{
    Task<Lancamento> GetAsync(string id);
    Task<IEnumerable<Lancamento>> GetAllAsync();
    Task<Lancamento> AddAsync(Lancamento entity);
    Task RemoveAsync(string id);
}