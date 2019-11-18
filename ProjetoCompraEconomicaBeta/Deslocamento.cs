using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompraEconomicaBeta
{
    class Deslocamento
    {
        public double custo;
        public Estabelecimento superMercInicio;
        public Estabelecimento superMercFinal;

        public Deslocamento(Estabelecimento superMercInicio, Estabelecimento superMercFinal, double custo)
        {
            this.superMercInicio = superMercInicio;
            this.superMercFinal = superMercFinal;
            this.custo = custo;
        }

        public Deslocamento(Estabelecimento superMercFinal, double custo)
        {
            this.superMercFinal = superMercFinal;
            this.custo = custo;
        }
    }
}
