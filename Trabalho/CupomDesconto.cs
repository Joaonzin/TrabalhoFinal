using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class CupomDesconto
    {
        public string Codigo { get; set; }
        public double Desconto { get; set; } // Representa o desconto em porcentagem

        public CupomDesconto(string codigo, double desconto)
        {
            Codigo = codigo;
            Desconto = desconto;
        }
    }
}
