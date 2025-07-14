using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O campo de nome é origatório")]
    public string Nome { get; set; }
    public int EnderecoId { get; set; }
}
