using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Contas;

public class TipoLancamento
{
    public TipoLancamento()
    {
        Lancamentos = new Collection<Lancamento>();
    }
    [Key]
    public int Id { get; set; }  
    [Required]
    [MaxLength(50)]
    public string Descricao { get; set; } = "";
    public ICollection<Lancamento>? Lancamentos { get; set; }
}