using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompraEconomicaBeta
{
    class ItemPedido
    {
        public int codproduto;
        public int qtd;

        public ItemPedido(int codproduto, int qtd)
        {
            this.codproduto = codproduto;
            this.qtd = qtd;
        }
    }
}
