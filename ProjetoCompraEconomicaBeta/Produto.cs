using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompraEconomicaBeta
{
    class Produto
    {
        public int codigo;
        public string nome;
        public double preco;

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
    }
}
