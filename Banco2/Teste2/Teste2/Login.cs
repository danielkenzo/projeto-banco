using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teste2
{
    public partial class Login : Form
    {
        //Banco de dados
        SqlConnection cn = new SqlConnection(@"Data source=DESKTOP-HA5LEOB\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_Banco2");
        SqlCommand cm = new SqlCommand();

        public Login()
        {
            InitializeComponent();
        }

        //Fields
        public static string clienteCPF;
        public static string clienteNome;
        public static string clienteCod;


        // Buttons
        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            CriarConta janela = new CriarConta();
            janela.Show();
            this.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Verificando se o cliente existe no banco de dados
            if(verificarCliente())
            {
                //Abrir janela do MenuPrincipal
                MenuPrincipal janela = new MenuPrincipal();
                janela.Show();
                this.Hide();
            }

        }
        //TextBox
        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";

            //Escondedo a senha
            txtSenha.UseSystemPasswordChar = true;

            //Mudando a cor do textp
            txtSenha.ForeColor = Color.Black;
        }
        private void txtCPF_Click(object sender, EventArgs e)
        {
            //Limpando a caixa de texto
            txtCPF.Text = "";

            //Mudando a cor do texto
            txtCPF.ForeColor = Color.Black;
        }
        
        //Picture Box
        private void picBoxSenha_MouseDown(object sender, MouseEventArgs e)
        {
            //Mostrando a senha
            txtSenha.UseSystemPasswordChar = false;
        }
        private void picBoxSenha_MouseUp(object sender, MouseEventArgs e)
        {
            //Cobrindo a senha
            txtSenha.UseSystemPasswordChar = true;
        }

        //Funções
        private bool verificarCliente()
        {
            cn.Open();

            string cpf = txtCPF.Text;
            string senha = txtSenha.Text;
            string query = $"SELECT *FROM tbl_Cliente WHERE CPF_Cliente='{cpf}' AND Senha_Cliente='{senha}'";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count==0)
            {
                MessageBox.Show("Por favor revise seus dados ou crie uma conta clicando no botão 'Criar conta'", "Cliente não encontrado!");
                cn.Close();
                return false;
            }
            else
            {
                //Pegando algumas informações
                clienteCPF = dt.Rows[0]["CPF_Cliente"].ToString();
                clienteNome = dt.Rows[0]["nome_Cliente"].ToString();
                clienteCod = dt.Rows[0]["cod_Cliente"].ToString();
                cn.Close();
                return true;
            }


        }
        private void btnFecharApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
