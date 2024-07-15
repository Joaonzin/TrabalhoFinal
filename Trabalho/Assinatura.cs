using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Assinatura : Produto
    {
        public int Periodo { get; set; }

        public Assinatura(string nome, double preco, int quantidadeEstoque, int periodo)
            : base(nome, preco, quantidadeEstoque)
        {
            Periodo = periodo;
        }

        public override string ToString()
        {
            return $"Assinatura: {Nome}, Preço: {Preco:C}, Quantidade em Estoque: {QuantidadeEstoque}, Período: {Periodo} meses";
        }
    }
}

}
