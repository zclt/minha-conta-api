namespace MinhaContaApi.Repositories.Models;

public class LancamentoModel
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string ExternalId { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; }
    public decimal Valor { get; set; }
}