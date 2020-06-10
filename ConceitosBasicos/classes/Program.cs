using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace ConceitosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = null;
            int op = 0;

            do
            {
              op = Menu();
                switch (op)
                {
                    case 1:

                        CadastrarProduto(p);

                        break;
                    case 2:

                      
                        break;

                    case 3:
                       
                        break;

                    case 4:

                        Console.WriteLine(" Programa encerrado ! \n");
                        break;
                }


            } while (op != 4);           

            Console.Read();

        }


        public static int Menu()
        { 
            Console.WriteLine(" Menu de Opções : \n" +
                "1- Cadastrar Produto : \n" +
                "2- Adicionar Produto : \n" +
                "3- Remover Produto : \n"+
                "4- Sair \n");

            return int.Parse(Console.ReadLine());
        }

        public static void CadastrarProduto(Produto p)
        {
            
            Console.WriteLine(" Entre com os dados do Produto \n");

            Console.WriteLine(" Entre com o nome do produto :");
            String nome = Console.ReadLine();

            Console.WriteLine(" Entre com o preço do produto :");
             double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*Console.WriteLine(" Entre com a quantidade do estoque do produto :");
            int qtdEstoque = int.Parse(Console.ReadLine());*/

            //p = new Produto(nome, preco);

            /* Sintaxe alternativa para criação de objeto sem utilizar os construtores 
             informando diretamente os valores 
            p = new Produto { Nome = " ventilador", Preco = 30, QtdEstoque = 2 }; */

            MostrarProduto(p);

            AdicionarProduto(p);
            RemoverProduto(p);

        }

        public static void AdicionarProduto(Produto p)
        {
            Console.WriteLine(" Entre com a quantidade que será adicionada ao estoque : \n");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            MostrarProduto(p);

        }

        public static void RemoverProduto(Produto p)
        {
            Console.WriteLine(" Entre com a quantidade que será removida do estoque : \n");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            MostrarProduto(p);
        }
        public static void MostrarProduto(Produto p)
        {
            Console.WriteLine(" Produto :" + p);
            Console.WriteLine(" \n");
        }
    }
}
