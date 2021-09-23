using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Brinquedo : Acessorio
    {
        public string medida;
        public string material;

        public Brinquedo(string n) : base(n)
        {

        }

        public override void cadastrarProduto()
        {
            base.cadastrarProduto();
            Console.WriteLine("Digite a medida");
            medida = Console.ReadLine();
            Console.WriteLine("Digite o material");
            material = Console.ReadLine();
        }

        public override void mostrarProduto()
        {
            base.mostrarProduto();
            Console.WriteLine("Medida:"+medida);
            Console.WriteLine("Material:" + material);
        }
    }
}
