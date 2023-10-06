namespace LocadoraAPI.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

public class Aluguel
{
    [Key]
    public string? Id { get; set; }

    [ForeignKey("ClienteCpf")]
    public Cliente? Cli { get; set; }

    [ForeignKey("VeiculoPlaca")]
    public Veiculo? VeiculoAlugado { get; set; }
    
    public string? ClienteCpf {get;set;}
    public string? VeiculoPlaca { get; set; }
}