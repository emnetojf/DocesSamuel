using DocesSamuel.Dominio;
using DocesSamuel.Dominio.Contratos;
using DocesSamuel.Repositorio.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocesSamuel.Repositorio.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepos
    {

        public UsuarioRepositorio(DocesSamuelContext docesSamuelContext) : base(docesSamuelContext)
        { }

        public Usuario ListUsr(string strEmail, string strSenha)
        {
            return _docesSamuelContext.Usuarios.FirstOrDefault(usr => usr.strEmail == strEmail && usr.strSenha == strSenha);
        }

        public Usuario ListUsr(string strEmail)
        {
            return _docesSamuelContext.Usuarios.FirstOrDefault(usr => usr.strEmail == strEmail);
        }
    }
}
