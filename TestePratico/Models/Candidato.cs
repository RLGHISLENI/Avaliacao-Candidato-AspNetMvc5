using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestePratico.Models
{
  public class Candidato
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Nome")]
    [MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
    [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
    public String Nome { get; set; }

    [Required(ErrorMessage = "Preencha o campo SobreNome")]
    [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
    [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
    [DisplayName("SobreNome")]
    public String Sobrenome { get; set; }

    public int Idade { get; set; }
  }
}
