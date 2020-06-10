/*Conceitos basicos de Construtores, sobrecarga, palavra this, encapsulamento properties , 
 Auto Properties, */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace ConceitosBasicos
{
    class Produto
    {
       
        public String Nome;
        public double Preco;
        public int QtdEstoque;
             

        //Construtores 

            // Referenciando outro Construtor em um Construtor com o uso da palavra this
        
        public Produto() //Construtor padrão
        {
            QtdEstoque = 0;
            /*por padrão os atributos já recebem o valor zero*/
        }

        public Produto(String nome, double preco) : this() /*  this() referencia o construtor padrão*/
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(String nome, double preco, int qtdEstoque) : this( nome, preco) /*  this(nome, preco) referencia o construtor Produto(String nome, double preco) */
        {           
            QtdEstoque = qtdEstoque;
        }

       
        

        /*sobrecarga • É um recurso que uma classe possui de oferecer mais de uma
        operação com o mesmo nome, porém com diferentes listas de
       parâmetros*/

        /*Palavra this : é uma referencia para o proprio objeto
         * Uso comuns :
         * Diferenciar atributos de variaveis locais(em java os atributos são iniciados com letra minuscula)
         * Referenciar outro Construtor em um Construtor
         * Passar o proprio objeto como argumento na chamada de um metodo ou construtor 
             */

        public double ValorTotalEmEstoque()
        {
            return Preco * QtdEstoque;
        }

        public void AdicionarProdutos(int quantidade)
        {
            QtdEstoque += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            if (quantidade <= QtdEstoque)
            {
                QtdEstoque -= quantidade;
            }
            else
            {
                Console.WriteLine(" Quantidade no estoque menor que a solicitada ! \n");
            }


        }

        //Sobreposição 

        // A palavra  override indica que esta operação vem de outra classe 

        public override string ToString() //Retorna uma cadeira de caracteres que representa o objeto atual 
        {//Aqui definimos como o objeto será retornado na forma de String
            return this.Nome +
                ", $ " +
                this.Preco.ToString("F2", CultureInfo.InvariantCulture) +
                " "+this.QtdEstoque +
                " unidade, total : $ " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

        /* * ToString - converte um objeto para String  
        * Utilizando o método ToString podemos escolher como o objeto será representado na forma de String*/

    }
}
