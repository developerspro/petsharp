using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Menu
    {
       
        public string menuOpcao()
        {
            string opcao;
            Console.WriteLine("1- Cadastrar Racao");
            Console.WriteLine("2- Cadastrar Roupa");
            Console.WriteLine("3- Cadastrar Acessorio");
            Console.WriteLine("4- Cadastrar Medicamento");
            Console.WriteLine("5- Cadastrar Brinquedo");
            Console.WriteLine("S- Sair");
            Console.WriteLine("Escolha uma opçao");
            opcao = Console.ReadLine();
            return opcao.ToUpper();


        }
    }
}
