using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA_X2A.Classes
{
    internal class dadosEmp
    {
        public int Id { get; set; }
        public string Cnpj {  get; set; }
        public string razaoSocial { get; set; }
        public string nomeFantasia { get; set; }
        public string telefone {  get; set; }
        public Double capitalSoial { get; set; }
        public string situacaoCadastral { get; set; }
        public string nomeProprietario { get; set; }
        public string cpfProprietario { get; set; }
        public DateTime? inicioAtividade { get; set; }
        public string naturezaJuridica { get; set; }
        public string tipoEmpresa { get; set; }
        public string regimeTributario { get; set; }
        public string porteEMpresa { get; set; }
        public string Logradouro { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }

        public dadosEmp(string cnpj, string razaoSocial, string nomeFantasia, string telefone, double capitalSoial, string situacaoCadastral, string nomeProprietario, string cpfProprietario, DateTime? inicioAtividade, string naturezaJuridica, string tipoEmpresa, string regimeTributario, string porteEMpresa, string cep, string logradouro, int numero, string bairro, string estado, string municipio)
        {
            Cnpj = cnpj;
            this.razaoSocial = razaoSocial;
            this.nomeFantasia = nomeFantasia;
            this.telefone = telefone;
            this.capitalSoial = capitalSoial;
            this.situacaoCadastral = situacaoCadastral;
            this.nomeProprietario = nomeProprietario;
            this.cpfProprietario = cpfProprietario;
            this.inicioAtividade = inicioAtividade;
            this.naturezaJuridica = naturezaJuridica;
            this.tipoEmpresa = tipoEmpresa;
            this.regimeTributario = regimeTributario;
            this.porteEMpresa = porteEMpresa;
            Logradouro = logradouro;
            Estado = estado;
            Municipio = municipio;
        }

        public dadosEmp()
        {

        }
    }
}
