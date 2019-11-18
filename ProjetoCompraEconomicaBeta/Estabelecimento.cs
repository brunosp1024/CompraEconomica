using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompraEconomicaBeta
{
    class Estabelecimento
    {
        public string nome;
        public List<Produto> list;

        public Estabelecimento()
        {
        }

        public Estabelecimento(string nome, List<Produto> list)
        {
            this.nome = nome;
            this.list = list;
        }

        public override string ToString()
        {
            return "\nSupermercado " + nome;

        }
    }
}
