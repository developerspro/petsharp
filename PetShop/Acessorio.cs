using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Acessorio : Produto
    {
        protected string cor;
        public string tamanho;

        public Acessorio(string n) : base(n)
        {
        }
    }
}
