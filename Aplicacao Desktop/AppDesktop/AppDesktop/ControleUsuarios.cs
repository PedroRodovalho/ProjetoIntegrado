using System;
using AppDesktop.DAO;

namespace AppDesktop
{
    public class ControleUsuarios
    {
        PermissaoDAO permissaoDAO = new PermissaoDAO();

        Usuario usuario;
        public ControleUsuarios(Usuario usuario)
        {
            this.usuario = usuario;
        }

        internal PermissaoCaixa PedePermissaoCaixa()
        {
           
           PermissaoCaixa permissaoCaixa = permissaoDAO.BuscaPermissaoCaixa(usuario.Id_permissao);
            return permissaoCaixa;
        }

        internal PermissaoCliente PedePermissaoCliente()
        {
            return permissaoDAO.BuscaPermissaoCliente(usuario.Id_permissao);
        }

        internal PermissaoEstoque PedePermissaoEstoque()
        {
            return permissaoDAO.BuscaPermissaoEstoque(usuario.Id_permissao);
        }
    }
}