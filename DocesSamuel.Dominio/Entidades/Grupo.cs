using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DocesSamuel.Dominio.Entidades
{
    public class Grupo
    {
        public int IdGrupo { get; set; }

        [Required(ErrorMessage = "Informe nome do usuário")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mínimo de caracteres:{2}; Máximo de caracteres:{1}")]
        public string strNmGrupo { get; set; }
    }
}
