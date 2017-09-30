using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_POO2
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }


        // modo melhor
        public override string ToString()
        {
            string resultado = Logradouro;
            resultado += "\r\nNúmero: " + Numero;
            resultado += "\r\nComplemento: " + Complemento;
            resultado += "\r\nBairro: " + Bairro;
            resultado += "\r\nCidade: " + Cidade;
            resultado += "\r\nEstado: " + UF;
            resultado += "\r\nCEP: " + Cep;
            return resultado;
        }
    }


}


