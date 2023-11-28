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
        public Empresa()
        {
            InitializeComponent();

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
