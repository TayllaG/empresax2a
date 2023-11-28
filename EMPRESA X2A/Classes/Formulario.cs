using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRESA_X2A
{ 
    public static class Formulario
    {
        public static void abrirFormulario(Menu menu, Panel painel) 
        {
        menu.TopLevel = false;
        menu.FormBorderStyle = FormBorderStyle.None;
        menu.Parent = painel;
        menu.Dock = DockStyle.Fill;
        menu.Show();
        }

       
    }
}
