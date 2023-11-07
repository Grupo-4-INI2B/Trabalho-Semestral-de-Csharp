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
    public partial class FrmPesquisa : Form
    {
        NpgsqlConnection conexao;
        public FrmPesquisa()
        {
            InitializeComponent();

            conexao = new NpgsqlConnection(connectionString:
                "Server=pgsql.projetoscti.com.br; " +
                "Port=5432; " +
                "User ID=projetoscti25; " +
                "Password=721492; " +
                "Database=projetoscti25; " +
                "Pooling=true;"
            );
            CarregarDados(null);
            //CarregarListaDados();

        }
        private void CarregarDados(string comando)
        {
            string query = comando != null
                           ? comando
                         : "SELECT p.idProduto, p.fornecedor, p.nomeProduto, f.nomeFornecedor, p.disponivel, p.validade" +
                         "FROM Produto AS p" +
                         "INNER JOIN Fornecedor f ON p.fornecedor = f.idFornecedor;";

            try
            {
                conexao.Open();

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        DtgPesquisa.DataSource = dt;
                    }
                }


                conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }


        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {

        }

        private void FrmPesquisa_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
