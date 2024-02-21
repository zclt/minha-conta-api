namespace MinhaContaApi.Services.Entities;

public class Lancamento
{
    public string UserId { get; set; }
    public string Id { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; }
    public decimal Valor { get; set; }
}