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
    public partial class telaMenuPrincipal : UserControl
    {
        //Banco de dados
        SqlConnection cn = new SqlConnection(@"Data source=DESKTOP-HA5LEOB\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_Banco2");
        SqlCommand cm = new SqlCommand();

        //Variáveis
        public static string data;

        public telaMenuPrincipal()
        {
            InitializeComponent();
        }

        private void lblSegureAqui_MouseDown(object sender, MouseEventArgs e)
        {
            float saldo = Saldo();
            lblSegureAqui.Text = saldo.ToString();
        }
        private void lblSegureAqui_MouseUp(object sender, MouseEventArgs e)
        {
            lblSegureAqui.Text ="Segure aqui";
        }

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

        private void telaMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            data = lblData.Text;
        }
    }
}
