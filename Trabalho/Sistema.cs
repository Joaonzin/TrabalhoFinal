using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    
    
        public class Sistema
        {
            private List<Usuario> Usuarios { get; set; }
            private List<Produto> Produtos { get; set; }
            private List<Venda> Vendas { get; set; }
            private List<CupomDesconto> Cupons { get; set; }

            public Sistema()
            {
                Usuarios = new List<Usuario>
            {
                new Usuario { Nome = "Alice", Email = "alice@example.com", Endereco = "Rua 1" },
                new Usuario { Nome = "Bob", Email = "bob@example.com", Endereco = "Rua 2" },
                new Usuario { Nome = "Carol", Email = "carol@example.com", Endereco = "Rua 3" },
                new Usuario { Nome = "David", Email = "david@example.com", Endereco = "Rua 4" },
                new Usuario { Nome = "Eve", Email = "eve@example.com", Endereco = "Rua 5" },
                new Usuario { Nome = "Frank", Email = "frank@example.com", Endereco = "Rua 6" },
                new Usuario { Nome = "Grace", Email = "grace@example.com", Endereco = "Rua 7" },
                new Usuario { Nome = "Heidi", Email = "heidi@example.com", Endereco = "Rua 8" },
                new Usuario { Nome = "Ivan", Email = "ivan@example.com", Endereco = "Rua 9" },
                new Usuario { Nome = "Judy", Email = "judy@example.com", Endereco = "Rua 10" }
            };

                Produtos = new List<Produto>
            {
                new Produto("Produto1", 10.00, 50),
                new Produto("Produto2", 15.00, 30),
                new Produto("Produto3", 20.00, 40),
                new Produto("Produto4", 25.00, 20),
                new Produto("Produto5", 30.00, 10),

                new Servico("Corte de Cabelo", 50.00, 5, 1),
                new Servico("Massagem Relaxante", 100.00, 10, 2),
                new Servico("Consultoria Financeira", 150.00, 15, 3),
                new Servico("Treinamento Pessoal", 200.00, 20, 4),
                new Servico("Aula de Yoga", 250.00, 25, 5),

                new Assinatura("Netflix Mensal", 5.00, 100, 1),
                new Assinatura("Spotify Premium", 10.00, 200, 2),
                new Assinatura("Amazon Prime", 15.00, 300, 3),
                new Assinatura("HBO Max", 20.00, 400, 4),
                new Assinatura("Disney+", 25.00, 500, 5),

                new ProdutoDigital("Ebook", 10.00, 300, 0.5, "PDF"),
                new ProdutoDigital("Curso Online", 50.00, 50, 10.0, "Video"),
                new ProdutoDigital("Jogo", 40.00, 150, 15.0, "Exe"),
                new ProdutoDigital("Software", 100.00, 200, 2.5, "Instalador"),
                new ProdutoDigital("Revista Digital", 5.00, 500, 0.2, "PDF"),

                new ProdutoFisico("Notebook", 2000.00, 10, 2.5, "30x20x5 cm"),
                new ProdutoFisico("Smartphone", 1000.00, 20, 0.5, "15x7x1 cm"),
                new ProdutoFisico("Tablet", 1500.00, 15, 1.0, "25x17x0.7 cm"),
                new ProdutoFisico("Monitor", 800.00, 8, 3.5, "50x30x10 cm"),
                new ProdutoFisico("Teclado", 100.00, 50, 0.8, "45x15x2 cm"),
            };

                Cupons = new List<CupomDesconto>
            {
                new CupomDesconto("DESCONTO10", 10),
                new CupomDesconto("PROMO15", 15),
                new CupomDesconto("SALE20", 20),
                new CupomDesconto("OFF25", 25),
                new CupomDesconto("WINTER30", 30),
            };

                Vendas = new List<Venda>();
            }

            public void IniciarSistema()
            {
                int acaoSelecionada = -1;
                while (acaoSelecionada != 7)
                {
                    ExibirMenu();
                    acaoSelecionada = SolicitarAcaoUsuario();
                    RealizarAcaoSelecionada(acaoSelecionada);
                }
            }

            private void ExibirMenu()
            {
                Console.WriteLine("-------------------------Menu Principal:-------------------------------");
                Console.WriteLine("1. Adicionar Usuário");
                Console.WriteLine("2. Listar Usuários");
                Console.WriteLine("3. Adicionar Produto");
                Console.WriteLine("4. Listar Produtos");
                Console.WriteLine("5. Realizar Venda");
                Console.WriteLine("6. Listar Vendas");
                Console.WriteLine("7. Sair");
            }

            private int SolicitarAcaoUsuario()
            {
                int acao = -1;
                while (acao < 1 || acao > 7)
                {
                    Console.WriteLine("Digite a ação que você deseja realizar:");
                    acao = int.Parse(Console.ReadLine());

                    if (acao > 7 || acao < 1)
                    {
                        Console.WriteLine("Número inválido!!\nFavor digite um número válido.");
                    }
                }
                return acao;
            }

            private void RealizarAcaoSelecionada(int acaoSelecionada)
            {
                switch (acaoSelecionada)
                {
                    case 1:
                        AdicionarUsuario();
                        break;
                    case 2:
                        ListarUsuarios();
                        break;
                    case 3:
                        AdicionarProduto();
                        break;
                    case 4:
                        ListarProdutos();
                        break;
                    case 5:
                        RealizarVenda();
                        break;
                    case 6:
                        ListarVendas();
                        break;
                    case 7:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                }
            }

            private void AdicionarUsuario()
            {
                Console.WriteLine("Digite o nome do usuário:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o email do usuário:");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o endereço do usuário:");
                string endereco = Console.ReadLine();

                Usuarios.Add(new Usuario { Nome = nome, Email = email, Endereco = endereco });
                Console.WriteLine("Usuário adicionado com sucesso!");
            }

            private void ListarUsuarios()
            {
                Console.WriteLine("Lista de Usuários:");
                Console.WriteLine("-------------------------------------------------");
                foreach (var usuario in Usuarios)
                {
                    Console.WriteLine($"Nome: {usuario.Nome}");
                    Console.WriteLine($"Email: {usuario.Email}");
                    Console.WriteLine($"Endereço: {usuario.Endereco}");
                    Console.WriteLine("-------------------------------------------------");
                }
            }

            private void AdicionarProduto()
            {
                Console.WriteLine("Digite o nome do produto:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto:");
                double preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade em estoque do produto:");
                int quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o tipo de produto (1 - Comum, 2 - Serviço, 3 - Assinatura, 4 - Digital, 5 - Físico):");
                int tipo = int.Parse(Console.ReadLine());

                Produto produto;
                switch (tipo)
                {
                    case 2:
                        Console.WriteLine("Digite a duração do serviço:");
                        int duracao = int.Parse(Console.ReadLine());
                        produto = new Servico(nome, preco, quantidade, duracao);
                        break;
                    case 3:
                        Console.WriteLine("Digite o período da assinatura:");
                        int periodo = int.Parse(Console.ReadLine());
                        produto = new Assinatura(nome, preco, quantidade, periodo);
                        break;
                    case 4:
                        Console.WriteLine("Digite o tamanho do arquivo do produto digital:");
                        double tamanhoArquivo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o formato do arquivo do produto digital:");
                        string formato = Console.ReadLine();
                        produto = new ProdutoDigital(nome, preco, quantidade, tamanhoArquivo, formato);
                        break;
                    case 5:
                        Console.WriteLine("Digite o peso do produto físico:");
                        double peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite as dimensões do produto físico:");
                        string dimensoes = Console.ReadLine();
                        produto = new ProdutoFisico(nome, preco, quantidade, peso, dimensoes);
                        break;
                    default:
                        produto = new Produto(nome, preco, quantidade);
                        break;
                }

                Produtos.Add(produto);
                Console.WriteLine("Produto adicionado com sucesso!");
            }

            private void ListarProdutos()
            {
                Console.WriteLine("Lista de Produtos:");
                Console.WriteLine("-------------------------------------------------");
                foreach (var produto in Produtos)
                {
                    Console.WriteLine($"Nome: {produto.Nome}");
                    Console.WriteLine($"Preço: R${produto.Preco:F2}");
                    Console.WriteLine($"Quantidade em Estoque: {produto.Quantidade}");

                    if (produto is Servico servico)
                    {
                        Console.WriteLine($"Tipo: Serviço");
                        Console.WriteLine($"Duração: {servico.Duracao} horas");
                    }
                    else if (produto is Assinatura assinatura)
                    {
                        Console.WriteLine($"Tipo: Assinatura");
                        Console.WriteLine($"Período: {assinatura.Periodo} meses");
                    }
                    else if (produto is ProdutoDigital produtoDigital)
                    {
                        Console.WriteLine($"Tipo: Produto Digital");
                        Console.WriteLine($"Tamanho do Arquivo: {produtoDigital.TamanhoArquivo} GB");
                        Console.WriteLine($"Formato: {produtoDigital.Formato}");
                    }
                    else if (produto is ProdutoFisico produtoFisico)
                    {
                        Console.WriteLine($"Tipo: Produto Físico");
                        Console.WriteLine($"Peso: {produtoFisico.Peso} kg");
                        Console.WriteLine($"Dimensões: {produtoFisico.Dimensoes}");
                    }
                    else
                    {
                        Console.WriteLine($"Tipo: Produto Comum");
                    }

                    Console.WriteLine("-------------------------------------------------");
                }
            }

            private void RealizarVenda()
            {
                Console.WriteLine("Digite o nome do usuário que está realizando a compra:");
                string nomeUsuario = Console.ReadLine();
                var usuario = Usuarios.Find(u => u.Nome.Equals(nomeUsuario, StringComparison.OrdinalIgnoreCase));

                if (usuario == null)
                {
                    Console.WriteLine("Usuário não encontrado!");
                    return;
                }

                Console.WriteLine("Digite o nome do produto que está sendo comprado:");
                string nomeProduto = Console.ReadLine();
                var produto = Produtos.Find(p => p.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));

                if (produto == null || produto.Quantidade == 0)
                {
                    Console.WriteLine("Produto não encontrado ou fora de estoque!");
                    return;
                }

                Console.WriteLine("Digite a quantidade que está sendo comprada:");
                int quantidade = int.Parse(Console.ReadLine());

                if (quantidade > produto.Quantidade)
                {
                    Console.WriteLine("Quantidade solicitada não disponível em estoque!");
                    return;
                }

                Console.WriteLine("Digite o código do cupom de desconto (ou pressione Enter para continuar sem cupom):");
                string codigoCupom = Console.ReadLine();
                CupomDesconto cupom = null;

                if (!string.IsNullOrWhiteSpace(codigoCupom))
                {
                    cupom = Cupons.Find(c => c.Codigo.Equals(codigoCupom, StringComparison.OrdinalIgnoreCase));

                    if (cupom == null)
                    {
                        Console.WriteLine("Cupom de desconto inválido!");
                        return;
                    }
                }

                double valorTotal = produto.Preco * quantidade;

                if (cupom != null)
                {
                    double desconto = (valorTotal * cupom.Desconto) / 100;
                    valorTotal -= desconto;
                    Console.WriteLine($"Cupom aplicado! Desconto de {cupom.Desconto}%.");
                }

                produto.Quantidade -= quantidade;

                Vendas.Add(new Venda
                {
                    Usuario = usuario,
                    Produto = produto,
                    Quantidade = quantidade,
                    ValorTotal = valorTotal,
                    DataVenda = DateTime.Now
                });

                Console.WriteLine($"Venda realizada com sucesso! Valor Total: R${valorTotal:F2}");
            }

            private void ListarVendas()
            {
                Console.WriteLine("Lista de Vendas:");
                Console.WriteLine("-------------------------------------------------");
                foreach (var venda in Vendas)
                {
                    Console.WriteLine($"Data: {venda.DataVenda}");
                    Console.WriteLine($"Usuário: {venda.Usuario.Nome}");
                    Console.WriteLine($"Produto: {venda.Produto.Nome}");
                    Console.WriteLine($"Quantidade: {venda.Quantidade}");
                    Console.WriteLine($"Valor Total: R${venda.ValorTotal:F2}");
                    Console.WriteLine("-------------------------------------------------");
                }
            }
        }
    }

