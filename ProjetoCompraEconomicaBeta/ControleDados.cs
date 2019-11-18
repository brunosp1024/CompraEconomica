using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCompraEconomicaBeta
{
    class ControleDados
    {
        public List<Produto> listP;
        public Estabelecimento[] superM;
        public List<Deslocamento> costToUser;
        public List<Deslocamento> costToSuper;
        public Estabelecimento[] mercs;

        public ControleDados()
        {
        }

        public ControleDados(List<Produto> listP, Estabelecimento[] superM, List<Deslocamento> costToUser, List<Deslocamento> costToSuper, Estabelecimento[] mercs)
        {
            this.listP = listP;
            this.superM = superM;
            this.costToUser = costToUser;
            this.costToSuper = costToSuper;
            this.mercs = mercs;
        }

        //Método usado para definir os produtos e seus respectivos preços para cada estabelecimento
        public void AtribuirDados(List<Produto> list, Estabelecimento[] super)
        {

            list = new List<Produto>
            {
            new Produto("Arroz   ", 2.50),
            new Produto("Feijão  ", 3.90),
            new Produto("Carne   ", 18.12),
            new Produto("Banana  ", 0.60),
            new Produto("Leite   ", 3.15),
            new Produto("Farinha ", 2.05),
            new Produto("Café    ", 3.87),
            new Produto("Açucar  ", 1.90),
            new Produto("Óleo    ", 3.30),
            new Produto("Pão     ", 5.10),
            new Produto("Tomate  ", 6.00),
            new Produto("Margarina", 1.40)
            };

            super[0] = new Estabelecimento("Atacadão", list);

            list = new List<Produto>()
            {
            new Produto("Arroz   ", 2.60),
            new Produto("Feijão  ", 3.50),
            new Produto("Carne   ", 18.05),
            new Produto("Banana  ", 0.50),
            new Produto("Leite   ", 3.20),
            new Produto("Farinha ", 2.10),
            new Produto("Café    ", 3.80),
            new Produto("Açucar  ", 1.99),
            new Produto("Óleo    ", 3.25),
            new Produto("Pão     ", 5.05),
            new Produto("Tomate  ", 5.89),
            new Produto("Margarina", 1.50)
            };
            super[1] = new Estabelecimento("Hiper Queiroz", list);

            list = new List<Produto>()
            {
            new Produto("Arroz   ", 2.55),
            new Produto("Feijão  ", 3.70),
            new Produto("Carne   ", 17.90),
            new Produto("Banana  ", 0.49),
            new Produto("Leite   ", 3.29),
            new Produto("Farinha ", 2.08),
            new Produto("Café    ", 3.85),
            new Produto("Açucar  ", 1.89),
            new Produto("Óleo    ", 3.25),
            new Produto("Pão     ", 4.80),
            new Produto("Tomate  ", 6.12),
            new Produto("Margarina", 1.45)
        };
            super[2] = new Estabelecimento("Guedes", list);

            list = new List<Produto>()
        {
            new Produto("Arroz   ", 2.60),
            new Produto("Feijão  ", 3.85),
            new Produto("Carne   ", 18.20),
            new Produto("Banana  ", 0.33),
            new Produto("Leite   ", 3.05),
            new Produto("Farinha ", 2.00),
            new Produto("Café    ", 3.75),
            new Produto("Açucar  ", 1.95),
            new Produto("Óleo    ", 3.09),
            new Produto("Pão     ", 5.15),
            new Produto("Tomate  ", 6.10),
            new Produto("Margarina", 1.49)
        };
            super[3] = new Estabelecimento("Batista", list);

            list = new List<Produto>()
            {

            new Produto("Arroz   ", 2.80),
            new Produto("Feijão  ", 3.95),
            new Produto("Carne   ", 18.00),
            new Produto("Banana  ", 0.40),
            new Produto("Leite   ", 2.59),
            new Produto("Farinha ", 2.30),
            new Produto("Café    ", 3.90),
            new Produto("Açucar  ", 1.85),
            new Produto("Óleo    ", 3.10),
            new Produto("Pão     ", 5.00),
            new Produto("Tomate  ", 5.90),
            new Produto("Margarina", 1.45)
            };
            super[4] = new Estabelecimento("Foguete", list);
        }

        //Método que atribui os custos de deslocamento entre todos os pontos considerados
        public void AtribuirCustoDeslocamento(List<Deslocamento> costToSuper, List<Deslocamento> costToUser, Estabelecimento[] mercs)
        {
            //Custo com o deslocamento entre a localização do usuário e os supermercados
            costToUser.Add(new Deslocamento(mercs[0], 4.00)); //Até o Atacadão
            costToUser.Add(new Deslocamento(mercs[1], 6.20)); //Até o Hiper Queiroz
            costToUser.Add(new Deslocamento(mercs[2], 5.20)); //Até o Guedes
            costToUser.Add(new Deslocamento(mercs[3], 0.00)); //Até o Batista
            costToUser.Add(new Deslocamento(mercs[4], 5.20)); //Até o Foguete

            //Custo com o deslocamento entre os supermercados
            costToSuper.Add(new Deslocamento(mercs[0], mercs[1], 9.00)); //Atacadão até Hiper Queiroz
            costToSuper.Add(new Deslocamento(mercs[0], mercs[2], 7.00)); //Atacadão até Guedes
            costToSuper.Add(new Deslocamento(mercs[0], mercs[3], 4.00)); //Atacadão até Batista
            costToSuper.Add(new Deslocamento(mercs[0], mercs[4], 7.00)); //Atacadão até Foguete
            costToSuper.Add(new Deslocamento(mercs[1], mercs[2], 4.60)); //Hiper Queiroz até Guedes
            costToSuper.Add(new Deslocamento(mercs[1], mercs[3], 6.20)); //Hiper Queiroz até Batista
            costToSuper.Add(new Deslocamento(mercs[1], mercs[4], 5.00)); //Hiper Queiroz até Foguete
            costToSuper.Add(new Deslocamento(mercs[2], mercs[3], 5.20)); //Guedes até Batista
            costToSuper.Add(new Deslocamento(mercs[2], mercs[4], 1.70)); //Guedes até Foguete
            costToSuper.Add(new Deslocamento(mercs[3], mercs[4], 5.20)); //Batista até Foguete
        }

        //Método que busca a melhor opção de compra para o usuário com base nos itens pedidos e suas quantidades
        public string BuscarMelhorOpcao(List<TextBox> texto)
        {
            List<Produto> list = new List<Produto>(); //Lista de produtos pra serem armazenados em cada estabelecimento
            Estabelecimento[] super = new Estabelecimento[5]; //Lista de todos os estabelecimentos considerados
            List<Deslocamento> custoDeslocSuper = new List<Deslocamento>(); //Lista das distâncias entre os supermercados
            List<Deslocamento> custoDeslocInicial = new List<Deslocamento>(); //Lista das distâncias entre o usuário e os supermercados
            List<ItemPedido> pedido = new List<ItemPedido>(); //Lista que armazena o código e a quantidade de cada item

            AtribuirDados(list, super); //Método que atribui a lista de produtos e seus preços em cada estabelecimento
            AtribuirCustoDeslocamento(custoDeslocSuper, custoDeslocInicial, super); //Define o custo de deslocamento entre todos os pontos.
            AtribuirQtd(texto, pedido); //Recebe a lista de campos de texto (textBox) e armazena em pedido


            double totalfinal = 100000; //Variável que guarda o valor total da compra
            Estabelecimento maisBarato1 = new Estabelecimento(); //para guardar o primeiro supermercado temporariamente
            Estabelecimento maisBarato2 = new Estabelecimento(); //para guardar o segundo supermercados temporariamente
            //Variáveis finais para guardar um de dois supermercados
            Estabelecimento mercado1 = new Estabelecimento();
            Estabelecimento mercado2 = new Estabelecimento();

            Console.WriteLine();

            //Variáveis usadas para as estruturas "for"
            int x = 0;
            int y = 1;

            //Estrutura que analisa os custos totais da compra e guarda o menor custo.
            for (int a = 0; a < 4; a++) //Para apresentar os 5 supermercados, comparando uns com os outros.
            {
                for (int b = y; b < 5; b++) //Controla a apresentação dos demais supermercados para comparação
                {
                    double subTotal = 100000; //armazena o total temporariamente a cada iteração do segundo "for"
                    //Variáveis que armazena o total de cada supermercado de acordo com o produto mais barato
                    double total1 = 0.0;
                    double total2 = 0.0;
                    //Variáveis usadas para armazenar o custo total para cada supermercado independente de preço
                    double totalSuperMercado1 = 0.0;
                    double totalSuperMercado2 = 0.0;

                    for (int c = 0; c < pedido.Count; c++)
                    {
                        double preco1 = super[a].list[pedido[c].codproduto].preco;
                        double preco2 = super[b].list[pedido[c].codproduto].preco;
                        totalSuperMercado1 += preco1 * pedido[c].qtd;
                        totalSuperMercado2 += preco2 * pedido[c].qtd;
                        //Possibilita comparar o preço de todos os produtos, requeridos pelo usuário, entre os dois supermercados
                        if (preco1 <= preco2)
                            total1 += preco1 * pedido[c].qtd;
                        else
                            total2 += preco2 * pedido[c].qtd;
                    }

                    //Os totais obtidos serão somados com o custo de deslocamento para cada um dos dois supermercados
                    totalSuperMercado1 += custoDeslocInicial[a].custo * 2;
                    totalSuperMercado2 += custoDeslocInicial[b].custo * 2;

                    //A variável subtotal armazena o total mais barato em cada iteração do segundo "for"
                    //O total obtido dos mercados são somados com seus custos de deslocamentos vezes 2 e armazena em subtotal
                    double totalAmbos = 100000;
                    if (total1 != 0.0 && total2 != 0.0)
                    {
                        totalAmbos = total1 + total2 + custoDeslocInicial[a].custo + custoDeslocSuper[x].custo + custoDeslocInicial[b].custo;
                    }

                    //Os totais de cada mercado são comparados com o subtotal formado pelos produtos mais baratos emtre dois mercados
                    if (totalSuperMercado2 >= totalSuperMercado1 && totalSuperMercado1 < totalfinal && totalSuperMercado1 <= totalAmbos)
                    {
                        totalfinal = totalSuperMercado1;
                        mercado2 = super[a];
                        mercado1 = new Estabelecimento();
                    }
                    else if (totalSuperMercado1 > totalSuperMercado2 && totalSuperMercado2 < totalfinal && totalSuperMercado2 < totalAmbos)
                    {
                        totalfinal = totalSuperMercado2;
                        mercado2 = super[b];
                        mercado1 = new Estabelecimento();
                    }
                    else if (totalAmbos < totalfinal)
                    {
                        totalfinal = totalAmbos;
                        mercado1 = super[a];
                        mercado2 = super[b];
                    }
                        

                    // O subtotal é comparado com o total final que armazena o custo mais barato
                   
                    //Sempre incrementa mais um, pois é usada para os índices da lista de custos entre os supermercados
                    x += 1;
                }
                //Usado para incrementar mais um na variável do segundo "for" para que os mercados não sejam comparados com eles mesmos
                y += 1;
            }

            string txt = "";
            //Condição usada para armazenar os textos e os dados do estabelecimento mais barato, junto com o total
            if (mercado1.nome == null)
            {
                txt = "MELHOR OPÇÃO:              "
                    + mercado2.nome
                    + "                    "
                    + "TOTAL DA COMPRA:         R$ "
                    + totalfinal.ToString("F2");
            }
            else
            {
                txt = "MELHOR OPÇÃO:     "
                    + mercado1.nome + " e " + mercado2.nome
                    + "  "
                    + "TOTAL DA COMPRA:     R$ " + totalfinal.ToString("F2");
            }

            return txt;

        }

        //Método que recebe e armazena o código e a quantidade do item em uma lista.
        private void AtribuirQtd(List<TextBox> text, List<ItemPedido> pedido)
        {
            for (int i = 0; i < 12; i++)
            {
                if (text[i].Text != "")
                {
                    int qtd = int.Parse(text[i].Text);
                    pedido.Add(new ItemPedido(i, qtd));
                }
            }


        }
    }

}