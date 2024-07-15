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

        public Assinatura(string nome, double preco, int quantidade, int periodo)
            : base(nome, preco, quantidade)
        {
            Periodo = periodo;
        }
    }
}
