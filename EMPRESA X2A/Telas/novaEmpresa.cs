using EMPRESA_X2A.Classes;
using EMPRESA_X2A.Configuracoes;
using EMPRESA_X2A.Uteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace EMPRESA_X2A
{
    public partial class novaEmpresa : Form
    {
        public novaEmpresa()
        {
            InitializeComponent();
        }

        private void novaEmpresa_Load(object sender, EventArgs e)
        {

        }
        void inserir(dadosEmp empresa)
        {
            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Empresa VALUES (null, @cnpj, @razao_social, @nome_fantasia, @situacao_cadastral, @regime_tributario, @data_inicial, @telefone, @capital_social, @endereco_completo, @tipo, @porte, @natureza_juridica, @nome_proprietario, @cpf_proprietario)");

                comando.Parameters.AddWithValue("null", empresa.Id);
                comando.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comando.Parameters.AddWithValue("@razao_social", empresa.razaoSocial);
                comando.Parameters.AddWithValue("@nome_fantasia", empresa.nomeFantasia);
                comando.Parameters.AddWithValue("@situacao_cadastral", empresa.situacaoCadastral);
                comando.Parameters.AddWithValue("@regime_tributario", empresa.regimeTributario);
                comando.Parameters.AddWithValue("@data_inicial", empresa.inicioAtividade);
                comando.Parameters.AddWithValue("@telefone", empresa.telefone);
                comando.Parameters.AddWithValue("@capital_social", empresa.capitalSoial);
                comando.Parameters.AddWithValue("@endereco_completo", empresa.Logradouro);
                comando.Parameters.AddWithValue("@tipo", empresa.tipoEmpresa);
                comando.Parameters.AddWithValue("@porte", empresa.porteEMpresa);
                comando.Parameters.AddWithValue("@natureza_juridica", empresa.naturezaJuridica);
                comando.Parameters.AddWithValue("@nome_proprietario", empresa.nomeProprietario);
                comando.Parameters.AddWithValue("@cpf_proprietario", empresa.cpfProprietario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado" + ex);
            }

        }

        private void txt_cancelar_Click(object sender, EventArgs e)
        {
            txt_cnpj.Clear();
            txt_razaoSocial.Clear();
            txt_nomeFantasia.Clear();
            txt_telefone.Clear();
            txt_capitalSocial.Clear();
            txt_situacaoCadastral.SelectedIndex = -1;
            txt_nomeProprietario.Clear();
            txt_cpfProprietario.Clear();
            txt_naturezaJuridica.SelectedIndex = -1;
            txt_logradouro.Clear();
            txt_estado.SelectedIndex = -1;
            txt_municipio.Clear();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                dadosEmp emp = new dadosEmp();
                emp.Cnpj = txt_cnpj.Text;
                emp.razaoSocial = txt_razaoSocial.Text;
                emp.nomeFantasia = txt_nomeFantasia.Text;
                emp.telefone = txt_telefone.Text;
                emp.capitalSoial = Convert.ToDouble(txt_capitalSocial.Text);
                emp.situacaoCadastral = txt_situacaoCadastral.Text;
                emp.nomeProprietario = txt_nomeProprietario.Text;
                emp.cpfProprietario = txt_cpfProprietario.Text;
                emp.inicioAtividade = Convert.ToDateTime(txt_inicioAtiv.Text);
                emp.naturezaJuridica = txt_naturezaJuridica.Text;
                emp.Logradouro = txt_logradouro.Text;
                emp.Estado = txt_estado.Text;
                emp.Municipio = txt_municipio.Text;

                if (txt_matriz.Checked == true)
                {
                    emp.tipoEmpresa = txt_matriz.Text;
                }
                else
                {
                    emp.tipoEmpresa = txt_filial.Text;
                }

                if (txt_pequeno.Checked == true)
                {
                    emp.porteEMpresa = txt_pequeno.Text;
                }
                else if (txt_medio.Checked == true)
                {
                    emp.porteEMpresa = txt_medio.Text;
                }
                else if (txt_grande.Checked == true)
                {
                    emp.tipoEmpresa = txt_grande.Text;
                }

                if (txt_simplesNacial.Checked == true)
                {
                    emp.regimeTributario = txt_simplesNacial.Text;
                }
                else if (txt_lucroPresumido.Checked == true)
                {
                    emp.regimeTributario = txt_lucroPresumido.Text;
                }
                else if (txt_real.Checked == true)
                {
                    emp.regimeTributario = txt_real.Text;
                }
                MessageBox.Show(Validacoes.ValidaCPF(txt_cpfProprietario.Text).ToString());
                var resultadoCpf = Validacoes.ValidaCPF(txt_cpfProprietario.Text);
                if (resultadoCpf == false && resultadoCpf == true)
                {
                    MessageBox.Show("Cpf inválido");
                }
                else if (Cnpj.Validar(emp.Cnpj) == false)
                {
                    MessageBox.Show("CNPJ inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Validacoes.ValidaCPF(emp.cpfProprietario) == false)
                {
                    MessageBox.Show("CFF inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (emp.razaoSocial == "" || emp.razaoSocial == null || emp.nomeFantasia == "" || emp.nomeFantasia == null || emp.situacaoCadastral == "" || emp.situacaoCadastral == null || emp.telefone == null || emp.telefone == "" || emp.capitalSoial == null || emp.Logradouro == null || emp.Logradouro == "" || emp.naturezaJuridica == null || emp.naturezaJuridica == "" || emp.nomeProprietario == null || emp.nomeProprietario == "")
                {
                    MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (txt_filial.Checked == false && txt_matriz.Checked == false)
                {
                    MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (txt_pequeno.Checked == false && txt_medio.Checked == false && txt_grande.Checked == false)
                {
                    MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (txt_simplesNacial.Checked == false && txt_lucroPresumido.Checked == false && txt_real.Checked == false)
                {
                    MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    inserir(emp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado" + ex);
            }

        }

        private void txt_cnpj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
