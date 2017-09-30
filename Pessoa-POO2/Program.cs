using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica eu = new PessoaFisica();
            eu.NomeRazaoSocial = "Marcio, o Senhor";
            eu.DataNascimento = new DateTime(1975, 11, 14);

            eu.Endereco.Logradouro = "Travessa Vai que é Mole";
            eu.Endereco.Numero = 171;
            eu.Endereco.Bairro = "Vila dos Trouxas";
            eu.Endereco.Cidade = "Londres";
            eu.Endereco.UF = "MG";
            eu.Endereco.Cep = "11223444";

            eu.Altura = 1.75f;
            eu.Peso = 103.0f;
            eu.CorDaPele = "Verde Escritório";
            eu.CorDosCabelos = "Castanho";
            eu.CorDosOlhos = "Castanho";
            eu.CPF = "123.345.456-78";
            eu.RG = "23.345.456-5";
            eu.Sexo = "Masculino";
            eu.TipoSanguineo = "A+";

            // Imprimir as informações na tela
            eu.Imprimir();

            PessoaJuridica empresa = new PessoaJuridica();

            //TODO: Implementar as chamadas da pessoa juridica
        }
    }
}
