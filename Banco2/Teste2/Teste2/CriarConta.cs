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
    public partial class CriarConta : Form
    {
        //Banco de dados
        SqlConnection cn = new SqlConnection(@"Data source=DESKTOP-HA5LEOB\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_Banco2");
        SqlCommand cm = new SqlCommand();

        public CriarConta()
        {
            InitializeComponent();
        }

        //TextBox
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)||char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void cbxStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Button
        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            //Verificar se todos os campos estão preenchidos corretamente
            bool verificacao=verificarCampos();

            if (verificacao)
            {             
                novoCliente();
                MessageBox.Show("Cliente cadastrado com sucesso!");

                //Fechando janela de criar conta e voltando para o Login
                voltarLogin();
            }

        }

        //Funções
        private bool verificarCampos()
        {
            //Parametro para ver se todos os campos estão correto
            //Se for igual a 0, está tudo certo
            int parametro = 0;

            //Verificando se o campo está vazio
            if(txtNome.Text=="")
            {
                MessageBox.Show("Campo NOME vazio", "Aviso");
                txtNome.Focus();
                parametro += 1;
            }
            else if (txtCPF.Text=="")
            {
                MessageBox.Show("Campo CPF vazio", "Aviso");
                txtCPF.Focus();
                parametro += 1;
            }
            else if (txtCelular.Text == "")
            {
                MessageBox.Show("Campo CELULAR vazio", "Aviso");
                txtCelular.Focus();
                parametro += 1;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Campo SENHA vazio", "Aviso");
                txtSenha.Focus();
                parametro += 1;
            }
            else if (cbxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Campo STATUS vazio", "Aviso");
                cbxStatus.Focus();
                parametro += 1;
            }
            else if (txtDataAniversario.Text == "")
            {
                MessageBox.Show("Campo DATA NASCIMENTO vazio", "Aviso");
                txtDataAniversario.Focus();
                parametro += 1;
            }
            else if (txtSenhaConfirmar.Text == "")
            {
                MessageBox.Show("Campo CONFRIMAR SENHA vazio", "Aviso");
                txtSenhaConfirmar.Focus();
                parametro += 1;
            }

            //Verificando o tamanho dos campos
            else if (txtCPF.Text.Length < 11)
            {
                MessageBox.Show("O campo CPF deve conter 14 dígitos", "Aviso");
                parametro += 1;
            }
            else if (txtCelular.Text.Length < 11)
            {
                MessageBox.Show("O campos CELULAR deve conter 11 dígitos", "Aviso");
                parametro += 1;
            }
            else if (txtSenha.Text.Length < 4)
            {
                MessageBox.Show("O campos SENHA deve conter 4 dígitos", "Aviso");
                parametro += 1;
            }
            else if (txtSenhaConfirmar.Text.Length < 4)
            {
                MessageBox.Show("O campos CONFIRMAR SENHA deve conter 4 dígitos", "Aviso");
                parametro += 1;
            }
            else if (txtDataAniversario.Text.Length < 8)
            {
                MessageBox.Show("O campos DATA ANIVERSÁRIO deve conter 8 dígitos", "Aviso");
                parametro += 1;
            }

            //Verificando se o campo SENHA e CONFIRMAR SENHA são iguas
            if (txtSenha.Text != txtSenhaConfirmar.Text)
            {
                MessageBox.Show("As senha não se conrrespondem!!", "Aviso");
                txtSenhaConfirmar.Focus();
                parametro += 1;
            }

            if(parametro==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void novoCliente()
        {
            cn.Open();
            //Pegando as informações dos textBoxs
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            string celular = txtCelular.Text;
            string senha = txtSenha.Text;
            string confSenha = txtSenhaConfirmar.Text;
            string data = txtDataAniversario.Text;
            string status = cbxStatus.SelectedItem.ToString();
            float saldo = float.Parse(txtSaldo.Text);

            //Inserindo dados na tbl_Cliente
            string query = "INSERT INTO tbl_Cliente(nome_Cliente,senha_Cliente,celular_Cliente,dataNascimento_Cliente,CPF_Cliente,status_Cliente,saldo_Cliente) VALUES (@nome,@senha,@celular,@data,@cpf,@status,@saldo)";

            cm.CommandText = query;
            cm.Connection = cn;

            cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
            cm.Parameters.Add("@celular", SqlDbType.Char).Value = celular;
            cm.Parameters.Add("@cpf", SqlDbType.Char).Value = cpf;
            cm.Parameters.Add("@data", SqlDbType.Char).Value = data;
            cm.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            cm.Parameters.Add("@saldo", SqlDbType.Decimal).Value = saldo;

            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.Close();
        }
        private void voltarLogin()
        {
            Login janela = new Login();
            janela.Show();
            this.Hide();
        }

        private void picBoxSetaVoltar_Click(object sender, EventArgs e)
        {
            voltarLogin();
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
