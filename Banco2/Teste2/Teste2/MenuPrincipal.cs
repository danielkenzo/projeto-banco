using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste2
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            telaMenuPrincipal2.BringToFront();
        }

        private void btnSaqueTransferenciaDeposito_Click(object sender, EventArgs e)
        {
            telaSaqueTransferenciaDeposito2.BringToFront();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            telaMenuPrincipal2.BringToFront();
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            telaAlterarDados1.BringToFront();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            telaExtrato1.BringToFront();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login tela = new Login();
            tela.Show();
            this.Hide();
        }
    }
}
