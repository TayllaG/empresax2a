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
    public partial class Funcionario : Form
    {
        List <dadosFun> fun = new List <dadosFun> ();
        public Funcionario()
        {
            InitializeComponent();
            Consultar();
        }
        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Funcionario");
                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    var f = new dadosFun();
                    f.Id= DAOHelper.GetInt(leitor, "id_fun");
                    f.Nome = DAOHelper.GetString(leitor, "nome_fun");
                    f.dataNasc = DAOHelper.GetDateTime(leitor, "data_nas_fun");
                    f.Cpf = DAOHelper.GetString(leitor, "cpf_fun");
                    f.Rg = DAOHelper.GetString(leitor, "rg_fun");
                    f.Telefone1 = DAOHelper.GetString(leitor, "telefone_fun");
                    f.Email = DAOHelper.GetString(leitor, "email_fun");
                    f.Logradouro = DAOHelper.GetString(leitor, "endereco_fun");
                    f.Municipio = DAOHelper.GetString(leitor, "cidade_fun");
                    f.Estado = DAOHelper.GetString(leitor, "estado_fun");
                    f.Cargo = DAOHelper.GetString(leitor, "funcao_fun");
                    f.Salario = DAOHelper.GetDouble(leitor, "salario_fun");
                    f.estadoCivil = DAOHelper.GetString(leitor, "estado_civ_fun");
                    fun.Add(f);
                }

                datagridFun.DataSource = fun;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            novoFuncionario nf = new novoFuncionario();
            nf.ShowDialog();
        }
    }
}
