using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"{Nome} - R${Preco:F2} - Quantidade: {Quantidade}";
        }
    }
}
