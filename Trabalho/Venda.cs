using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Venda
    {
        public Usuario Cliente { get; set; }
        public Produto ProdutoVendido { get; set; }
        public double ValorTotal { get; set; }

        public Venda(Usuario cliente, Produto produto)
        {
            Cliente = cliente;
            ProdutoVendido = produto;
            ValorTotal = produto.Preco;
        }

        public override string ToString()
        {
            return $"Venda: Cliente - {Cliente.Nome}, Produto - {ProdutoVendido.Nome}, Valor Total - {ValorTotal:C}";
        }
    }
}
}
