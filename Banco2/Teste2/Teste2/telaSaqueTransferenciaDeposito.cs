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
    public partial class telaSaqueTransferenciaDeposito : UserControl
    {
        //Banco de dados
        SqlConnection cn = new SqlConnection(@"Data source=DESKTOP-HA5LEOB\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_Banco2");
        SqlCommand cm = new SqlCommand();

        public telaSaqueTransferenciaDeposito()
        {
            InitializeComponent();
        }

        //Saque
        private void btnSaque_Click(object sender, EventArgs e)
        {
            HabilitarSaque();
        }
        private void btnSaqueRapido_Click(object sender, EventArgs e)
        {
            HabilitarSaqueRapido();
        }

        private void btnSaqueEnvio_Click(object sender, EventArgs e)
        {
            Saque();
            InsercaoDadosTabelaSaque(float.Parse(txtSaque.Text));
        }


        private void btnSaqueRapido20_Click(object sender, EventArgs e)
        {
            SaqueRapido20();
            InsercaoDadosTabelaSaque(20);
        }
        private void btnSaqueRapido50_Click(object sender, EventArgs e)
        {
            SaqueRapido50();
            InsercaoDadosTabelaSaque(50);
        }
        private void btnSaqueRapido100_Click(object sender, EventArgs e)
        {
            SaqueRapido100();
            InsercaoDadosTabelaSaque(100);
        }

        //Transferencia

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            HabilitarTransferencia();

        }
        private void btnTransferenciaEnvio_Click(object sender, EventArgs e)
        {
            Transferencia();
            InsercaoDadosTabelaTransferencia();        
        }

        

        //Depósito
        private void btnDeposito_Click(object sender, EventArgs e)
        {
            HabilitarDeposito();
        }
        private void btnDepositoEnvio_Click(object sender, EventArgs e)
        {
            Deposito();
            InsercaoDadosTabelaDeposito();
        }

        //Funções


        //F-Saque
        private void HabilitarSaque()
        {
            txtDeposito.Enabled = false;
            txtSaque.Enabled = true;
            txtTransferenciaCPF.Enabled = false;
            txtTransferenciaValor.Enabled = false;

            btnDepositoEnvio.Enabled = false;
            btnSaqueEnvio.Enabled = true;
            btnTransferenciaEnvio.Enabled = false;

            btnSaqueRapido100.Enabled = false;
            btnSaqueRapido20.Enabled = false;
            btnSaqueRapido50.Enabled = false;

        }
        private void HabilitarSaqueRapido()
        {
            txtDeposito.Enabled = false;
            txtSaque.Enabled = false;
            txtTransferenciaCPF.Enabled = false;
            txtTransferenciaValor.Enabled = false;

            btnDepositoEnvio.Enabled = false;
            btnSaqueEnvio.Enabled = false;
            btnTransferenciaEnvio.Enabled = false;

            btnSaqueRapido100.Enabled = true;
            btnSaqueRapido20.Enabled = true;
            btnSaqueRapido50.Enabled = true;
        }
        private void Saque()
        {
            float saldoAtual = Saldo();
            float saldoNovo = saldoAtual - float.Parse(txtSaque.Text);

            if (saldoNovo < 0)
            {
                MessageBox.Show("Saldo insuficiente!");
                txtSaque.Clear();
                txtSaque.Focus();
            }
            else
            {
                cn.Open();

                string query = $"UPDATE tbl_Cliente SET saldo_Cliente='{saldoNovo.ToString()}' WHERE cod_Cliente={Login.clienteCod}";
                cm.CommandText = query;
                cm.Connection = cn;

                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Saque realizado com sucesso!");
            }


        }
        private void SaqueRapido20()
        {
            float saldoAtual = Saldo();
            float saldoNovo = saldoAtual - 20;

            if (saldoNovo < 0)
            {
                MessageBox.Show("Saldo insuficiente!");
                txtSaque.Clear();
                txtSaque.Focus();
            }
            else
            {
                cn.Open();
                string query = $"UPDATE tbl_Cliente SET saldo_Cliente='{saldoNovo.ToString()}' WHERE cod_Cliente={Login.clienteCod}";
                cm.CommandText = query;
                cm.Connection = cn;

                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Saque realizado com sucesso!");
            }

        }
        private void SaqueRapido50()
        {
            float saldoAtual = Saldo();
            float saldoNovo = saldoAtual - 50;

            if (saldoNovo < 0)
            {
                MessageBox.Show("Saldo insuficiente!");
            }

            else
            {
                cn.Open();
                string query = $"UPDATE tbl_Cliente SET saldo_Cliente='{saldoNovo.ToString()}' WHERE cod_Cliente={Login.clienteCod}";
                cm.CommandText = query;
                cm.Connection = cn;

                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Saque realizado com sucesso!");
            }
        }
        private void SaqueRapido100()
        {
            float saldoAtual = Saldo();
            float saldoNovo = saldoAtual - 100;

            if (saldoNovo < 0)
            {
                MessageBox.Show("Saldo insuficiente!");
            }

            else
            {
                cn.Open();
                string query = $"UPDATE tbl_Cliente SET saldo_Cliente='{saldoNovo.ToString()}' WHERE cod_Cliente={Login.clienteCod}";
                cm.CommandText = query;
                cm.Connection = cn;

                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Saque realizado com sucesso!");
            }
        }
        private void InsercaoDadosTabelaSaque(float valor)
        {
            cn.Open();

            string data = telaMenuPrincipal.data;
            int cod = int.Parse(Login.clienteCod);

            string query = $"INSERT INTO tbl_Saques (data_Saque,valor_Saque,cod_Cliente) VALUES (@data,@valor,@cod)";
            cm.CommandText = query;
            cm.Connection = cn;

            cm.Parameters.Add("@data", SqlDbType.Char).Value = data;
            cm.Parameters.Add("@valor", SqlDbType.Decimal).Value = valor;
            cm.Parameters.Add("@cod", SqlDbType.Int).Value = cod;

            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.Close();

            txtSaque.Clear();
            txtSaque.Focus();
        }

        //F-Deposito
        private void HabilitarDeposito()
        {
            txtDeposito.Enabled = true;
            txtSaque.Enabled = false;
            txtTransferenciaCPF.Enabled = false;
            txtTransferenciaValor.Enabled = false;

            btnDepositoEnvio.Enabled = true;
            btnSaqueEnvio.Enabled = false;
            btnTransferenciaEnvio.Enabled = false;

            btnSaqueRapido100.Enabled = false;
            btnSaqueRapido20.Enabled = false;
            btnSaqueRapido50.Enabled = false;
        }
        private void Deposito()
        {
            float saldoAtual = Saldo();
            float novoSaldo = saldoAtual + (float.Parse(txtDeposito.Text));

            cn.Open();

            string query = $"UPDATE tbl_Cliente SET saldo_Cliente='{novoSaldo}' WHERE cod_Cliente={Login.clienteCod}";
            cm.CommandText = query;
            cm.Connection = cn;

            cm.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Deposito feito com sucesso!");
        }
        private void InsercaoDadosTabelaDeposito()
        {
            string data = telaMenuPrincipal.data;
            int cod = int.Parse(Login.clienteCod);
            float valor = float.Parse(txtDeposito.Text);

            cn.Open();

            string query = $"INSERT INTO tbl_Depositos (data_Deposito,valor_Deposito,cod_Cliente) VALUES (@data,@valor,@cod)";
            cm.CommandText = query;
            cm.Connection = cn;

            cm.Parameters.Add("@data", SqlDbType.Char).Value = data;
            cm.Parameters.Add("@valor", SqlDbType.Decimal).Value = valor;
            cm.Parameters.Add("@cod", SqlDbType.Int).Value = cod;

            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.Close();

            txtDeposito.Clear();
            txtDeposito.Focus();
        }

        //F-Transferencia
        private void HabilitarTransferencia()
        {
            txtDeposito.Enabled = false;
            txtSaque.Enabled = false;
            txtTransferenciaCPF.Enabled = true;
            txtTransferenciaValor.Enabled = true;

            btnDepositoEnvio.Enabled = false;
            btnSaqueEnvio.Enabled = false;
            btnTransferenciaEnvio.Enabled = true;

            btnSaqueRapido100.Enabled = false;
            btnSaqueRapido20.Enabled = false;
            btnSaqueRapido50.Enabled = false;

        }
        private void Transferencia()
        {
            float saldoAtual = Saldo();
            float saldoNovo = saldoAtual - float.Parse(txtTransferenciaValor.Text);

            string cpf = VerificarCPF();

            if (cpf != "false" && saldoNovo > 0)
            {
                //Novo saldo do indivíduo que está transferindo o dinheiro
                cn.Open();

                string query = $"UPDATE tbl_Cliente SET saldo_Cliente='{saldoNovo.ToString()}' WHERE cod_Cliente={Login.clienteCod}";
                cm.CommandText = query;
                cm.Connection = cn;

                cm.ExecuteNonQuery();
                cn.Close();

                //Novo saldo do indivíduo que está recebendo o dinheiro
                float saldoAtualRecebedor = SaldoRecebedor();
                float saldoNovoRecebedor = saldoAtualRecebedor + float.Parse(txtTransferenciaValor.Text);
                cn.Open();

                string query2 = $"UPDATE tbl_Cliente SET saldo_Cliente='{saldoNovoRecebedor.ToString()}' WHERE cpf_Cliente='{cpf}'";
                cm.CommandText = query2;
                cm.Connection = cn;

                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Transferência realizada com sucesso!");
            }
            else if (cpf == "false")
            {
                MessageBox.Show("Número de CPF inválido!");
                txtTransferenciaCPF.Focus();
            }
            else if (saldoNovo < 0)
            {
                MessageBox.Show("Saldo insuficiente!");
                txtTransferenciaValor.Focus();
            }
        }
        private void InsercaoDadosTabelaTransferencia()
        {
            //VARIÁVEIS
            int cod = int.Parse(Login.clienteCod);
            float valor = float.Parse(txtTransferenciaValor.Text);
            string data = telaMenuPrincipal.data;
            string nomeReceptor = NomeReceptor();

            cn.Open();

            string query = $"INSERT INTO tbl_Transferencias (cod_Cliente, data_Transferencia, valor_Transferencia, nomeReceptor_Transferencia) VALUES (@cod,@data,@valor,@nomeRecep)";
            cm.CommandText = query;
            cm.Connection = cn;

            cm.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
            cm.Parameters.Add("@data", SqlDbType.VarChar).Value = data;
            cm.Parameters.Add("@valor", SqlDbType.Decimal).Value = valor;
            cm.Parameters.Add("@nomeRecep", SqlDbType.VarChar).Value = nomeReceptor;

            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.Close();

            txtTransferenciaValor.Clear();
            txtTransferenciaCPF.Clear();
            txtTransferenciaValor.Focus();

            MessageBox.Show("Dados inseridos na tabela transferencia");


        }


        //Demais Funções
        private float Saldo()
        {
            cn.Open();

            string query = "SELECT *FROM tbl_Cliente WHERE cod_Cliente=('" + Login.clienteCod + "')";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            float saldo = float.Parse(dt.Rows[0]["saldo_Cliente"].ToString());
            cn.Close();
            return saldo;


        }
        private string VerificarCPF()
        {
            cn.Open();

            string query = $"SELECT *FROM tbl_Cliente WHERE CPF_Cliente='{txtTransferenciaCPF.Text}'";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string cpf;
            if(dt.Rows.Count==0)
            {
                cpf = "false";
                cn.Close();
                return cpf;
            }
            else
            {
                cpf = dt.Rows[0]["CPF_Cliente"].ToString();
                cn.Close();
                return cpf;
            }
        }
        private float SaldoRecebedor()
        {
            cn.Open();

            string query = $"SELECT *FROM tbl_Cliente WHERE CPF_Cliente='{txtTransferenciaCPF.Text}'";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            float saldo = float.Parse(dt.Rows[0]["saldo_Cliente"].ToString());
            cn.Close();
            return saldo;
        }
        private string NomeReceptor()
        {
            cn.Open();

            string cpf = txtTransferenciaCPF.Text;
            string query = $"SELECT nome_Cliente FROM tbl_Cliente WHERE CPF_Cliente='{cpf}'";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string nome = dt.Rows[0]["nome_Cliente"].ToString();

            cn.Close();
            return nome;


        }

        private void txtSaque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTransferenciaValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtDeposito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
