using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Racao : Produto
    {
        public string sabor;
        public bool corante;
        public string tipo;//filhote ou adulto.

        public override void cadastrarProduto()
        {
            base.cadastrarProduto();
            Console.WriteLine("Digite o sabor");
            sabor = Console.ReadLine();
            Console.WriteLine("Tem corante?[s/n]");
            var escolha = Console.ReadLine();
            if (escolha.ToLower().Equals("s"))
            {
                corante = true;
            } else
            {
                corante = false;
            }
            Console.WriteLine("Digite o tipo");
            tipo = Console.ReadLine();
        }

        public override void mostrarProduto()
        {
            base.mostrarProduto();
            Console.WriteLine("Sabor:"+sabor);
            if (corante)
            {
                Console.WriteLine("Tem corante!");
            }
            else
            {
                Console.WriteLine("Sem corante!");
            }
            
            Console.WriteLine("Tipo:"+tipo);
        }
    }
}
