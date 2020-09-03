using System;
using System.ComponentModel.DataAnnotations;

namespace DocesSamuel.Dominio
{
    public class Usuario
    {
        public int IdUsr { get; set; }

        [Required (ErrorMessage = "Informe nome do usuário")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mínimo de caracteres:{2}; Máximo de caracteres:{1}")]
        public string strNmUsr { get; set; }

        [Required(ErrorMessage = "Informe email do usuário")]
        [EmailAddress(ErrorMessage = "Informe um email válido")]
        public string strEmail { get; set; }

        [Required(ErrorMessage = "Informe senha do usuário")]
        [StringLength(8, MinimumLength = 6, ErrorMessage = "Mínimo de caracteres:{2}; Máximo de caracteres:{1}")]
        public string strSenha { get; set; }
        
        public Boolean booAdmin { get; set; }
    }
}
