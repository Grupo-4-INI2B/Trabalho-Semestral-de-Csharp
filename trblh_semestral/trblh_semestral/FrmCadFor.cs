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
        int idFornecedor = 0;
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

        private dynamic VerificarNomeFornecedor()
        {
            try
            {
                var query = $"SELECT EXISTS(SELECT 1 FROM Fornecedor WHERE nomeFornecedor = '{TxtFornecedor.Text}');";
                var resultado = conexao.Query(sql: query);
                if (resultado == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return false;
            }
        }

        public bool VerificarCadastroExistente(string valorAProcurar)
        {
            string connectionString = "Server=localhost; " +
                "Port=5432; " +
                "User ID=postgres; " +
                "Password=postgres; " +
                "Database=ProjetoSemestralCsharp;" +
                "Pooling=true;";
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();

                string query = "SELECT COUNT(*) FROM MinhaTabela WHERE ColunaA = @ValorParaProcurar;";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@ValorParaProcurar", valorAProcurar);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0; // Retorna true se o registro existe, false caso contrário
                }
            }
        }






        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtFornecedor.Text) &&
                !string.IsNullOrEmpty(TxtEmail.Text) &&
                !string.IsNullOrEmpty(TxtTelefone.Text)&&
                !string.IsNullOrEmpty(TxtEndereco.Text))
            {
                string verFor = TxtFornecedor.Text; // Substitua pelo valor recebido do TextBox
                bool cadastroExiste = VerificarCadastroExistente(verFor);
                if (cadastroExiste)
                {
                    MessageBox.Show("Fornecedor já registrado!!", "Atenção!!");
                    //Recarrega();
                }
                else
                {
                    try
                    {
                   

                        var query = $"INSERT INTO Fornecedor (nomeFornecedor, telefone, email, endereco) " +
                            $"VALUES ('{TxtFornecedor.Text}','{TxtTelefone.Text}','{TxtEmail.Text}','{TxtEndereco.Text}');";


                        conexao.Query(sql: query); //Executa a inserção de dados
                        MessageBox.Show("Fornecedor cadastrado com sucesso!");
                        Recarrega();
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
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
        private void Recarrega()
        {
            LimpaCampos();
            CarregarDados(null);
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Recarrega();
        }

        private void DtgFornecedor_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.idFornecedor = (int)DtgFornecedor.SelectedRows[0].Cells[0].Value;

                var nomeFornecedor = DtgFornecedor.SelectedRows[0].Cells[1].Value;
                var telefoneFornecedor = DtgFornecedor.SelectedRows[0].Cells[2].Value;
                var emailFornecedor = DtgFornecedor.SelectedRows[0].Cells[3].Value;
                var enderecoFornecedor = DtgFornecedor.SelectedRows[0].Cells[4].Value;

                TxtFornecedor.Text = nomeFornecedor.ToString();
                TxtTelefone.Text = telefoneFornecedor.ToString();
                TxtEmail.Text = emailFornecedor.ToString();
                TxtEndereco.Text = enderecoFornecedor.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                // TslPrincipal.Text = ex.Message;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //Fornecedor fornecedor = new Fornecedor();
                var update = $"UPDATE Fornecedor SET nomeFornecedor = '{TxtFornecedor.Text}'," +
                    $"telefone = '{TxtTelefone.Text}'," +
                    $"email = '{TxtEmail.Text}'," +
                    $"endereco = '{TxtEndereco.Text}'" +
                    $"WHERE idFornecedor = {this.idFornecedor};";

                conexao.Query(sql: update);

                MessageBox.Show("Dados atualizados com sucesso!!");

                Recarrega();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                // TslPrincipal.Text = ex.Message;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir este registro?", "Atenção!!!", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var delete = $"DELETE FROM Fornecedor WHERE idFornecedor={this.idFornecedor}";
                    conexao.Query(sql: delete);

                    MessageBox.Show("Fornecedor excluído com sucesso!!");

                    Recarrega();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    // TslPrincipal.Text = ex.Message;
                }
            }
            else
            {
                Recarrega();
            }
        }

        private void BtnBusca_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBusca.Text))
            {
                try
                {
                        string query = $"SELECT f.idFornecedor AS idFornecedor," +
                        $"f.nomeFornecedor," +
                        $" f.telefone," +
                        $" f.email," +
                        $" f.endereco " +
                        $"FROM Fornecedor AS f WHERE f.nomeFornecedor LIKE '%{TxtBusca.Text}%' ;";
                        CarregarDados(query);
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo!");
            }
        }

        private void TsmAjuda_Click(object sender, EventArgs e)
        {
            FrmInformacoes frmInformacoes = new FrmInformacoes();
            frmInformacoes.ShowDialog();
        }

        private void TsmVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
