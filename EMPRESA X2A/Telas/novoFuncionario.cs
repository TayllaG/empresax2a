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
        }
        private void Inserir(dadosFun fun)
        {
            try
            {

                Conexao conexao = new Conexao();
                var comando = conexao.Comando("INSERT INTO Funcionario VALUES (null, @nome, @data, @cpf, @rg, @telefone, @email, @logra, @municipio, @estado, @cargo, @salario, @estado_civil)");

                comando.Parameters.AddWithValue("null", fun.Id);
                comando.Parameters.AddWithValue("@nome", fun.Nome);
                comando.Parameters.AddWithValue("@data", fun.dataNasc);
                comando.Parameters.AddWithValue("@cpf", fun.Cpf);
                comando.Parameters.AddWithValue("@rg", fun.Rg);
                comando.Parameters.AddWithValue("@telefone", fun.Telefone1);
                comando.Parameters.AddWithValue("@email", fun.Email);
                comando.Parameters.AddWithValue("@logra", fun.Logradouro);
                comando.Parameters.AddWithValue("@municipio", fun.Municipio);
                comando.Parameters.AddWithValue("@estado", fun.Estado);
                comando.Parameters.AddWithValue("@cargo", fun.Cargo);
                comando.Parameters.AddWithValue("@salario", fun.Salario);
                comando.Parameters.AddWithValue("@estado_civil", fun.estadoCivil);

                var resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_cancelar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_cpf.Clear();
            txt_rg.Clear();
            txt_email.Clear();
            txt_telefone1.Clear();
            txt_estadoCivil.SelectedIndex = -1;
            txt_logradouro.Clear();
            txt_estado.SelectedIndex = -1;
            txt_municipio.Clear();
            txt_cargo.SelectedIndex = -1;
            txt_salario.Clear();
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
                fun.estadoCivil = txt_estadoCivil.Text;
                fun.Logradouro = txt_logradouro.Text;
                fun.Estado = txt_estado.Text;
                fun.Municipio = txt_municipio.Text;
                fun.Cargo = txt_cargo.Text;
                fun.Salario = Convert.ToDouble(txt_salario.Text);


                MessageBox.Show(Validacoes.ValidaCPF(txt_cpf.Text).ToString());
                var resultadoCpf = Validacoes.ValidaCPF(txt_cpf.Text);
                var resultadoEmail = Validacoes.ValidarEmail(txt_email.Text);
                if (resultadoCpf == false && resultadoCpf == true)
                {
                    MessageBox.Show("Cpf inválido ou Email inválido");
                }
                else if (fun.Nome == "" || fun.Nome == null || fun.Rg == "" || fun.Rg == null || fun.Telefone1 == "" || fun.Telefone1 == null || fun.estadoCivil == null || fun.estadoCivil == "" || fun.Logradouro == null || fun.Logradouro == "" || fun.Estado == null || fun.Estado == null || fun.Municipio == "" || fun.Estado == null || fun.Municipio == "" || fun.Cargo == null || fun.Cargo == "" || fun.Salario == null)
                {
                    MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Inserir(fun);
                }
                
            }

            catch
            {
                MessageBox.Show("Verifique se os campos estão preenchidos corretamente!");
            }

        }

        private void novoFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
