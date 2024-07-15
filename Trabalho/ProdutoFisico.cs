using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class ProdutoFisico : Produto
    {
        public double Peso { get; set; }
        public string Dimensoes { get; set; }

        public ProdutoFisico(string nome, double preco, int quantidadeEstoque, double peso, string dimensoes)
            : base(nome, preco, quantidadeEstoque)
        {
            Peso = peso;
            Dimensoes = dimensoes;
        }

        public override string ToString()
        {
            return $"Produto Físico: {Nome}, Preço: {Preco:C}, Quantidade em Estoque: {QuantidadeEstoque}, Peso: {Peso} kg, Dimensões: {Dimensoes}";
        }
    }
}
}
