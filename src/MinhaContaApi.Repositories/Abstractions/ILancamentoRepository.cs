using MinhaContaApi.Repositories.Models;

namespace MinhaContaApi.Repositories.Abstractions;

public interface ILancamentoRepository
{
    Task<LancamentoModel> GetAsync(string id);
    Task<IEnumerable<LancamentoModel>> GetAllAsync();
    Task<LancamentoModel> AddAsync(LancamentoModel model);
    Task RemoveAsync(string id);
}