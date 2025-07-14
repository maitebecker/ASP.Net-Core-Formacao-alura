﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O campo de nome é origatório")]
    public string Nome { get; set; }
}
