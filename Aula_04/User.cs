using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04
{
    public class Usuario
    {
        // Atributos (estado)
        private string nome;
        private string senha;
        private int anoNasc;

        // Propriedades
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                if (value.Count() < 6)
                {
                    throw new Exception("Senha inválida!");
                }
                senha = value;
            }
        }

        public int AnoNasc
        {
            get
            {
                return anoNasc;
            }
            set
            {
                if (value > DateTime.Now.Year)
                {
                    throw new Exception("Ano de nascimento inválido!");
                }
                anoNasc = value;
            }
        }

        // Métodos (comportamento)
        public void imprimirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Ano de nascimento: " + anoNasc);
        }

    }
}
