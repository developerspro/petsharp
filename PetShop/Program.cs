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
            Roupa rp = new Roupa("Roupa");
            Produto p = new Produto("Produto");
            Produto pd = new Produto(1,"produto");
            Racao rc = new Racao("Criando Racao");
            rc.cadastrarProduto();
            rc.mostrarProduto();
            //rp.cadastrarProduto();
            Console.ReadKey();
           
        }
    }
}
