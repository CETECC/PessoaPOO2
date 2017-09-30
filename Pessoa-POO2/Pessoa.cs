using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_POO2
{
    public class Pessoa
    {
        public string NomeRazaoSocial { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }

        // MÉTODO CONSTRUTOR DE PESSOA
        public Pessoa()
        {
            Endereco = new Endereco();
        }

        // MÉTODO QUE IMPRIME UMA PESSOA
        public virtual void Imprimir()
        {
            Console.WriteLine("* * * DEFINIÇÃO DE PESSOA * * *");
            Console.WriteLine("Nome ou Razão Social: " + NomeRazaoSocial);
            Console.WriteLine("Data de Nascimento: " + DataNascimento.ToShortDateString());
            Console.WriteLine("Endereço: " + Endereco);
        }
    }
}
