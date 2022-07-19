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
    public partial class telaExtrato : UserControl
    {
        //Banco de dados
        SqlConnection cn = new SqlConnection(@"Data source=DESKTOP-HA5LEOB\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_Banco2");
        SqlCommand cm = new SqlCommand();

        public telaExtrato()
        {
            InitializeComponent();
        }

        private void btnSaques_Click(object sender, EventArgs e)
        {
            cn.Open();

            string query = $"SELECT valor_Saque, data_Saque FROM tbl_Saques WHERE cod_Cliente={Login.clienteCod}";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count==0)
            {
                MessageBox.Show("Nenhum saque foi realizado ainda!");
            }
            else
            {
                dgvExtratos.DataSource = dt;
            }
            cn.Close();
        }

        private void btnDepositos_Click(object sender, EventArgs e)
        {
            cn.Open();

            string query = $"SELECT valor_Deposito, data_Deposito FROM tbl_Depositos WHERE cod_Cliente={Login.clienteCod}";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum depósito foi realizado ainda!");
            }
            else
            {
                dgvExtratos.DataSource = dt;
            }
            cn.Close();
        }

        private void btnTransferencias_Click(object sender, EventArgs e)
        {
            cn.Open();

            string query = $"SELECT valor_Transferencia, data_Transferencia, nomeReceptor_Transferencia FROM tbl_Transferencias WHERE cod_Cliente={Login.clienteCod}";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum saque foi realizado ainda!");
            }
            else
            {
                dgvExtratos.DataSource = dt;
            }
            cn.Close();
        }
    }
}
