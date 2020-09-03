using System;
using System.Collections.Generic;
using System.Text;

namespace DocesSamuel.Dominio.Entidades
{
    public class ItemPedido
    {
        public int IdItemPed { get; set; }

        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        public double douQuant { get; set; }
    }
}
