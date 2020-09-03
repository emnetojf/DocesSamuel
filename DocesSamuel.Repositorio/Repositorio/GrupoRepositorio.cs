using DocesSamuel.Dominio.Contratos;
using DocesSamuel.Dominio.Entidades;
using DocesSamuel.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocesSamuel.Repositorio.Repositorio
{
    public class GrupoRepositorio : BaseRepositorio<Grupo>, IGrupoRepos
    {
        public GrupoRepositorio(DocesSamuelContext docesSamuelContext) : base(docesSamuelContext)
        { }
    }
}
