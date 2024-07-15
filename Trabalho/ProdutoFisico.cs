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

        public ProdutoFisico(string nome, double preco, int quantidade, double peso, string dimensoes)
            : base(nome, preco, quantidade)
        {
            Peso = peso;
            Dimensoes = dimensoes;
        }
    }
}
