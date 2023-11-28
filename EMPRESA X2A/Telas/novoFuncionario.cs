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
    public partial class novoFuncionario : Form
    {
        private List<dadosFun> listaFuncionarios = new List<dadosFun>();
        public novoFuncionario()
        {
            InitializeComponent();
            Consultar();
        }

        private void txt_cancelar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_cpf.Clear();
            txt_rg.Clear();
            txt_email.Clear();
            txt_telefone1.Clear();
            txt_telefone2.Clear();
            txt_genero.SelectedIndex = -1;
            txt_estadoCivil.SelectedIndex = -1;
            txt_cep.Clear();
            txt_logradouro.Clear();
            txt_numero.Clear();
            txt_bairro.Clear();
            txt_estado.SelectedIndex = -1;
            txt_municipio.Clear();
            txt_cargo.SelectedIndex = -1;
            txt_departamento.SelectedIndex = -1;
            txt_dataAdmissao.Clear();
            txt_banco.SelectedIndex = -1;
            txt_salario.Clear();
            txt_agencia.Clear();
            txt_conta.Clear();
        }

        private void txt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {

            try
            {

                dadosFun fun = new dadosFun();
                fun.Nome = txt_nome.Text;
                fun.Cpf = txt_cpf.Text;
                fun.Rg = txt_rg.Text;
                fun.dataNasc = Convert.ToDateTime(txt_dataNasc.Text);
                fun.Email = txt_email.Text;
                fun.Telefone1 = txt_telefone1.Text;
                fun.Telefone2 = txt_telefone2.Text;
                fun.Genero = txt_genero.Text;
                fun.estadoCivil = txt_estadoCivil.Text;
                fun.Cep = txt_cep.Text;
                fun.Logradouro = txt_logradouro.Text;
                fun.Numero = (int)Convert.ToInt64(txt_numero.Text);
                fun.Bairro = txt_bairro.Text;
                fun.Estado = txt_estado.Text;
                fun.Municipio = txt_municipio.Text;
                fun.Cargo = txt_cargo.Text;
                fun.Departamento = txt_departamento.Text;
                fun.DataAdmissao = txt_dataAdmissao.Text;
                fun.Banco = txt_banco.Text;
                fun.Salario = Convert.ToDouble(txt_salario.Text);
                fun.Agencia = txt_agencia.Text;
                fun.Conta = txt_conta.Text;


                MessageBox.Show(Validacoes.ValidaCPF(txt_cpf.Text).ToString());
                var resultadoCpf = Validacoes.ValidaCPF(txt_cpf.Text);
                var resultadoEmail = Validacoes.ValidarEmail(txt_email.Text);
                if (resultadoCpf == false && resultadoCpf == true)
                {
                    MessageBox.Show("Cpf inválido ou Email inválido");
                }
                else
                {
                    MessageBox.Show("Cadastro concluido com sucesso!");
                    Inserir(fun);
                }

            }

            catch
            {
                MessageBox.Show("Verifique se os campos estão preenchidos corretamente!");
            }

        }


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

        }


        private void Consultar()
        {

            try
            {

                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM funcionario");

                var leitor = comando.ExecuteReader();


                while (leitor.Read())

                {
                    var funcionario = new dadosFun();
                    funcionario.Nome = leitor.GetString("nome_fun");

                    var posicaoColuna = leitor.GetOrdinal("cpf_fun");

                    if(! leitor.IsDBNull(posicaoColuna) )
                    {
                        funcionario.Cpf = leitor.GetString("cpf_fun");
                    }

                    listaFuncionarios.Add(funcionario);
                }

                Funcionario funci = new Funcionario();
                funci.datagridFun.DataSource = listaFuncionarios;

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

    }
}
