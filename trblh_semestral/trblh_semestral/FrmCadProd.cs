using Dapper;
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
            PreencherCblFornecedores();
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

        private List<Fornecedor> ObterFornecedores()
        {
            string connectionString = "Server=localhost;Port=5432;User ID=postgres;Password=postgres;Database=ProjetoSemestralCsharp;Pooling=true;";

            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();

                string query = "SELECT idFornecedor, nomeFornecedor FROM Fornecedor";
                return conexao.Query<Fornecedor>(query).ToList();
            }
        }
        private void PreencherCblFornecedores()
        {
            List<Fornecedor> fornecedores = ObterFornecedores();
            CblFornecedor.DataSource = fornecedores;
            CblFornecedor.DisplayMember = "nomeFornecedor";
            CblFornecedor.ValueMember = "idFornecedor";
        }


        private bool Disponivel()
        {
            if(ChkDisponivel.Checked)
            {
                return  true;
                //definir qtde 
            }
            else
            {
                return false;
                //definir qtde=0
            }
        }
        private void LimpaCampos()
        {
            TxtProduto.Clear();
            TxtCategoria.Clear();
            TxtDescricao.Clear();
            ChkDisponivel.Checked=false;
            NumQuantidade.Value = 0;
            NumPreco.Value = 0.00M;
            CblFornecedor.ResetText();
            DtCadastro.Value = DateTime.MaxValue;
            DtValidade.Value= DateTime.MaxValue;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtProduto.Text) &&
                !string.IsNullOrEmpty(TxtCategoria.Text)&&
                !string.IsNullOrEmpty(TxtDescricao.Text))
            {
                try
                {
                    Disponivel();
                    //Tratamento da data de adoção
                    var dc = DtCadastro.Value.Day;
                    var mc = DtCadastro.Value.Month;
                    var yc= DtCadastro.Value.Year;
                    string dataCadastro = yc + "/" + mc + "/" + dc;
                    
                    var dv = DtValidade.Value.Day;
                    var mv = DtValidade.Value.Month;
                    var yv = DtValidade.Value.Year;
                    string dataValidade = yv + "/" + mv + "/" + dv;

                    var query = $"INSERT INTO Produto (nomeProduto,categoria, descricao, data," +
                        $"validade, disponivel, qtnd, preco, fornecedor) VALUES " +
                        $"('{TxtProduto.Text}','{TxtCategoria.Text}','{TxtDescricao.Text}'," +
                        $"'{dataCadastro}','{dataValidade}',{Disponivel()},{NumQuantidade.Value}," +
                        $"{NumPreco.Value}, '{(int)CblFornecedor.SelectedValue}');";


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
                if (string.IsNullOrEmpty(TxtProduto.Text))
                    LblProduto.Font = new Font(this.Font, FontStyle.Bold);

                if (string.IsNullOrEmpty(TxtCategoria.Text))
                    LblCategoria.Font = new Font(this.Font, FontStyle.Bold);


                if (string.IsNullOrEmpty(TxtDescricao.Text))
                    LblDescricao.Font = new Font(this.Font, FontStyle.Bold);

                /*if (!Disponivel())
                    LblDisponivel.Font = new Font(this.Font, FontStyle.Bold);*/

                if (string.IsNullOrEmpty(CblFornecedor.Text))
                    LblFornecedor.Font = new Font(this.Font, FontStyle.Bold);

                //Lowlight();
            }
        }
    }
}
