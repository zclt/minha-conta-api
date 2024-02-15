using Microsoft.EntityFrameworkCore;
using MinhaContaApi.Repositories.Abstractions;
using MinhaContaApi.Repositories.Models;

namespace MinhaContaApi.Repositories.Repositories;

public class LancamentoRepository : ILancamentoRepository
{
    private readonly MinhaContaContext _context;
    
    public LancamentoRepository(MinhaContaContext context) => _context = context;

    public async Task<LancamentoModel> GetAsync(string id) => 
        await _context.Lancamentos.FirstOrDefaultAsync(x => x.ExternalId == id);

    public async Task<IEnumerable<LancamentoModel>> GetAllAsync() =>
        await _context.Lancamentos.ToListAsync();

    public async Task<LancamentoModel> AddAsync(LancamentoModel model)
    {
        await _context.AddAsync(model);
        await _context.SaveChangesAsync();
        return model;
    }

    public async Task RemoveAsync(string id)
    {
        var model = await _context.Lancamentos.FirstOrDefaultAsync(x => x.ExternalId == id);
        if(model == default) return;

        _context.Remove(model);
        await _context.SaveChangesAsync();
    }
}