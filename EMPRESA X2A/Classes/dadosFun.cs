using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA_X2A
{
    internal class dadosFun
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime? dataNasc { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public string estadoCivil { get; set; }
        public string Logradouro { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public dadosFun(int id, string nome, string cpf, string rg, DateTime? dataNasc, string email, string telefone1, string estadoCivil, string logradouro, string estado, string municipio, string cargo, double salario)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            this.dataNasc = dataNasc;
            Email = email;
            Telefone1 = telefone1;
            this.estadoCivil = estadoCivil;
            Logradouro = logradouro;
            Estado = estado;
            Municipio = municipio;
            Cargo = cargo;
            Salario = salario;
        }
        public dadosFun(){


        }
    }
}
