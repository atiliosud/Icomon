using System;
using System.ComponentModel.DataAnnotations;
using Icomon.Domain.Interfaces;

namespace Icomon.Domain.Models
{
    public class User:IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter no máximo 20 caracteres")]
        public string Registration { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(150, ErrorMessage = "Este campo deve conter no máximo 150 caracteres")]
        public string Name { get; set; }

        public int BossId { get; set; }
        public User Boss { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
