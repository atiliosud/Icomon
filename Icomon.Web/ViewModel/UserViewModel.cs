using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Icomon.Web.ViewModel
{
    public class UserViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter no máximo 20 caracteres")]
        public string Registration { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(150, ErrorMessage = "Este campo deve conter no máximo 150 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boss is required.")]
        public int BossId { get; set; }
        public UserViewModel Boss { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
