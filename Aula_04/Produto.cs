using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04
{
    public class Produto
    {
        private int codProduto;
        private string descricao;
        private float preco;


        public int CodProduto
        {
            get
            {
                return codProduto;
            }
            set
            {
                codProduto = value;
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }

        public float Preco
        {
            get
            {
                return preco;
            }
            set
            {
                preco = value;
            }
        }

        public float aumentarPreco(float porcentagem)
        {
            float aumentar;

            aumentar = preco + ((preco * porcentagem) / 100);

            return aumentar;
        }

        public float calcularImposto(float porcentagem)
        {
            float imposto;

            imposto = (preco * porcentagem)/100;

            return imposto;
        }

        public void imprimirDados()
        {
            Console.WriteLine("============================");
            Console.WriteLine("Código do Produto: " + codProduto);
            Console.WriteLine("Preço: " + preco);
            Console.WriteLine("Descrição: " + descricao);
            Console.WriteLine("============================");
        }
    }
}
