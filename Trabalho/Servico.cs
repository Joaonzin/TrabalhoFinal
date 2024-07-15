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

        public Servico(string nome, double preco, int quantidade, int duracao)
            : base(nome, preco, quantidade)
        {
            Duracao = duracao;
        }
    }
}