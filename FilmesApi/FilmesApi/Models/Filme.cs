using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Required(ErrorMessage = "O Título é obrigatório")]
    public string Titulo { get; set; }
    
    [Required(ErrorMessage = "O Gênero é obrigatório")]
    [MaxLength(50, ErrorMessage = "O Gênero deve ter no máximo {1} caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A Duração é obrigatória")]
    [Range(1, 5, ErrorMessage = "A duração deve ter no mínimo {1} e no máximo {2} minutos")]
    public int Duracao { get; set; }
}