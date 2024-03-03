using CadastroProduto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.Repositories
{
    public abstract class ProdutoRepository
    {
        /// <summary>
        /// 1º Digito: public abstract void Exportar(ProdutoRepository produto);
        /// 1º.1 :Importo using:
        /// </summary>
        public abstract void Exportar(Produto produto);


    }
}
