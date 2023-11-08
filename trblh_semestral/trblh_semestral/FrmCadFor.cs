using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Npgsql;

namespace trblh_semestral
{
    public partial class FrmCadFor : Form
    {
        NpgsqlConnection conexao;
        public FrmCadFor()
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
                : "SELECT * FROM Fornecedor ORDER BY idFornecedor;";

            try
            {
                conexao.Open();

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        DtgFornecedor.DataSource = dt;
                    }
                }

                conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }


        private void FrmCadFor_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void LimpaCampos()
        {
            TxtFornecedor.Clear();
            TxtEmail.Clear();
            TxtTelefone.Clear();
            TxtEndereco.Clear();
        }
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtFornecedor.Text) &&
                !string.IsNullOrEmpty(TxtEmail.Text) &&
                !string.IsNullOrEmpty(TxtTelefone.Text)&&
                !string.IsNullOrEmpty(TxtEndereco.Text))
            {
                try
                {

                    var query = $"INSERT INTO Fornecedor (nomeFornecedor, telefone, email, endereco) " +
                        $"VALUES ('{TxtFornecedor.Text}','{TxtTelefone.Text}','{TxtEmail.Text}','{TxtEndereco.Text}');";


                    conexao.Query(sql: query); //Executa a inserção de dados
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    LimpaCampos();
                    CarregarDados(null); //Carrega lista atualizada com o novo registro
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!");
                /*
                if (string.IsNullOrEmpty(TxtProduto.Text))
                    LblProduto.Font = new Font(this.Font, FontStyle.Bold);

                if (string.IsNullOrEmpty(TxtCategoria.Text))
                    LblCategoria.Font = new Font(this.Font, FontStyle.Bold);


                if (string.IsNullOrEmpty(TxtDescricao.Text))
                    LblDescricao.Font = new Font(this.Font, FontStyle.Bold);

                /*if (!Disponivel())
                    LblDisponivel.Font = new Font(this.Font, FontStyle.Bold);*/
                /*
                if (string.IsNullOrEmpty(TxtFornecedor.Text))
                    LblFornecedor.Font = new Font(this.Font, FontStyle.Bold);*/

                //Lowlight();
            }

        }
    }
}
