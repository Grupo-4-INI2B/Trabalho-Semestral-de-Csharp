namespace trblh_semestral
{
    partial class FrmCadProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblAreaCadProd = new System.Windows.Forms.Label();
            this.LblProduto = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.LblDataCad = new System.Windows.Forms.Label();
            this.LblValidade = new System.Windows.Forms.Label();
            this.LblDisponivel = new System.Windows.Forms.Label();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.LblPreço = new System.Windows.Forms.Label();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.DtCadastro = new System.Windows.Forms.DateTimePicker();
            this.DtValidade = new System.Windows.Forms.DateTimePicker();
            this.NumQuantidade = new System.Windows.Forms.NumericUpDown();
            this.NumPreco = new System.Windows.Forms.NumericUpDown();
            this.ChkDisponivel = new System.Windows.Forms.CheckBox();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.BtnBusca = new System.Windows.Forms.Button();
            this.DtgProduto = new System.Windows.Forms.DataGridView();
            this.CblFornecedor = new System.Windows.Forms.ComboBox();
            this.LblAleatorio = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmVoltar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProduto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAreaCadProd
            // 
            this.LblAreaCadProd.AutoSize = true;
            this.LblAreaCadProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblAreaCadProd.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAreaCadProd.Location = new System.Drawing.Point(219, 44);
            this.LblAreaCadProd.Name = "LblAreaCadProd";
            this.LblAreaCadProd.Size = new System.Drawing.Size(384, 27);
            this.LblAreaCadProd.TabIndex = 0;
            this.LblAreaCadProd.Text = "Cadastro e Pesquisa de produtos";
            // 
            // LblProduto
            // 
            this.LblProduto.AutoSize = true;
            this.LblProduto.Location = new System.Drawing.Point(38, 71);
            this.LblProduto.Name = "LblProduto";
            this.LblProduto.Size = new System.Drawing.Size(44, 16);
            this.LblProduto.TabIndex = 1;
            this.LblProduto.Text = "Nome";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(155, 71);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(66, 16);
            this.LblCategoria.TabIndex = 2;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(272, 71);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(69, 16);
            this.LblDescricao.TabIndex = 3;
            this.LblDescricao.Text = "Descrição";
            // 
            // LblDataCad
            // 
            this.LblDataCad.AutoSize = true;
            this.LblDataCad.Location = new System.Drawing.Point(38, 180);
            this.LblDataCad.Name = "LblDataCad";
            this.LblDataCad.Size = new System.Drawing.Size(111, 16);
            this.LblDataCad.TabIndex = 4;
            this.LblDataCad.Text = "Data de cadastro";
            // 
            // LblValidade
            // 
            this.LblValidade.AutoSize = true;
            this.LblValidade.Location = new System.Drawing.Point(287, 180);
            this.LblValidade.Name = "LblValidade";
            this.LblValidade.Size = new System.Drawing.Size(62, 16);
            this.LblValidade.TabIndex = 5;
            this.LblValidade.Text = "Validade";
            // 
            // LblDisponivel
            // 
            this.LblDisponivel.AutoSize = true;
            this.LblDisponivel.Location = new System.Drawing.Point(407, 71);
            this.LblDisponivel.Name = "LblDisponivel";
            this.LblDisponivel.Size = new System.Drawing.Size(102, 16);
            this.LblDisponivel.TabIndex = 6;
            this.LblDisponivel.Text = "Disponibilidade";
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Location = new System.Drawing.Point(38, 125);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(77, 16);
            this.LblQuantidade.TabIndex = 7;
            this.LblQuantidade.Text = "Quantidade";
            // 
            // LblPreço
            // 
            this.LblPreço.AutoSize = true;
            this.LblPreço.Location = new System.Drawing.Point(155, 125);
            this.LblPreço.Name = "LblPreço";
            this.LblPreço.Size = new System.Drawing.Size(43, 16);
            this.LblPreço.TabIndex = 8;
            this.LblPreço.Text = "Preço";
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.Location = new System.Drawing.Point(272, 125);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(77, 16);
            this.LblFornecedor.TabIndex = 9;
            this.LblFornecedor.Text = "Fornecedor";
            // 
            // TxtProduto
            // 
            this.TxtProduto.Location = new System.Drawing.Point(41, 90);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(100, 22);
            this.TxtProduto.TabIndex = 10;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(158, 90);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(100, 22);
            this.TxtCategoria.TabIndex = 11;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(275, 90);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(100, 22);
            this.TxtDescricao.TabIndex = 12;
            // 
            // DtCadastro
            // 
            this.DtCadastro.Location = new System.Drawing.Point(41, 200);
            this.DtCadastro.Name = "DtCadastro";
            this.DtCadastro.Size = new System.Drawing.Size(200, 22);
            this.DtCadastro.TabIndex = 14;
            // 
            // DtValidade
            // 
            this.DtValidade.Location = new System.Drawing.Point(290, 199);
            this.DtValidade.Name = "DtValidade";
            this.DtValidade.Size = new System.Drawing.Size(200, 22);
            this.DtValidade.TabIndex = 15;
            // 
            // NumQuantidade
            // 
            this.NumQuantidade.Location = new System.Drawing.Point(41, 145);
            this.NumQuantidade.Name = "NumQuantidade";
            this.NumQuantidade.Size = new System.Drawing.Size(74, 22);
            this.NumQuantidade.TabIndex = 16;
            this.NumQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumPreco
            // 
            this.NumPreco.DecimalPlaces = 2;
            this.NumPreco.Location = new System.Drawing.Point(158, 144);
            this.NumPreco.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumPreco.Name = "NumPreco";
            this.NumPreco.Size = new System.Drawing.Size(83, 22);
            this.NumPreco.TabIndex = 17;
            // 
            // ChkDisponivel
            // 
            this.ChkDisponivel.AutoSize = true;
            this.ChkDisponivel.Location = new System.Drawing.Point(410, 91);
            this.ChkDisponivel.Name = "ChkDisponivel";
            this.ChkDisponivel.Size = new System.Drawing.Size(93, 20);
            this.ChkDisponivel.TabIndex = 18;
            this.ChkDisponivel.Text = "Disponível";
            this.ChkDisponivel.UseVisualStyleBackColor = true;
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Location = new System.Drawing.Point(506, 198);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(97, 23);
            this.BtnCadastro.TabIndex = 20;
            this.BtnCadastro.Text = "Cadastrar";
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(609, 198);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 21;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(342, 250);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 22;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(434, 250);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 23;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(41, 252);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(133, 22);
            this.TxtBusca.TabIndex = 24;
            // 
            // BtnBusca
            // 
            this.BtnBusca.Location = new System.Drawing.Point(180, 250);
            this.BtnBusca.Name = "BtnBusca";
            this.BtnBusca.Size = new System.Drawing.Size(75, 23);
            this.BtnBusca.TabIndex = 25;
            this.BtnBusca.Text = "Busca";
            this.BtnBusca.UseVisualStyleBackColor = true;
            this.BtnBusca.Click += new System.EventHandler(this.BtnBusca_Click);
            // 
            // DtgProduto
            // 
            this.DtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProduto.Location = new System.Drawing.Point(41, 288);
            this.DtgProduto.Name = "DtgProduto";
            this.DtgProduto.RowHeadersWidth = 51;
            this.DtgProduto.RowTemplate.Height = 24;
            this.DtgProduto.Size = new System.Drawing.Size(708, 150);
            this.DtgProduto.TabIndex = 19;
            this.DtgProduto.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgProduto_RowHeaderMouseDoubleClick);
            // 
            // CblFornecedor
            // 
            this.CblFornecedor.FormattingEnabled = true;
            this.CblFornecedor.Location = new System.Drawing.Point(275, 145);
            this.CblFornecedor.Name = "CblFornecedor";
            this.CblFornecedor.Size = new System.Drawing.Size(100, 24);
            this.CblFornecedor.TabIndex = 26;
            // 
            // LblAleatorio
            // 
            this.LblAleatorio.AutoSize = true;
            this.LblAleatorio.Location = new System.Drawing.Point(690, 206);
            this.LblAleatorio.Name = "LblAleatorio";
            this.LblAleatorio.Size = new System.Drawing.Size(61, 16);
            this.LblAleatorio.TabIndex = 27;
            this.LblAleatorio.Text = "Aleatorio";
            this.LblAleatorio.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmAjuda,
            this.TsmVoltar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmAjuda
            // 
            this.TsmAjuda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TsmAjuda.Name = "TsmAjuda";
            this.TsmAjuda.Size = new System.Drawing.Size(62, 24);
            this.TsmAjuda.Text = "Ajuda";
            this.TsmAjuda.Click += new System.EventHandler(this.TsmAjuda_Click);
            // 
            // TsmVoltar
            // 
            this.TsmVoltar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TsmVoltar.Name = "TsmVoltar";
            this.TsmVoltar.Size = new System.Drawing.Size(62, 24);
            this.TsmVoltar.Text = "Voltar";
            this.TsmVoltar.Click += new System.EventHandler(this.TsmVoltar_Click);
            // 
            // FrmCadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAleatorio);
            this.Controls.Add(this.CblFornecedor);
            this.Controls.Add(this.BtnBusca);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCadastro);
            this.Controls.Add(this.DtgProduto);
            this.Controls.Add(this.ChkDisponivel);
            this.Controls.Add(this.NumPreco);
            this.Controls.Add(this.NumQuantidade);
            this.Controls.Add(this.DtValidade);
            this.Controls.Add(this.DtCadastro);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.TxtProduto);
            this.Controls.Add(this.LblFornecedor);
            this.Controls.Add(this.LblPreço);
            this.Controls.Add(this.LblQuantidade);
            this.Controls.Add(this.LblDisponivel);
            this.Controls.Add(this.LblValidade);
            this.Controls.Add(this.LblDataCad);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblProduto);
            this.Controls.Add(this.LblAreaCadProd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadProd";
            this.Text = "Cadastro e Pesquisa de Produtos";
            this.Load += new System.EventHandler(this.FrmCadProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProduto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAreaCadProd;
        private System.Windows.Forms.Label LblProduto;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Label LblDataCad;
        private System.Windows.Forms.Label LblValidade;
        private System.Windows.Forms.Label LblDisponivel;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.Label LblPreço;
        private System.Windows.Forms.Label LblFornecedor;
        private System.Windows.Forms.TextBox TxtProduto;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.DateTimePicker DtCadastro;
        private System.Windows.Forms.DateTimePicker DtValidade;
        private System.Windows.Forms.NumericUpDown NumQuantidade;
        private System.Windows.Forms.NumericUpDown NumPreco;
        private System.Windows.Forms.CheckBox ChkDisponivel;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.Button BtnBusca;
        private System.Windows.Forms.DataGridView DtgProduto;
        private System.Windows.Forms.ComboBox CblFornecedor;
        private System.Windows.Forms.Label LblAleatorio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem TsmVoltar;
    }
}