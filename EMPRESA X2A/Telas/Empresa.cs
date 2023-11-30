using EMPRESA_X2A.Classes;
using EMPRESA_X2A.Configuracoes;
using EMPRESA_X2A.Uteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRESA_X2A
{
    public partial class Empresa : Form
    {
        private List<dadosEmp> listaEmpresas = new List<dadosEmp>();

        public Empresa()
        {
            InitializeComponent();
            Consultar();
        }
        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Empresa");
                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    var empresa = new dadosEmp();
                    empresa.Id = DAOHelper.GetInt(leitor, "id_emp");
                    empresa.Cnpj = DAOHelper.GetString(leitor, "cnpj_emp");
                    empresa.razaoSocial = DAOHelper.GetString(leitor, "razao_soc_emp");
                    empresa.nomeFantasia = DAOHelper.GetString(leitor, "nome_fan_emp");
                    empresa.situacaoCadastral = DAOHelper.GetString(leitor, "situacao_cad_emp");
                    empresa.regimeTributario = DAOHelper.GetString(leitor, "regime_tri_emp");
                    empresa.inicioAtividade = DAOHelper.GetDateTime(leitor, "data_ini_emp");
                    empresa.telefone = DAOHelper.GetString(leitor, "telefone_emp");
                    empresa.capitalSoial = DAOHelper.GetDouble(leitor, "capital_soc_emp");
                    empresa.Logradouro = DAOHelper.GetString(leitor, "endereco_com_emp");
                    empresa.tipoEmpresa = DAOHelper.GetString(leitor, "tipo_emp");
                    empresa.porteEMpresa = DAOHelper.GetString(leitor, "porte_emp");
                    empresa.naturezaJuridica = DAOHelper.GetString(leitor, "natureza_jur_emp");
                    empresa.nomeProprietario = DAOHelper.GetString(leitor, "nome_pro_emp");
                    empresa.cpfProprietario = DAOHelper.GetString(leitor, "cpf_pro_emp");
                    listaEmpresas.Add(empresa);
                }

                guna2DataGridView1.DataSource = listaEmpresas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void Funcionário_Load(object sender, EventArgs e)
        {

        }

        private void novaEmpresa_Click(object sender, EventArgs e)
        {
           novaEmpresa novaEm = new novaEmpresa();
           novaEm.ShowDialog();



        }

       
    }
}
