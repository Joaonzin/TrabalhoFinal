using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Venda
    {
        public Usuario Usuario { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataVenda { get; set; }
    }
}