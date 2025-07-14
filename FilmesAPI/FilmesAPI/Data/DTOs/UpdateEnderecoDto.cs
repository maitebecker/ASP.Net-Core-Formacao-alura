using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs;

public class UpdateEnderecoDto
{
    [Required(ErrorMessage = "O campo logradouro é origatório")]
    public string Logradouro { get; set; }
    [Required(ErrorMessage = "O campo número é origatório")]
    public int Numero { get; set; }
}
