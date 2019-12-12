using System;

namespace AppDesktop
{
    public class Session
    {
        private PermissaoCaixa permissaoCaixa;
        private PermissaoCliente permissaoCliente;
        private PermissaoEstoque permissaoEstoque;

        

        public Session(PermissaoCaixa permissaoCaixa, PermissaoCliente permissaoCliente, PermissaoEstoque permissaoEstoque)
        {
            this.permissaoCaixa = permissaoCaixa;
            this.permissaoCliente = permissaoCliente;
            this.permissaoEstoque = permissaoEstoque;
        }
        internal bool RequestFullPermission()
        {
            if (permissaoCaixa.Insert == 1)
            {
                return true;
            }
            return false;
        }
        internal bool RequestInsertCaixa()
        {
            if (permissaoCaixa != null && permissaoCaixa.Insert == 1)
            {
                return true;
            }
            return false;
        }

        internal bool RequestSelectEstoque()
        {
            if (permissaoEstoque != null && permissaoEstoque.Select == 1)
            {
                return true;
            }
            return false;
        }

        internal bool RequestFullPermissionCaixa()
        {
            if(permissaoCaixa != null && permissaoCaixa.Adm == 1)
            {
                return true;
            }
            return false;
        }

        internal bool RequestSelectCaixa()
        {
           if(permissaoCaixa != null && permissaoCaixa.Select == 1)
            {
                return true;
            }
            return false;
        }

        internal bool RequestFullPermissionEstoque()
        {
            if (permissaoEstoque != null && permissaoEstoque.Adm == 1)
            {
                return true;
            }
            return false;
        }

        internal bool RequestFullPermissionCliente()
        {
            if (permissaoCliente != null && permissaoCliente.Adm == 1)
            {
                return true;
            }
            return false;
        }

        internal bool RequestInsertEstoque()
        {
            if (permissaoEstoque != null && permissaoEstoque.Insert == 1)
            {
                return true;
            }
            return false;
        }

        internal bool RequestUpdateEstoque()
        {
            if (permissaoEstoque != null && permissaoEstoque.Update == 1)
            {
                return true;
            }
            return false;
        }

        internal bool RequestDeleteEstoque()
        {
            if (permissaoEstoque != null && permissaoEstoque.Delete == 1)
            {
                return true;
            }
            return false;
        }
    }
}