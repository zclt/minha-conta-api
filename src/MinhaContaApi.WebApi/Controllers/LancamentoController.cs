using Microsoft.AspNetCore.Mvc;
using MinhaContaApi.Services.Abstractions;
using MinhaContaApi.Services.Dtos;
using MinhaContaApi.Services.Entities;

namespace MinhaContaApi.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LancamentoController : ControllerBase
{
    private readonly ILancamentoService _service;

    public LancamentoController(ILancamentoService service) => _service = service;

    [HttpGet]
    public async Task<IEnumerable<Lancamento>> GetAllAsync() => await _service.GetAllAsync();

    [HttpGet("/{id}")]
    public async Task<Lancamento> GetAsync(string id) => await _service.GetAsync(id);

    [HttpDelete("/{id}")]
    public async Task RemoveAsync(string id) => await _service.RemoveAsync(id);

    [HttpPost]
    public async Task<Lancamento> AddAsync([FromBody]LancamentoInputDto input) =>
        await _service.AddAsync(new Lancamento
        {
            ExternalId = Guid.NewGuid().ToString(),
            UserId = Guid.NewGuid().ToString(),
            Descricao = input.Descricao,
            Data = input.Data,
            Valor = input.Valor
        });
}
