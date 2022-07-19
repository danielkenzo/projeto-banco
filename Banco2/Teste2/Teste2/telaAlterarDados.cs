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
    public partial class telaAlterarDados : UserControl
    {
        //Banco de dados
        SqlConnection cn = new SqlConnection(@"Data source=DESKTOP-HA5LEOB\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_Banco2");
        SqlCommand cm = new SqlCommand();

        public telaAlterarDados()
        {
            InitializeComponent();
        }

        private void btnHabilitarCampos_Click(object sender, EventArgs e)
        {
            //Habilitando campos
            HabilitandoCampos();

            //Inserindo os dados do cliente nos campos
            PreenchendoCampos();
        }

        private void HabilitandoCampos()
        {
            txtCelular.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            cboxStatus.Enabled = true;

            btnCancelar.Enabled = true;
            btnAlterarDados.Enabled = true;
            btnHabilitarCampos.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Desativando campos
            DesativandoCampos();

            //Limpando campos
            LimpandoCampos();
        }


        //FUNÇÕES
        private void PreenchendoCampos()
        {
            cn.Open();
            string query = $"SELECT *FROM tbl_Cliente WHERE cod_Cliente={Login.clienteCod}";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            txtCelular.Text = dt.Rows[0]["celular_Cliente"].ToString();
            txtNome.Text = dt.Rows[0]["nome_Cliente"].ToString();
            txtSenha.Text = dt.Rows[0]["senha_Cliente"].ToString();
            cboxStatus.Text = dt.Rows[0]["status_Cliente"].ToString();

            cn.Close();
        }
        private void LimpandoCampos()
        {
            txtCelular.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            cboxStatus.Text = "";
        }
        private void DesativandoCampos()
        {
            txtCelular.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            cboxStatus.Enabled = false;

            btnCancelar.Enabled = false;
            btnAlterarDados.Enabled = false;
            btnHabilitarCampos.Enabled = true;
        }
        private bool verificarCampos()
        {
            //Parametro para ver se todos os campos estão correto
            //Se for igual a 0, está tudo certo
            int parametro = 0;

            //Verificando se o campo está vazio
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo NOME vazio", "Aviso");
                txtNome.Focus();
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
            else if (cboxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Campo STATUS vazio", "Aviso");
                cboxStatus.Focus();
                parametro += 1;
            }

            //Verificando o tamanho dos campos
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

            if (parametro == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void AlterandoDados()
        {
            //Pegando as informações dos textBoxs
            string nome = txtNome.Text;
            string celular = txtCelular.Text;
            string senhaNova = txtSenha.Text;
            string status = cboxStatus.SelectedItem.ToString();
            cn.Open();

            string query = $"UPDATE tbl_Cliente SET nome_Cliente=@nome ,senha_Cliente=@senha , celular_Cliente=@celular, status_Cliente=@status WHERE cod_Cliente={Login.clienteCod}";

            cm.CommandText = query;
            cm.Connection = cn;

            cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cm.Parameters.Add("@senha", SqlDbType.Char).Value = senhaNova;
            cm.Parameters.Add("@celular", SqlDbType.Char).Value = celular;
            cm.Parameters.Add("@status", SqlDbType.VarChar).Value = status;

            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.Close();
        }

        private void cboxStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            bool verificacao = verificarCampos();
            if (verificacao)
            {
                AlterandoDados();
                MessageBox.Show("Dados alterados com sucesso!");
            }
            
        }


    }
}
