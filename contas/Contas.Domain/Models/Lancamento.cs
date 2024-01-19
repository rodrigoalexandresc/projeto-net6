using System.ComponentModel.DataAnnotations;

namespace Contas; 

public class Lancamento
{
	[Key]
	public int Id { get; set; }

	[Required]
	[MaxLength(100)]
	public string Descricao { get; set; } = "";

	[Required]
	public int TipoLancamentoId { get; set; }
	public TipoLancamento? TipoLancamento { get; set; }
	public DateTime Data { get; set; }
}