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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
     

        private void AbrirFormulario(Form formulario)
        {
            this.painelMenu.Controls.Clear();
            
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            this.painelMenu.Controls.Add(formulario);
            formulario.Show();

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

        private void Empresa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Empresa());
        }

        private void Funcionário_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Funcionario());
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Inicio());
        }
    }
}
