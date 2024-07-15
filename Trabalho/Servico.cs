using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Servico : Produto
    {
        public int Duracao { get; set; }

        public Servico(string nome, double preco, int quantidadeEstoque, int duracao)
            : base(nome, preco, quantidadeEstoque)
        {
            Duracao = duracao;
        }

        public override string ToString()
        {
            return $"Serviço: {Nome}, Preço: {Preco:C}, Quantidade em Estoque: {QuantidadeEstoque}, Duração: {Duracao} horas";
        }
    }
}
}
