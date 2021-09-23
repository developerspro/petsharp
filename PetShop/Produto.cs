using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Produto
    {
        private int codigo;
        public string nome;
        public string descricao;
        protected double preco;
        protected double peso;
        protected string marca;
        public string validade;

        public Produto(string n)
        {
            Console.WriteLine("Criando: "+n);
        }

        public Produto()
        {

        }

        public Produto(int cod, string nome)
        {

        }
        public virtual void cadastrarProduto()
        {
            Console.WriteLine("Digite o codigo");
            cadastrarCodigo(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a descricao");
            descricao = Console.ReadLine();
            Console.WriteLine("Digite o preco");
            cadastrarPreco(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o peso");
            cadastrarPeso(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a Marca");
            marca = Console.ReadLine();
            Console.WriteLine("Digite a validade");
            validade = nome = Console.ReadLine();
        }
        protected void cadastrarCodigo(int cod)
        {
            this.codigo = cod;
        }
        public void mostrarCodigo()
        {
            Console.WriteLine("Código: "+this.codigo);
        }
        public virtual void mostrarProduto()
        {
            Console.WriteLine("Nome:{0}", nome);
            Console.WriteLine("Descricao:{0}", descricao);
            Console.WriteLine("Preco:{0}", preco);
            Console.WriteLine("Peso:{0}", peso);
            Console.WriteLine("Marca:{0}", marca);
            Console.WriteLine("Validade:{0}", validade);
        }
        public void cadastrarMarca(string marca)
        {
            this.marca = marca.ToUpper();
        }
        public void cadastrarPreco(double valor)
        {
            if (valor < 0)
            {
                preco = 0;
            } else
            {
                preco = valor;
            }
        }
        public void cadastrarPeso(double valor)
        {
            if (valor < 1)
            {
                peso = 1;
            }
            else
            {
                peso = valor;
            }
        }

    }
}
