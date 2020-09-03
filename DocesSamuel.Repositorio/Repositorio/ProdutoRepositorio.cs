using DocesSamuel.Dominio.Contratos;
using DocesSamuel.Dominio.Entidades;
using DocesSamuel.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocesSamuel.Repositorio.Repositorio
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepos
    {
        public ProdutoRepositorio(DocesSamuelContext docesSamuelContext) : base(docesSamuelContext)
        { }
    }
}
