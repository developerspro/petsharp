using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Menu menu = new Menu();
            opcao = menu.menuOpcao();
            do
            {
                switch (opcao)
                {
                    case "1":
                        Racao racao = new Racao();
                        racao.cadastrarProduto();
                        Console.ReadKey();
                        Console.Clear();
                        opcao = menu.menuOpcao();
                        break;
                    case "2":
                        Roupa roupa = new Roupa();
                        roupa.cadastrarProduto();
                        Console.ReadKey();
                        Console.Clear();
                        opcao = menu.menuOpcao();
                        break;
                    case "3":
                        Acessorio acessorio = new Acessorio();
                        acessorio.cadastrarProduto();
                        Console.ReadKey();
                        Console.Clear();
                        opcao = menu.menuOpcao();
                        break;
                    case "4":
                        Medicamento medicamento = new Medicamento();
                        medicamento.cadastrarProduto();
                        Console.ReadKey();
                        Console.Clear();
                        opcao = menu.menuOpcao();
                        break;
                    case "5":
                        Brinquedo brinquedo = new Brinquedo();
                        brinquedo.cadastrarProduto();
                        Console.ReadKey();
                        Console.Clear();
                        opcao = menu.menuOpcao();
                        break;

                    case "S":
                        Console.WriteLine("Encerrando o programa...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opcao invalida!");
                        Console.ReadKey();
                        Console.Clear();
                        opcao = menu.menuOpcao();
                        break;
                }
            } while (true);

         
           
        }
    }
}
