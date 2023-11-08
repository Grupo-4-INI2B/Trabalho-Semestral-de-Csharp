using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trblh_semestral
{
    public partial class FrmCadProd : Form
    {
        NpgsqlConnection conexao;
        public FrmCadProd()
        {
            InitializeComponent();
            conexao = new NpgsqlConnection(connectionString:
                "Server=localhost; " +
                "Port=5432; " +
                "User ID=postgres; " +
                "Password=postgres; " +
                "Database=ProjetoSemestralCsharp; " +
                "Pooling=true;"
            );

            CarregarDados(null);
        }
        private void CarregarDados(string comando)
        {
            string query = comando != null
                ? comando
                : "SELECT * FROM Produto ORDER BY idProduto;";

            try
            {
                conexao.Open();

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        DtgProduto.DataSource = dt;
                    }
                }

                conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
