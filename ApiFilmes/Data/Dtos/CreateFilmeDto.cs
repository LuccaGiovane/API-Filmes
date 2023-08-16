using System.ComponentModel.DataAnnotations;

namespace ApiFilmes.Data.Dtos
{
    public class CreateFilmeDto
    {

        [Required(ErrorMessage = "Título Obrigatório!")]
        [MaxLength(50, ErrorMessage = "O Título não deve exceder 50 caracteres!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Gênero Obrigatório!")]
        [StringLength(50, ErrorMessage = "O Gênero não deve exceder 50 caracteres!")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Duração Obrigatória!")]
        [Range(70, 600, ErrorMessage = "A Duração deve ser entre 70 e 600 minutos!")]
        public int Duracao { get; set; }
    }
}
