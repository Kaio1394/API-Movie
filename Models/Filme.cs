using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get;  set; }
        [Required(ErrorMessage = "O campos Tìtulo é obrigatório.")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "O campos Diretor é obrigatório.")]
        public string Diretor { get; set; }
        
        [StringLength(30, ErrorMessage = "O Gênero não pode passar de 30 caracteres.")]
        public string Genero { get; set; }
        
        [Range(1, 600, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 600 minutos.")]
        public int Duracao { get; set; }
        
    }
}
