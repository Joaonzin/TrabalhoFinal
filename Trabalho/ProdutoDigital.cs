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

        public ProdutoDigital(string nome, double preco, int quantidade, double tamanhoArquivo, string formato)
            : base(nome, preco, quantidade)
        {
            TamanhoArquivo = tamanhoArquivo;
            Formato = formato;
        }
    }
}