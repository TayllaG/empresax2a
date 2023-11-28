using EMPRESA_X2A.Classes;
using EMPRESA_X2A.Configuracoes;
using EMPRESA_X2A.Uteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            

            txt_cep.Clear();
            txt_logradouro.Clear();
            txt_numero.Clear();
            txt_bairro.Clear();
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
                emp.capitalSoial = txt_capitalSocial.Text;
                emp.situacaoCadastral = txt_situacaoCadastral.Text;
                emp.nomeProprietario = txt_nomeProprietario.Text;
                emp.cpfProprietario = txt_cpfProprietario.Text;
                emp.inicioAtividade = Convert.ToDateTime(txt_inicioAtiv.Text);
                emp.naturezaJuridica = txt_naturezaJuridica.Text;



                emp.Cep = txt_cep.Text;
                emp.Logradouro = txt_logradouro.Text;
                emp.Numero = (int)Convert.ToInt64(txt_numero.Text);
                emp.Bairro = txt_bairro.Text;
                emp.Estado = txt_estado.Text;
                emp.Municipio = txt_municipio.Text;


                MessageBox.Show(Validacoes.ValidaCPF(txt_cpfProprietario.Text).ToString());
                var resultadoCpf = Validacoes.ValidaCPF(txt_cpfProprietario.Text);
             
                if (resultadoCpf == false && resultadoCpf == true)
                {
                    MessageBox.Show("Cpf inválido ou Email inválido");
                }
                else
                {
                    MessageBox.Show("Cadastro concluido com sucesso!");
                    //Inserir(emp);
                }
            }
            catch (Exception ex)
            {

            }
        
        }

        //TROCAR DADOS PARA DADOS DA EMPRESA
        /*
        private void Inserir(dadosFun fun)
        {
            try
            {

                Conexao conexao = new Conexao();
                var comando = conexao.Comando("INSERT INTO funcionario (nome_fun,cpf_fun,rg_fun,data_nasc_fun,email_fun,telefone1_fun," +
                "telefone2_fun,genero_fun,estado_civil,cep_fun,logradouro_fun,numero_fun,bairro_fun,estado_fun,municipio_fun," +
                "cargo_fun,departamento_fun,data_admissao_fun,banco_fun,salario_fun,agencia_fun,conta_fun) VALUES (@nome,@cpf,@rg,@dataNasc," +
                "@email,@telefone1,@telefone2,@genero,@estadoCivil,@cep,@logradouro,@numero,@bairoo,@estado,@municipio,@cargo,@departamento," +
                "@dataAdmissao,@banco,@salario,@agencia,@conta");

                comando.Parameters.AddWithValue("@nome", fun.Nome);
                comando.Parameters.AddWithValue("@cpf", fun.Cpf);
                comando.Parameters.AddWithValue("@rg", fun.Rg);
                comando.Parameters.AddWithValue("@dataNasc", fun.dataNasc);
                comando.Parameters.AddWithValue("@email", fun.Email);
                comando.Parameters.AddWithValue("@telefone1", fun.Telefone1);
                comando.Parameters.AddWithValue("@telefone2", fun.Telefone2);
                comando.Parameters.AddWithValue("@genero", fun.Genero);
                comando.Parameters.AddWithValue("@estadoCivil", fun.estadoCivil);
                comando.Parameters.AddWithValue("@cep", fun.Cep);
                comando.Parameters.AddWithValue("@logradouro", fun.Logradouro);
                comando.Parameters.AddWithValue("@numero", fun.Numero);
                comando.Parameters.AddWithValue("@bairro", fun.Bairro);
                comando.Parameters.AddWithValue("@estado", fun.Estado);
                comando.Parameters.AddWithValue("@municipio", fun.Municipio);
                comando.Parameters.AddWithValue("@cargo", fun.Cargo);
                comando.Parameters.AddWithValue("@departamento", fun.Departamento);
                comando.Parameters.AddWithValue("@dataAdmissao", fun.DataAdmissao);
                comando.Parameters.AddWithValue("@banco", fun.Banco);
                comando.Parameters.AddWithValue("@salario", fun.Salario);
                comando.Parameters.AddWithValue("@agencia", fun.Agencia);
                comando.Parameters.AddWithValue("@conta", fun.Conta);

                var resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }

                Consultar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }*/
    }
}
