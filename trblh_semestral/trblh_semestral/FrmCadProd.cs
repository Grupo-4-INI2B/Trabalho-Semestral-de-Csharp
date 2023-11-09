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
        int idProduto = 0;
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
                : "SELECT p.*, f.nomeFornecedor " +
                "FROM Produto p " +
                "INNER JOIN Fornecedor f ON p.fornecedor = f.idFornecedor;";

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
            DtCadastro.Value = DateTime.Now;
            DtValidade.Value= DateTime.Now;
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

                    int idFornSelecionado = (int)CblFornecedor.SelectedValue;
                    //LblAleatorio.Text = $"{idFornSelecionado}";
                    var query = $"INSERT INTO Produto (nomeProduto,categoria, descricao, data," +
                        $"validade, disponivel, qtnd, preco, fornecedor) VALUES " +
                        $"('{TxtProduto.Text}','{TxtCategoria.Text}','{TxtDescricao.Text}'," +
                        $"'{dataCadastro}','{dataValidade}',{Disponivel()},{NumQuantidade.Value}," +
                        $"{NumPreco.Value}, {idFornSelecionado} );";
                                

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
        private int ObterIndiceFornecedorPorId(int idFornecedor)
        {
            for (int i = 0; i < CblFornecedor.Items.Count; i++)
            {
                Fornecedor fornecedor = (Fornecedor)CblFornecedor.Items[i];
                if (fornecedor.idFornecedor == idFornecedor)
                {
                    return i; // Retorna o índice do fornecedor com o id correspondente
                }
            }

            // Se nenhum fornecedor corresponder ao id, você pode retornar -1 ou um valor que faça sentido no seu contexto
            return -1;
        }

        private void PreencherComboBoxFornecedores()
        {
            // Limpe os itens existentes no ComboBox
            CblFornecedor.Items.Clear();

            // Aqui você deve consultar o banco de dados ou outra fonte de dados para obter os nomes dos fornecedores
            // Suponhamos que você tenha uma lista de objetos Fornecedor com propriedades "Id" e "Nome"
            List<Fornecedor> fornecedores = ObterFornecedores();

            // Adicione os nomes dos fornecedores ao ComboBox
            foreach (Fornecedor fornecedor in fornecedores)
            {
                CblFornecedor.Items.Add(fornecedor);
            }
        }


        private void DtgProduto_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //var linha = DtgAnimal.SelectedRows[0].Cells[0].Value;
                this.idProduto = (int)DtgProduto.SelectedRows[0].Cells[0].Value;

                var nomeProduto = DtgProduto.SelectedRows[0].Cells[1].Value;
                var categoriaProduto = DtgProduto.SelectedRows[0].Cells[2].Value;
                var descricaoProduto = DtgProduto.SelectedRows[0].Cells[3].Value;
                var dataCadastro = DtgProduto.SelectedRows[0].Cells[4].Value;
                var dataValidade = DtgProduto.SelectedRows[0].Cells[5].Value;
                var disponivelProduto = DtgProduto.SelectedRows[0].Cells[6].Value;
                var quantidadeProduto = DtgProduto.SelectedRows[0].Cells[7].Value;
                var precoProduto = DtgProduto.SelectedRows[0].Cells[8].Value;
                var fornecedor = DtgProduto.SelectedRows[0].Cells[9].Value;
                

                var newData = dataCadastro.ToString().Split('/');
                int dc = int.Parse(newData[0]);
                int mc = int.Parse(newData[1]);
                int yc = int.Parse(newData[2].Split(' ')[0]);

                DtCadastro.Value = new DateTime(yc, mc, dc);
                
                var novaData = dataValidade.ToString().Split('/');
                int dv = int.Parse(novaData[0]);
                int mv = int.Parse(novaData[1]);
                int yv = int.Parse(novaData[2].Split(' ')[0]);

                DtCadastro.Value = new DateTime(yv, mv, dv);

                TxtProduto.Text = nomeProduto.ToString();
                TxtCategoria.Text = categoriaProduto.ToString();
                TxtDescricao.Text = descricaoProduto.ToString();
                ChkDisponivel.Checked = (bool)disponivelProduto;;
                NumQuantidade.Value = int.Parse(quantidadeProduto.ToString());
                NumPreco.Value = decimal.Parse(precoProduto.ToString());
                //CblFornecedor.Text = fornecedor.ToString();
                int idFornecedor = (int)fornecedor; // Suponha que você tenha o id do fornecedor associado ao produto
                CblFornecedor.SelectedIndex = ObterIndiceFornecedorPorId(idFornecedor);



                //PreencherCblFornecedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                // TslPrincipal.Text = ex.Message;
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int idFornSelecionado = (int)CblFornecedor.SelectedValue;
                //Fornecedor fornecedor = new Fornecedor();
                var update = $"UPDATE Produto SET nomeProduto = '{TxtProduto.Text}'," +
                    $"categoria = '{TxtCategoria.Text}'," +
                    $"descricao = '{TxtDescricao.Text}'," +
                    $"data = '{DtCadastro.Text}'," +
                    $"validade = '{DtCadastro.Text}'," +
                    $"disponivel = '{ChkDisponivel.Checked}'," +
                    $"quantidade = '{NumQuantidade.Value}'," +
                    $"preco = '{NumPreco.Value}'," +
                    $"fornecedor = '{idFornSelecionado}'" +
                    $"WHERE idFornecedor = {this.idProduto};";

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
                    var delete = $"DELETE FROM Fornecedor WHERE idFornecedor={this.idProduto}";
                    conexao.Query(sql: delete);

                    MessageBox.Show("Fornecedor excluído com sucesso!!");

                    Recarrega();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
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
                    string query = $"SELECT * " +
                    $"FROM Produto AS p WHERE p.nomeProduto LIKE '%{TxtBusca.Text}%' ;";
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
    }
}
