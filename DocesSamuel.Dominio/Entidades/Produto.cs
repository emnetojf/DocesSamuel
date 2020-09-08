using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DocesSamuel.Dominio.Entidades
{
    public class Produto
    {
        public int IdProd { get; set; }

        [Required(ErrorMessage = "Informe nome do produto")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mínimo de caracteres:{2}; Máximo de caracteres:{1}")]
        public string strNmProd { get; set; }

        [Required(ErrorMessage = "Informe preço do produto")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double douPrecoUnit { get; set; }

        public string strNomeArq { get; set; }
        
        public ICollection<ItemPedido> itemPedidos { get; set; }
    }
}
