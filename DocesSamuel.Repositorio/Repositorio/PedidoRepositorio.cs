using DocesSamuel.Dominio.Contratos;
using DocesSamuel.Dominio.Entidades;
using DocesSamuel.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocesSamuel.Repositorio.Repositorio
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepos
    {
        public PedidoRepositorio(DocesSamuelContext docesSamuelContext) : base(docesSamuelContext)
        { }
    }
}
