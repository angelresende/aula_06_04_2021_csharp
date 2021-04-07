using System;
using System.Windows.Forms;

namespace Aula_04
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario o_Usuario = new Usuario();

                o_Usuario.Nome = "Maria";
                o_Usuario.AnoNasc = 1980;
                o_Usuario.Senha = "123456";

                // Imprime os dados do usuário
                o_Usuario.imprimirDados();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Tratamento de Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Livro o_Livro = new Livro();
            float desconto;

            o_Livro.Titulo = "A Arte da Guerra";
            o_Livro.Preco = 100.00F;

            o_Livro.imprimirDados();

            desconto = o_Livro.efetuarDesconto(10);
            Console.WriteLine("Valor com desconto: " + desconto);

            o_Livro.efetuarVenda(5);

            o_Livro.imprimirDados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produto o_produto = new Produto();
            float aumentar;
            float imposto;

            o_produto.CodProduto = 12579;
            o_produto.Descricao = "Headphone";
            o_produto.Preco = 59.95f;

            o_produto.imprimirDados();

            aumentar = o_produto.aumentarPreco(7);
            Console.WriteLine("Valor do produto com o aumento: " + aumentar);

            imposto = o_produto.calcularImposto(7);
            Console.WriteLine("Valor do imposto do produto: " + imposto);
        }
    }
}
