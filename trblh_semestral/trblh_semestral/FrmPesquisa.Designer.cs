namespace trblh_semestral
{
    partial class FrmPesquisa
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
            this.LblProduto = new System.Windows.Forms.Label();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.LblDisponibilidade = new System.Windows.Forms.Label();
            this.LblValidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtValidade = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltro = new System.Windows.Forms.Button();
            this.DtgPesquisa = new System.Windows.Forms.DataGridView();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.TxtDisponibilidade = new System.Windows.Forms.TextBox();
            this.TxtFornecedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProduto
            // 
            this.LblProduto.AutoSize = true;
            this.LblProduto.Location = new System.Drawing.Point(44, 82);
            this.LblProduto.Name = "LblProduto";
            this.LblProduto.Size = new System.Drawing.Size(112, 16);
            this.LblProduto.TabIndex = 0;
            this.LblProduto.Text = "Nome do produto";
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.Location = new System.Drawing.Point(287, 82);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(131, 16);
            this.LblFornecedor.TabIndex = 1;
            this.LblFornecedor.Text = "Nome do fornecedor";
            // 
            // LblDisponibilidade
            // 
            this.LblDisponibilidade.AutoSize = true;
            this.LblDisponibilidade.Location = new System.Drawing.Point(44, 155);
            this.LblDisponibilidade.Name = "LblDisponibilidade";
            this.LblDisponibilidade.Size = new System.Drawing.Size(102, 16);
            this.LblDisponibilidade.TabIndex = 2;
            this.LblDisponibilidade.Text = "Disponibilidade";
            // 
            // LblValidade
            // 
            this.LblValidade.AutoSize = true;
            this.LblValidade.Location = new System.Drawing.Point(287, 152);
            this.LblValidade.Name = "LblValidade";
            this.LblValidade.Size = new System.Drawing.Size(111, 16);
            this.LblValidade.TabIndex = 3;
            this.LblValidade.Text = "Data de validade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Área de Pesquisa\r\n\r\nSelecione os dados para filtrar o resultado da pesquisa";
            // 
            // DtValidade
            // 
            this.DtValidade.Location = new System.Drawing.Point(290, 172);
            this.DtValidade.Name = "DtValidade";
            this.DtValidade.Size = new System.Drawing.Size(260, 22);
            this.DtValidade.TabIndex = 10;
            // 
            // BtnFiltro
            // 
            this.BtnFiltro.Location = new System.Drawing.Point(594, 153);
            this.BtnFiltro.Name = "BtnFiltro";
            this.BtnFiltro.Size = new System.Drawing.Size(105, 42);
            this.BtnFiltro.TabIndex = 11;
            this.BtnFiltro.Text = "Filtrar";
            this.BtnFiltro.UseVisualStyleBackColor = true;
            this.BtnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // DtgPesquisa
            // 
            this.DtgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPesquisa.Location = new System.Drawing.Point(47, 258);
            this.DtgPesquisa.Name = "DtgPesquisa";
            this.DtgPesquisa.RowHeadersWidth = 51;
            this.DtgPesquisa.RowTemplate.Height = 24;
            this.DtgPesquisa.Size = new System.Drawing.Size(652, 150);
            this.DtgPesquisa.TabIndex = 12;
            // 
            // TxtProduto
            // 
            this.TxtProduto.Location = new System.Drawing.Point(47, 101);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(100, 22);
            this.TxtProduto.TabIndex = 13;
            // 
            // TxtDisponibilidade
            // 
            this.TxtDisponibilidade.Location = new System.Drawing.Point(47, 174);
            this.TxtDisponibilidade.Name = "TxtDisponibilidade";
            this.TxtDisponibilidade.Size = new System.Drawing.Size(100, 22);
            this.TxtDisponibilidade.TabIndex = 14;
            // 
            // TxtFornecedor
            // 
            this.TxtFornecedor.Location = new System.Drawing.Point(290, 101);
            this.TxtFornecedor.Name = "TxtFornecedor";
            this.TxtFornecedor.Size = new System.Drawing.Size(100, 22);
            this.TxtFornecedor.TabIndex = 15;
            // 
            // FrmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtFornecedor);
            this.Controls.Add(this.TxtDisponibilidade);
            this.Controls.Add(this.TxtProduto);
            this.Controls.Add(this.DtgPesquisa);
            this.Controls.Add(this.BtnFiltro);
            this.Controls.Add(this.DtValidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblProduto);
            this.Controls.Add(this.LblValidade);
            this.Controls.Add(this.LblDisponibilidade);
            this.Controls.Add(this.LblFornecedor);
            this.Name = "FrmPesquisa";
            this.Text = "Pesquisa de produtos";
            this.Load += new System.EventHandler(this.FrmPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProduto;
        private System.Windows.Forms.Label LblFornecedor;
        private System.Windows.Forms.Label LblDisponibilidade;
        private System.Windows.Forms.Label LblValidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFiltro;
        private System.Windows.Forms.DateTimePicker DtValidade;
        private System.Windows.Forms.DataGridView DtgPesquisa;
        private System.Windows.Forms.TextBox TxtProduto;
        private System.Windows.Forms.TextBox TxtDisponibilidade;
        private System.Windows.Forms.TextBox TxtFornecedor;
    }
}