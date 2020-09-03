using System;
using System.Collections.Generic;
using System.Text;

namespace DocesSamuel.Dominio.Contratos
{
    public interface IUsuarioRepos : IBaseRepos<Usuario>
    {
        Usuario ListUsr(string strEmail, string strSenha);
        Usuario ListUsr(string strEmail);
    }
}
