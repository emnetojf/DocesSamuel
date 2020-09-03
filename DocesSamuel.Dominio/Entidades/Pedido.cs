using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DocesSamuel.Dominio.Entidades
{
    public class Pedido
    {
        public int IdPed { get; set; }

        [Required(ErrorMessage = "Informe nome do usuário")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime dtPedido { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        [StringLength(200, ErrorMessage = "Máximo de caracteres:{1}")]
        public string strObs { get; set; }

    }
}
