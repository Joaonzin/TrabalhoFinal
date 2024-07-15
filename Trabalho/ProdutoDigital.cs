using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class ProdutoDigital : Produto
    {
        public double TamanhoArquivo { get; set; }
        public string Formato { get; set; }

        public ProdutoDigital(string nome, double preco, int quantidadeEstoque, double tamanhoArquivo, string formato)
            : base(nome, preco, quantidadeEstoque)
        {
            TamanhoArquivo = tamanhoArquivo;
            Formato = formato;
        }

        public override string ToString()
        {
            return $"Produto Digital: {Nome}, Preço: {Preco:C}, Quantidade em Estoque: {QuantidadeEstoque}, Tamanho do Arquivo: {TamanhoArquivo} MB, Formato: {Formato}";
        }
    }
}
}
