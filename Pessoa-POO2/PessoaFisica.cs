using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_POO2
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public string RG { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public string CorDosOlhos { get; set; }
        public string CorDaPele { get; set; }
        public string CorDosCabelos { get; set; }
        public string TipoSanguineo { get; set; }
        public string Sexo { get; set; }

        public override void Imprimir()
        {
            base.Imprimir();

            Console.WriteLine();
            Console.WriteLine("* * * DEFINIÇÃO DE PESSOA FÍSICA * * *");
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("RG: " + RG);
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Cor dos olhos: " + CorDosOlhos);
            Console.WriteLine("Cor da pele: " + CorDaPele);
            Console.WriteLine("Cor dos cabelos: " + CorDosCabelos);
            Console.WriteLine("Tipo Sanguineo: " + TipoSanguineo);
            Console.WriteLine("Sexo: " + Sexo);
        }
        
    }
}
