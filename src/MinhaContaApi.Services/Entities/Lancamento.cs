namespace MinhaContaApi.Services.Entities;

public class Lancamento
{
    public string Id { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; }
    public decimal Valor { get; set; }
}