using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Roupa : Acessorio
    {
       
        public string tecido;
        public string tamanho;

      
        public void codigo(int cod)
        {
            this.cadastrarCodigo(cod);
        }
       
      public override void cadastrarProduto()
        {
            base.cadastrarProduto();            
            Console.WriteLine("Digite o tecido");
            tecido = Console.ReadLine();
            Console.WriteLine("Digite o tamanho");
            tamanho = Console.ReadLine();

        }

       public override void mostrarProduto()
        {
            base.mostrarProduto();
            Console.WriteLine("Tamanho:{0}", tamanho);
            Console.WriteLine("Tecido:{0}", tecido);
        }
    }
}
