using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA_X2A
{
    internal class dadosFun
    {
        

            public string Nome { get; set; }
            public string Cpf { get; set; }
            public string Rg { get; set; }
            public DateTime dataNasc { get; set; }
            public string Email { get; set; }
            public string Telefone1 { get; set; }
            public string Telefone2 { get; set; }
            public string Genero { get; set; }
            public string estadoCivil { get; set; }
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public int Numero { get; set; }
            public string Bairro { get; set; }
            public string Estado { get; set; }
            public string Municipio { get; set; }
            public string Cargo { get; set; }
            public string Departamento { get; set; }
            public string DataAdmissao { get; set; }
            public string Banco { get; set; }
            public double Salario { get; set; }
            public string Agencia { get; set; }
            public string Conta { get; set; }
            

            public dadosFun(string nome, string cpf, string rg, string telefone1, string telefone2, string genero, string estadoCivil, string cep, string logradouro, int numero, string bairro, string estado, string municipio, string cargo, string departamento, string dataAdmissao, string banco, double salario, string agencia, string conta)
            {
                Nome = nome;
                Cpf = cpf;
                Rg = rg;
                Telefone1 = telefone1;
                Telefone2 = telefone2;
                Genero = genero;
                this.estadoCivil = estadoCivil;
                Cep = cep;
                Logradouro = logradouro;
                Numero = numero;
                Bairro = bairro;
                Estado = estado;
                Municipio = municipio;
                Cargo = cargo;
                Departamento = departamento;
                DataAdmissao = dataAdmissao;
                Banco = banco;
                Salario = salario;
                Agencia = agencia;
                Conta = conta;
            }

            public dadosFun()
            {

            }


        
    }
}
